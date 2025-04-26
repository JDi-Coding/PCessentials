using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;    // ← für ProtectedData & DataProtectionScope
using System.Text;
using Newtonsoft.Json;

namespace PCessentials
{
    /// <summary>
    /// Verantwortlich für das sichere Speichern und Verwalten
    /// von Service-Kategorien und zugehörigen Login-Daten.
    /// </summary>
    public class PasswortManager
    {
        private const string DataFileName = "passwords.dat";
        private readonly string dataFilePath;
        private Dictionary<string, List<PasswordEntry>> categories;

        public PasswortManager()
        {
            var appDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "PCessentials"
            );
            Directory.CreateDirectory(appDir);
            dataFilePath = Path.Combine(appDir, DataFileName);
            Load();
        }

        public class PasswordEntry
        {
            public string Name { get; set; }
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Email { get; set; }
            public string Telephone { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Other { get; set; }
        }

        public IEnumerable<string> GetCategories() =>
            new List<string>(categories.Keys);

        public void AddCategory(string serviceName)
        {
            if (string.IsNullOrWhiteSpace(serviceName))
                throw new ArgumentException("Service-Name darf nicht leer sein.");
            if (categories.ContainsKey(serviceName))
                throw new InvalidOperationException("Diese Kategorie existiert bereits.");

            categories[serviceName] = new List<PasswordEntry>();
            Save();
        }

        public void RenameCategory(string oldName, string newName)
        {
            if (!categories.ContainsKey(oldName))
                throw new KeyNotFoundException("Alte Kategorie nicht gefunden.");
            if (categories.ContainsKey(newName))
                throw new InvalidOperationException("Ziel-Kategorie existiert schon.");

            var entries = categories[oldName];
            categories.Remove(oldName);
            categories[newName] = entries;
            Save();
        }

        public void RemoveCategory(string serviceName)
        {
            if (!categories.ContainsKey(serviceName))
                throw new KeyNotFoundException("Kategorie nicht gefunden.");
            if (categories[serviceName].Count > 0)
                throw new InvalidOperationException("Kategorie enthält noch Einträge.");

            categories.Remove(serviceName);
            Save();
        }

        public IEnumerable<PasswordEntry> GetEntries(string serviceName)
        {
            if (!categories.ContainsKey(serviceName))
                throw new KeyNotFoundException("Kategorie nicht gefunden.");
            return new List<PasswordEntry>(categories[serviceName]);
        }

        public void AddEntry(string serviceName, PasswordEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (!categories.ContainsKey(serviceName))
                throw new KeyNotFoundException("Kategorie nicht gefunden.");

            categories[serviceName].Add(entry);
            Save();
        }

        public void UpdateEntry(string serviceName, PasswordEntry updatedEntry)
        {
            if (updatedEntry == null) throw new ArgumentNullException(nameof(updatedEntry));
            if (!categories.ContainsKey(serviceName))
                throw new KeyNotFoundException("Kategorie nicht gefunden.");

            var list = categories[serviceName];
            var idx = list.FindIndex(e => e.Id == updatedEntry.Id);
            if (idx < 0) throw new KeyNotFoundException("Eintrag nicht gefunden.");

            list[idx] = updatedEntry;
            Save();
        }

        public void RemoveEntry(string serviceName, Guid entryId)
        {
            if (!categories.ContainsKey(serviceName))
                throw new KeyNotFoundException("Kategorie nicht gefunden.");

            var list = categories[serviceName];
            var removed = list.RemoveAll(e => e.Id == entryId);
            if (removed == 0) throw new KeyNotFoundException("Eintrag nicht gefunden.");

            Save();
        }

        /// <summary>
        /// Exportiert die verschlüsselte Datenbank als Base64-kodiertes JSON.
        /// </summary>
        /// <param name="exportPath">Pfad zur Export-Datei (z. B. export.json)</param>
        public void ExportToJson(string exportPath)
        {
            if (!File.Exists(dataFilePath))
                throw new FileNotFoundException("Keine gespeicherten Passwörter gefunden.", dataFilePath);

            var encrypted = File.ReadAllBytes(dataFilePath);
            var wrapper = new ExportWrapper { Data = Convert.ToBase64String(encrypted) };
            var json = JsonConvert.SerializeObject(wrapper, Formatting.Indented);
            File.WriteAllText(exportPath, json, Encoding.UTF8);
        }

        /// <summary>
        /// Importiert eine Base64-kodierte JSON-Datei und überschreibt die lokale Datenbank.
        /// </summary>
        /// <param name="importPath">Pfad zur Import-Datei (z. B. export.json)</param>
        public void ImportFromJson(string importPath)
        {
            if (!File.Exists(importPath))
                throw new FileNotFoundException("Import-Datei nicht gefunden.", importPath);

            var json = File.ReadAllText(importPath, Encoding.UTF8);
            var wrapper = JsonConvert.DeserializeObject<ExportWrapper>(json)
                         ?? throw new InvalidDataException("Ungültiges Import-Format.");

            var encrypted = Convert.FromBase64String(wrapper.Data);
            var plain = ProtectedData.Unprotect(encrypted, null, DataProtectionScope.CurrentUser);
            categories = JsonConvert.DeserializeObject<Dictionary<string, List<PasswordEntry>>>(Encoding.UTF8.GetString(plain))
                         ?? new Dictionary<string, List<PasswordEntry>>();

            // Lokale Datei aktualisieren
            Save();
        }

        private class ExportWrapper
        {
            public string Data { get; set; }
        }

        private void Load()
        {
            if (!File.Exists(dataFilePath))
            {
                categories = new Dictionary<string, List<PasswordEntry>>();
                return;
            }

            var encrypted = File.ReadAllBytes(dataFilePath);
            var plain = ProtectedData
                           .Unprotect(encrypted, null, DataProtectionScope.CurrentUser);
            var json = Encoding.UTF8.GetString(plain);
            categories = JsonConvert
                                .DeserializeObject<Dictionary<string, List<PasswordEntry>>>(json)
                           ?? new Dictionary<string, List<PasswordEntry>>();
        }

        private void Save()
        {
            var json = JsonConvert.SerializeObject(
                                categories,
                                Newtonsoft.Json.Formatting.Indented
                            );
            var plain = Encoding.UTF8.GetBytes(json);
            var encrypted = ProtectedData
                                .Protect(plain, null, DataProtectionScope.CurrentUser);
            File.WriteAllBytes(dataFilePath, encrypted);
        }

        public string getPath()
        {
            return dataFilePath;
        }
    }
}
