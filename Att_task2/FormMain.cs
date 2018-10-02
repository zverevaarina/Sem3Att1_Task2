using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Att_task2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRating_Click(object sender, EventArgs e)
        {

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            //для Firm
            var resFirm = new Firm(textBoxName.Text, Convert.ToInt32(textBoxIncome.Text), Convert.ToInt32(textBoxRating.Text));
            textBoxQ.Text = Convert.ToString(resFirm.QFunction());
            labelFirmInfo.Text = resFirm.ShowInfo();

            //для Investments
            var resInvestments = new Investments(textBoxName_2.Text, Convert.ToInt32(textBoxInvestments_2.Text), Convert.ToInt32(textBoxRating_2.Text), Convert.ToInt32(textBoxP.Text));
            textBoxQp.Text = Convert.ToString(resInvestments.QFunction());
            labelName_2.Text = resInvestments.ShowInfo();
        }
    }
}
