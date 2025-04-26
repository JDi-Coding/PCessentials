// UIHelper.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PCessentials.assets
{
    /// <summary>
    /// Hilfsklasse für moderne ListBox-Styling.
    /// </summary>
    public static class UIHelper
    {
        public static void styleModernListBox(ListBox listBox)
        {
            // Grund-Einstellungen
            listBox.BorderStyle = BorderStyle.None;
            listBox.DrawMode = DrawMode.OwnerDrawFixed;
            listBox.ItemHeight = 30;
            listBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            listBox.BackColor = Color.White;
            listBox.ForeColor = Color.Black;  // Default-Farbe für den Normalzustand

            int hoverIndex = -1;
            Color selectionColor = Color.FromArgb(220, 220, 220);
            Color hoverColor = Color.FromArgb(240, 240, 240);
            Color normalText = Color.Black;
            Color selectedText = Color.Black; // oder DarkBlue o.ä., je nach Geschmack

            listBox.DrawItem += (sender, e) =>
            {
                if (e.Index < 0) return;

                bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                bool isHover = e.Index == hoverIndex;

                // 1) Hintergrund zeichnen
                Color bg = isSelected
                    ? selectionColor
                    : isHover
                        ? hoverColor
                        : listBox.BackColor;

                using (var backBrush = new SolidBrush(bg))
                    e.Graphics.FillRectangle(backBrush, e.Bounds);

                // 2) Text zeichnen
                Color txtColor = isSelected ? selectedText : normalText;
                TextRenderer.DrawText(
                    e.Graphics,
                    listBox.Items[e.Index].ToString(),
                    listBox.Font,
                    e.Bounds,
                    txtColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

                // 3) Optional: Fokusrechteck
                e.DrawFocusRectangle();
            };

            // Hover-Handling
            listBox.MouseMove += (sender, e) =>
            {
                int idx = listBox.IndexFromPoint(e.Location);
                if (idx != hoverIndex)
                {
                    hoverIndex = idx;
                    listBox.Invalidate(); // neu zeichnen
                }
            };
            listBox.MouseLeave += (sender, e) =>
            {
                hoverIndex = -1;
                listBox.Invalidate();
            };
        }

    }
}
