using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormCheckVacancies : Form
    {
        private FormExternalApplicant form_applicant;
        public FormCheckVacancies()
        {
            InitializeComponent();
            this.form_applicant = new FormExternalApplicant();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            
        }
    }
}
