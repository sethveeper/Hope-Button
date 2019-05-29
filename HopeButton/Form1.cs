using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeButton
{
    public partial class formGame : Form
    {
        private long hopeTotal = 0;
        
        private Log viewLog = new Log();

        public void GetLogs()
        {
            string inName;
            string inDescrip;
            int inNumber;

            for (int i = 1; i < 99; i++)
            {
                inNumber = i * 10;
                
                inName = "HOPE Milestone: " + inNumber;
                inDescrip = inNumber + " HOPE produced in total. How many more will you produce?";
                viewLog = new Log(inName, inDescrip, inNumber);
                lstbxLog.Items.Add(viewLog);
            }

            lstbxLog.SelectedIndex = 0;
        }
            

        public formGame()
        {
            InitializeComponent();
            GetLogs();

            MessageBox.Show("Click the button to produce HOPE. Don't allow the progress bar to completely empty, or completely fill.");
            progTime.Value = 50;
            timeProg.Enabled = true;
        }

        private void btnHope_Click(object sender, EventArgs e)
        {
            progTime.Value -= 5;
            hopeTotal++;
            viewLog = (Log) lstbxLog.Items[lstbxLog.SelectedIndex];
            if (progTime.Value <= 0)
            {
                timeProg.Enabled = false;
                MessageBox.Show("You're going too fast!");
                System.Windows.Forms.Application.Exit();
            }
            else if (viewLog.LogNumber == hopeTotal)
            {
                lstbxVisibleLog.Items.Add(viewLog);
                txtboxLogName.Text = viewLog.LogName;
                txtboxLogDescrip.Text = viewLog.LogDescrip;

                lstbxLog.SelectedIndex++;
            }
        }

        private void timeProg_Tick(object sender, EventArgs e)
        {
            progTime.Value += 5;

            if (progTime.Value >= 100)
            {
                timeProg.Enabled = false;
                MessageBox.Show("You're going too slow!");
                System.Windows.Forms.Application.Exit();
            }
        }

        private void lstbxVisibleLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewLog = (Log)lstbxVisibleLog.SelectedItem;
            txtboxLogName.Text = viewLog.LogName;
            txtboxLogDescrip.Text = viewLog.LogDescrip;
        }
    }
}