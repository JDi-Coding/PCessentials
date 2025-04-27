using AngleSharp.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PCessentials.assets.MainForm
{
    /// <summary>
    /// Verwaltet die verfügbaren Child-Forms und erstellt sie bei Bedarf.
    /// Logik und GUI sind somit sauber getrennt.
    /// </summary>
    public class FormService
    {
        private readonly Dictionary<string, Func<Form>> formFactories;
        private readonly HashSet<string> excludeNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
    {
        "MainForm", // Exclude MainForm from dynamic form list
    };

        public FormService()
        {
            // Automatically find all subclasses of Form inside the namespace PCessentials.Forms
            formFactories = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Form))
                             && t.Namespace == "PCessentials.Forms"
                             && !excludeNames.Contains(t.Name))
                .ToDictionary(
                    t => t.Name,
                    t => (Func<Form>)(() => (Form)Activator.CreateInstance(t))
                );
        }

        /// <summary>
        /// Returns the names of all found forms (sorted alphabetically).
        /// </summary>
        public IEnumerable<string> getFormNames() => formFactories.Keys.OrderBy(k => k);

        /// <summary>
        /// Creates a new form instance based on the form name.
        /// </summary>
        public Form createForm(string formName)
        {
            if (formFactories.TryGetValue(formName, out var factory))
                return factory();
            throw new ArgumentException($"Form '{formName}' not found.", nameof(formName));
        }
    }
}
