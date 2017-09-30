using Data.Access;
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
        private JobPostingAccess access;
        private FormExternalApplicant form_applicant;
        public FormCheckVacancies()
        {
            InitializeComponent();
            this.form_applicant = new FormExternalApplicant();
            this.access = new JobPostingAccess();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            
        }

        private void FormCheckVacancies_Load(object sender, EventArgs e)
        {
            this.view_employee.DataSource = access.ShowData();
            this.view_employee.ClearSelection();
        }

        private void view_employee_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var gridview = sender as DataGridView;
                if (view_employee.SelectedRows.Count > 0)
                {
                    int index = int.Parse(gridview.SelectedRows[0].Cells[0].Value.ToString());
                    var item = access.GetDataByID(index);

                    lbl_detail_positiontype.Text = item["PositionType"].ToString();
                    lbl_detail_position.Text = item["Position"].ToString();
                    lbl_detail_posteddate.Text = item["PostedDate"].ToString();
                    lbl_detail_closedate.Text = item["CloseDate"].ToString();
                    lbl_detail_wage.Text = item["Wage"].ToString();
                    lbl_detail_headcount.Text = item["HeadCount"].ToString();
                    lbl_detail_location.Text = item["Location"].ToString();
                    link_detail_qualification.Text = item["Qualification"].ToString();
                    link_detail_jobdesc.Text = item["JobDescription"].ToString();
                }
            }
            catch { }
            finally
            {

            }
        }
    }
}
