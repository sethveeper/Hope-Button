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
        // Declaring some useful variables.
        private long hopeTotal = 0;
        private Log viewLog = new Log();

        // Load the Logs.
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
            
        // START GAME
        public formGame()
        {
            InitializeComponent();
            GetLogs();

            string message = "Click the button to produce HOPE.\n" +
                "Don't allow the Production bar to completely empty (Or you'll hurt yourself.)\n" +
                "Don't allow the Production bar to completely fill (Or you will be fired.)";

            MessageBox.Show(message);
        }

        // Click the button to produce HOPE
        private void btnHope_Click(object sender, EventArgs e)
        {
            // Start the timer!

            if (timeProg.Enabled != true)
            {
                timeProg.Enabled = true;
                btnHope.Text = "Click to produce HOPE";
            }

            try
            {
                progTime.Value -= (progTime.Value / 5) + 3;
            }
            catch (ArgumentOutOfRangeException)
            {
                progTime.Value = 0;
                timeProg.Enabled = false;
                MessageBox.Show("You're going too fast!");
                System.Windows.Forms.Application.Exit();
            }
            finally
            {
                hopeTotal++;
                viewLog = (Log)lstbxLog.Items[lstbxLog.SelectedIndex];

                if (viewLog.LogNumber == hopeTotal)
                {
                    lstbxVisibleLog.Items.Add(viewLog);
                    txtboxLogName.Text = viewLog.LogName;
                    txtboxLogDescrip.Text = viewLog.LogDescrip;

                    lstbxLog.SelectedIndex++;
                }
            }
        }

        // Don't dilly dally!
        private void timeProg_Tick(object sender, EventArgs e)
        {
            try
            {
                progTime.Value += 10;
            }
            catch (ArgumentOutOfRangeException)
            {
                progTime.Value = 100;
                timeProg.Enabled = false;
                MessageBox.Show("You're going too slow!");
                System.Windows.Forms.Application.Exit();
            }
        }

        // Here there be logs to read
        private void lstbxVisibleLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewLog = (Log)lstbxVisibleLog.SelectedItem;
            txtboxLogName.Text = viewLog.LogName;
            txtboxLogDescrip.Text = viewLog.LogDescrip;
        }
    }
}