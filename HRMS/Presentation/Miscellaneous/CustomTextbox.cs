using System.Windows.Forms;

namespace Presentation.Miscellaneous
{
    public partial class CustomTextbox : TextBox
    {
        public InputType TextInputType { get; set; }
        public CustomTextbox()
        {
            InitializeComponent();
            this.KeyPress += CustomTextbox_KeyPress;
        }

        private void CustomTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (TextInputType)
            {
                case InputType.Numbers:
                    e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
                    break;


                case InputType.Letters:
                    e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
                    break;


                case InputType.Decimals:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                        e.Handled = true;
                    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                        e.Handled = true;
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public enum InputType
        {
            Numbers, Letters, Decimals
        }
    }
}
