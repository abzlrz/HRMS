using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace Presentation.DialogBox.ExternalApplicationForm
{
    public partial class FormBackgroundIllness : Form
    {
        public BindingList<Illness> illnesses;
        public BindingList<MedicalOperation> operations;
        public FormBackgroundIllness()
        {
            InitializeComponent();
            this.controlYesNoRadioButton1.radioButton1.ForeColor = Color.White;
            this.controlYesNoRadioButton1.radioButton2.ForeColor = Color.White;
            this.controlYesNoRadioButton2.radioButton1.ForeColor = Color.White;
            this.controlYesNoRadioButton2.radioButton2.ForeColor = Color.White;

            this.illnesses = new BindingList<Illness>();
            this.operations = new BindingList<MedicalOperation>();
        }

        private void LoadIllnessData()
        {
            view_illness.Clear();

            foreach (Illness illness in illnesses)
            {
                ListViewItem item = new ListViewItem(new string[] { illness.Description, illness.Details,
                    illness.IsDiagnosed.ToString(), illness.IsLifetime.ToString() });
                view_illness.Items.Add(item);
            }
        }

        private void FormBackgroundIllness_Load(object sender, EventArgs e)
        {
            LoadIllnessData();
        }
    }
}
