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
            
        // Sometimes we need to change the progress bars.
        public bool StepProgBar(ProgressBar progBar, int amount)
        {
            bool range = false;

            try
            {
                progBar.Value += amount;
            }
            catch (ArgumentOutOfRangeException)
            {
                range = true;
                timeProduct.Enabled = false;
            }

            return range;
        }

        // START GAME
        public formGame()
        {
            InitializeComponent();
            GetLogs();

            string message = "Click the button to produce HOPE.\n" +
                "Don't allow the Production bar to completely empty (Or you'll hurt yourself.)\n" +
                "Don't allow the Production bar to completely fill (Or you will be fired.)";

            viewLog = new Log("First Day Tutorial", message);
            txtboxLogName.Text = viewLog.LogName;
            txtboxLogDescrip.Text = viewLog.LogDescrip;
            lstbxVisibleLog.Items.Add(viewLog);
        }

        // Click the button to produce HOPE
        private void btnHope_Click(object sender, EventArgs e)
        {
            // Start the timer!
            if (timeProduct.Enabled != true)
            {
                timeProduct.Enabled = true;
                progEnergy.Value = 1000;
                progClock.Value = 0;
                btnHope.Text = "Click to produce HOPE";
            }

            // Reset the production bar!
            progProduct.Value = 100;

            // Remove some Energy!
            if(StepProgBar(progEnergy, -5))
            {
                MessageBox.Show("You're going too fast!");
                System.Windows.Forms.Application.Exit();
            }


            // Count the total number of times the button has been pressed!
            hopeTotal++;

            // Check for logs!
            viewLog = (Log)lstbxLog.Items[lstbxLog.SelectedIndex];

            if (viewLog.LogNumber == hopeTotal)
            {
                lstbxVisibleLog.Items.Add(viewLog);
                txtboxLogName.Text = viewLog.LogName;
                txtboxLogDescrip.Text = viewLog.LogDescrip;

                lstbxLog.SelectedIndex++;
            }

        }

        // Don't dilly dally!
        private void timeProg_Tick(object sender, EventArgs e)
        {
            if (StepProgBar(progEnergy, -1))
            {
                MessageBox.Show("You're going too fast!");
                System.Windows.Forms.Application.Exit();
            }

            if (StepProgBar(progProduct, -1))
            {
                MessageBox.Show("You're going too slow!");
                System.Windows.Forms.Application.Exit();
            }

            if (StepProgBar(progClock, 1))
            {
                MessageBox.Show("Congratulations! You completed your shift!");
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