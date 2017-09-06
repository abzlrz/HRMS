using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data.Entities;

namespace Presentation.DialogBox.BackgroundHistory
{
    public partial class EducationBackground : UserControl
    {
        public EducationBackground()
        {
            InitializeComponent();
            this.Output = new List<Education>();  
        }

        private bool ValidateFields()
        {
            bool result = true;


            if (string.IsNullOrEmpty(tbx_School.Text))
                result = false;
            else
                result = true;

            if (string.IsNullOrEmpty(tbx_location.Text))
                result = false;
            else
                result = true;

            return result;
        }
        private void ResetFields()
        {
            tbx_School.ResetText();
            tbx_location.ResetText();
            dt1.ResetText();
            dt2.ResetText();
        }

        private void addClick(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Output.Add(new Education()
                {
                    Name = tbx_School.Text,
                    Location = tbx_location.Text,
                    SY = new Years(dt1.Value, dt2.Value)
                });

                listBox.Items.Add(tbx_School.Text);
                ResetFields();
            }
            else
            {
                MessageBox.Show("Please complete the fields!");
            }
        }
        private void OnLoad(object sender, EventArgs e)
        {
            if(Output.Count > 0)
            {
                btn_add.Enabled = true;
            }
        }
        private void removeClick(object sender, EventArgs e)
        {
            //specify what index of an item should be removed
            Output.RemoveAt(listBox.SelectedIndex);
            listBox.Items.RemoveAt(listBox.SelectedIndex);

            //enable specific buttons
            btn_remove.Enabled = false;
            btn_add.BringToFront();

            //resets all fields
            ResetFields();
        }
        private void listBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //transfer all data to the fields
                tbx_School.Text = Output[listBox.SelectedIndex].Name;
                tbx_location.Text = Output[listBox.SelectedIndex].Location;
                dt1.Value = Output[listBox.SelectedIndex].SY._from;
                dt2.Value = Output[listBox.SelectedIndex].SY._to;
            }
            catch
            {
                //this eliminates exceptions that might hinders the operation
            }
            finally
            {
                //enables specific buttons
                btn_save.BringToFront();
                btn_remove.Enabled = true;
            }
        }
        private void saveClick(object sender, EventArgs e)
        {
            //save data from fields to dataList Output
            Output[listBox.SelectedIndex].Name = tbx_School.Text;
            Output[listBox.SelectedIndex].Location = tbx_location.Text;
            Output[listBox.SelectedIndex].SY = new Years(dt1.Value, dt2.Value);

            //changes current item text on listbox
            listBox.Items[listBox.SelectedIndex] = Output[listBox.SelectedIndex].Name;

            //reset all fields
            ResetFields();

            //enable specific button
            btn_add.BringToFront();
        }

        public List<Education> Output;
    }
}
