using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data.Entities;
using System.ComponentModel;

namespace Presentation.DialogBox.BackgroundHistory
{
    public partial class EducationBackground : UserControl
    {
        public EducationBackground()
        {
            InitializeComponent();
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

        private void OnLoad(object sender, EventArgs e)
        {
            
        }
        private void addClick(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                
                ResetFields();
            }
            else
            {
                MessageBox.Show("Please complete the fields!");
            }
        }
        private void removeClick(object sender, EventArgs e)
        {
            //specify what index of an item should be removed

            //enable specific buttons
            
            btn_add.BringToFront();

            //resets all fields
            ResetFields();
        }
        private void listBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //transfer all data to the fields
            }
            catch
            {
                //this eliminates exceptions that might hinders the operation
            }
            finally
            {
                //enables specific buttons
            }
        }
        private void saveClick(object sender, EventArgs e)
        {
            //save data from fields to dataList Output

            //changes current item text on listbox

            //reset all fields
            ResetFields();

            //enable specific button
            btn_add.BringToFront();
        }

        public BindingList<Education> Input;
    }
}
