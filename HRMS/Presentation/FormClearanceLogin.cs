using Data.Access;
using Data.Entities;
using System.Data;
using System.Windows.Forms;
using static Presentation.Properties.Settings;
namespace Presentation
{
    public partial class FormClearanceLogin : Form
    {
        private UserAccess access;
        private EmployeeAccess access_employee;
        private FormLogin main;
        public FormClearanceLogin(FormLogin form)
        {
            InitializeComponent();
            this.access = new UserAccess();
            this.access_employee = new EmployeeAccess();

            main = form;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            var user = new User()
            {
                Username = username.Text,
                Password = password.Text
            };

            if(access.LoginAsAdmin(user))
            {
                DataRow row = access.GetUserByID(int.Parse(user.Username));
                DataRow row_user = access_employee.GetEmployeeInfo(int.Parse(user.Username));

                Default.UserAccessType = row["TitanTitle"].ToString();
                Default.EmployeeID = user.Username;
                Default.UserFirstname = row_user["Firstname"].ToString();
                Default.UserLastname = row_user["Lastname"].ToString();
                
                FormMain form_main = new FormMain();
                form_main.Show();
                main.Hide();
                this.Hide();
            }
            else if(username.Text.Equals(Default.username3086)
                    && password.Text.Equals(Default.password3086))
            {
                Default.UserAccessType = "Admin";
                FormMain form_main = new FormMain();
                form_main.Show();
                main.Hide();
                this.Hide();
            }
            else
            {
                username.ResetText();
                password.ResetText();
            }
        }
    }
}
