using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5Praktikum
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ListBoxInput.Items.Add(textBoxInput.Text);
            textBoxInput.Text = "";
            textBoxInput.Focus();
        }                    

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ListBoxInput.ClearSelected();
            ListBoxInput.Items.Clear();
        }

        private void ListBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelShowOutput.Text = ListBoxInput.Text;
        }

        private void radioButtonWarnaMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radioButtonWarnaMerah.Checked == true)
                {
                    labelShowOutput.ForeColor = Color.Red;
                }
                else if (radioButtonWarnaBiru.Checked == true)
                {
                    labelShowOutput.ForeColor = Color.Blue;
                }
            }            
        }

        private void radioButtonWarnaBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radioButtonWarnaMerah.Checked == true)
                {
                    labelShowOutput.ForeColor = Color.Red;
                }
                else if (radioButtonWarnaBiru.Checked == true)
                {
                    labelShowOutput.ForeColor = Color.Blue;
                }
            }            
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == false)
            {
                labelShowOutput.ForeColor = Color.Black;
            }
        }
    }
}
