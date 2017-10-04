using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation
{
    public delegate bool InsertProc();
    static class TextboxExtensions
    {
        public static void AcceptEntry(this TextBox tbx, string expression)
        {
            var rgx = new Regex(expression);

            if (rgx.IsMatch(tbx.Text))
            {
                tbx.Text = rgx.Replace(tbx.Text, "");
            }
        }
    }
    static class FormExtensions
    {
        public static void ClearAllFields(this Form form)
        {
            foreach (Control control in form.Controls)
            {
                ClearDeepInside(control);
            }
        }
        static void ClearDeepInside(Control control)
        {
            if (control.HasChildren)
            {
                foreach (Control subControl in control.Controls)
                {
                    ClearDeepInside(subControl);
                }
            }
            switch (control.GetType().Name)
            {
                case "TextBox":
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                    break;

                case "ComboBox":
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = -1;
                    else
                        comboBox.Text = null;
                    break;

                case "CheckBox":
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                    break;

                case "ListBox":
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                    break;

                case "NumericUpDown":
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = 0;
                    break;

                case "DateTimePicker":
                    DateTimePicker dTPicker = (DateTimePicker)control;
                    dTPicker.ResetText();
                    break;
            }
        }
        public static void ClosingConfirm(this Form form, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                form.ClearAllFields();
            }
            else
            {
                e.Cancel = (result == DialogResult.No);
            }
        }
    }
    static class PanelExtensions
    {
        public static string GetRadioButtonValue(this Panel panel)
        {
            string result = string.Empty;
            foreach (var c in panel.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = c as RadioButton;
                    if (rb.Checked) result = rb.Text;
                }
            }
            return result;
        }
        
        public static void ClearAll(this Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                ClearDeepInside(control);
            }
        }
        static void ClearDeepInside(Control control)
        {
            switch (control.GetType().Name)
            {
                case "TextBox":
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                    break;

                case "ComboBox":
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = -1;
                    else
                        comboBox.Text = null;
                    break;

                case "CheckBox":
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                    break;

                case "ListBox":
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                    break;

                case "NumericUpDown":
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = 0;
                    break;

                case "DateTimePicker":
                    DateTimePicker dTPicker = (DateTimePicker)control;
                    dTPicker.ResetText();
                    break;
            }
        }

    }
    static class UserControlExtensions
    {
        public static void ResetScrollbar(this UserControl ctrl)
        {
            ctrl.VerticalScroll.Value = 0;
        }
    }
    public static class Misc
    {
        public static void TurnGreenIndicator(DataTable table, Label source)
        {
            if (table.Rows.Count > 0)
                source.ImageIndex = 0;
            else
                source.ImageIndex = 1;
        }
        public static void TurnGreenIndicator(string text, Label source)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
                source.ImageIndex = 1;
            else if (text.Length < 2)
                source.ImageIndex = 1;
            else
                source.ImageIndex = 0;
        }
        public static void TurnGreenIndicator(string text, Label source, int length)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
                source.ImageIndex = 1;
            else if (text.Length < length)
                source.ImageIndex = 1;
            else
                source.ImageIndex = 0;
        }
        public static void TurnGreenIndicator(int index, Label source)
        {
            if (index == -1)
                source.ImageIndex = 1;
            else
                source.ImageIndex = 0;
        }
        public static void TurnGreenIndicator(MaskedTextBox tbs, Label source, bool IsRequired)
        {
            if (IsRequired)
            {
                if (tbs.MaskCompleted)
                    source.ImageIndex = 0;
                else
                    source.ImageIndex = 1;
            }
            else
            {
                if (tbs.Text.Length < 1)
                    source.ImageIndex = -1;
                else
                {
                    if (tbs.MaskCompleted)
                        source.ImageIndex = 0;
                    else
                        source.ImageIndex = 1;
                }
            }
        }
        
    }
    public class Draggable
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Form _form;

        public Draggable(Control ctrl, Form form)
        {
            ctrl = new Control();
            this._form = form;
        }

        public void Up(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public void Down(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = _form.Location;
        }

        public void Move(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                _form.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
    }

    interface IForm
    {
        void AddErrorMessage(string error);
        bool ValidateSelectedInfo();
        void EnableControl(bool arg);
        void ResetAll();
    }
}
