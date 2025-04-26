using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCessentials;


namespace PCessentials.Forms
{
    public partial class PSWManager : Form
    {
        private PasswortManager manager;

        public PSWManager()
        {
            InitializeComponent();
            manager = new PasswortManager();

            // 1) Kategorien laden
            RefreshCategoryList();

            // 2) Events verdrahten
            lstServices.SelectedIndexChanged += lstServices_SelectedIndexChanged;

            btnAddCategory.Click += btnAddCategory_Click;
            btnRenameCategory.Click += btnRenameCategory_Click;
            btnRemoveCategory.Click += btnRemoveCategory_Click;

            btnAddEntry.Click += btnAddEntry_Click;
            btnUpdateEntry.Click += btnUpdateEntry_Click;
            btnDeleteEntry.Click += btnDeleteEntry_Click;

            dgvEntries.SelectionChanged += dgvEntries_SelectionChanged;

            StyleDataGridView(dgvEntries);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            // Header
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // No row header, flat borders
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Alternating row color
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            // Selection style
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Padding inside cells
            dgv.DefaultCellStyle.Padding = new Padding(5);

            // Auto-size columns
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Single-row selection
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // **Zeilenhöhe automatisch an den Inhalt anpassen:**
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.RowTemplate.Height = dgv.RowTemplate.MinimumHeight + 5;       // extra Padding

            // Umrahmung jeder einzelnen Zelle
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.LightGray;

            // Optional: auch die Headerzellen umranden
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Damit die Zeilenhöhe weiter automatisch passt
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        #region Category Logic

        private void RefreshCategoryList()
        {
            lstServices.Items.Clear();
            lstServices.Items.AddRange(manager.GetCategories().ToArray());
            txtCategoryName.Clear();

            dgvEntries.DataSource = null;
            ClearEntryFields();
        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstServices.SelectedItem == null) return;
            string cat = lstServices.SelectedItem.ToString();
            txtCategoryName.Text = cat;
            RefreshEntries();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                manager.AddCategory(txtCategoryName.Text.Trim());
                RefreshCategoryList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRenameCategory_Click(object sender, EventArgs e)
        {
            if (lstServices.SelectedItem == null) return;
            string oldName = lstServices.SelectedItem.ToString();
            string newName = txtCategoryName.Text.Trim();
            try
            {
                manager.RenameCategory(oldName, newName);
                RefreshCategoryList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            if (lstServices.SelectedItem == null) return;
            string name = lstServices.SelectedItem.ToString();
            try
            {
                manager.RemoveCategory(name);
                RefreshCategoryList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region EntryLogic

        private void RefreshEntries()
        {
            string cat = lstServices.SelectedItem.ToString();
            var entries = manager.GetEntries(cat).Select(entry => new
            {
                entry.Name,
                entry.Id
            }).ToList();

            dgvEntries.DataSource = entries;
            ClearEntryFields();

            if (btnAddEntry.Enabled)
            {
                btnAddEntry.BackColor = Color.Green;
            }
            else
            {
                btnAddEntry.BackColor = Color.LightGray;
            }
        }

        private void dgvEntries_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEntries.CurrentRow == null) return;
            var selectedId = (Guid)dgvEntries.CurrentRow.Cells["Id"].Value;
            var entry = manager.GetEntries(lstServices.SelectedItem.ToString())
                                .FirstOrDefault(entryItem => entryItem.Id == selectedId);

            if (entry != null)
            {
                txtEntryName.Text = entry.Name;
                txtEmail.Text = entry.Email;
                txtTelephone.Text = entry.Telephone;
                txtUsername.Text = entry.Username;
                txtPassword.Text = entry.Password;
                txtOther.Text = entry.Other;
            }

            btnAddEntry.Enabled = false;
            btnUpdateEntry.Enabled = true;
            btnDeleteEntry.Enabled = true;
            if (btnAddEntry.Enabled)
            {
                btnAddEntry.BackColor = Color.Green;
            }
            else
            {
                btnAddEntry.BackColor = Color.LightGray;
            }
        }

        private void ClearEntryFields()
        {
            txtEntryName.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtOther.Clear();

            btnAddEntry.Enabled = true;
            btnUpdateEntry.Enabled = false;
            btnDeleteEntry.Enabled = false;
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            var entry = new PasswortManager.PasswordEntry
            {
                Name = txtEntryName.Text.Trim() ?? "NONE",
                Email = txtEmail.Text.Trim(),
                Telephone = txtTelephone.Text.Trim(),
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text,
                Other = txtOther.Text.Trim()
            };
            try
            {
                manager.AddEntry(lstServices.SelectedItem.ToString(), entry);
                RefreshEntries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateEntry_Click(object sender, EventArgs e)
        {
            if (dgvEntries.CurrentRow == null)
            {
                MessageBox.Show("Kein Eintrag ausgewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedId = (Guid)dgvEntries.CurrentRow.Cells["Id"].Value;
            var entry = manager.GetEntries(lstServices.SelectedItem.ToString())
                                .FirstOrDefault(entryItem => entryItem.Id == selectedId);

            if (entry == null)
            {
                MessageBox.Show("Eintrag nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entry.Email = txtEmail.Text.Trim();
            entry.Telephone = txtTelephone.Text.Trim();
            entry.Username = txtUsername.Text.Trim();
            entry.Password = txtPassword.Text;
            entry.Other = txtOther.Text.Trim();

            try
            {
                manager.UpdateEntry(lstServices.SelectedItem.ToString(), entry);
                RefreshEntries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            if (dgvEntries.CurrentRow == null)
            {
                MessageBox.Show("Kein Eintrag ausgewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedId = (Guid)dgvEntries.CurrentRow.Cells["Id"].Value;

            try
            {
                manager.RemoveEntry(lstServices.SelectedItem.ToString(), selectedId);
                RefreshEntries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        #endregion

        #region ButtonsEvents

        private void btn_CopyUN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUsername.Text);
        }

        private void btn_CopyPW_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
        }

        private void btn_CopyEMAIL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEmail.Text);
        }

        private void btn_CopyTel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTelephone.Text);
        }

        private void btn_CopyOther_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOther.Text);
        }

        private void ToggleVisibility(TextBox textBox, Button button)
        {
            if (textBox == null || button == null) return;

            textBox.UseSystemPasswordChar = !textBox.UseSystemPasswordChar;
            button.Text = textBox.UseSystemPasswordChar ? "Show" : "Hide";
        }

        private void btn_PW_Visibility_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                ToggleVisibility(txtPassword, button);
            }
        }

        private void btn_UN_Visibility_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                ToggleVisibility(txtUsername, button);
            }
        }

        private void btn_EMAIL_Visibility_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                ToggleVisibility(txtEmail, button);
            }
        }

        private void btn_TEL_Visibility_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                ToggleVisibility(txtTelephone, button);
            }
        }

        private void btn_OTHER_Visibility_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                ToggleVisibility(txtOther, button);
            }
        }


        #endregion ButtonsEvents

        private void PSWManager_Load(object sender, EventArgs e)
        {
            //this.Text = manager.getPath();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Exportiere Datenbank";
                saveFileDialog.FileName = "PWManagerData.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        manager.ExportToJson(saveFileDialog.FileName);
                        MessageBox.Show("Export erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler beim Export: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Importiere Datenbank";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        manager.ImportFromJson(openFileDialog.FileName);
                        MessageBox.Show("Import erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshCategoryList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler beim Import: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
