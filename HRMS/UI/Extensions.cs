using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI
{
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

    interface IForm
    {
        void AddErrorMessage(string error);
        bool ValidateSelectedInfo();
        void EnableControl(bool arg);
        void ResetAll();
    }
    
}
