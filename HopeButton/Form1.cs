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
        /*******************************
         HERE THERE BE OUR OWN FUNCTIONS 
         *******************************/

        // Declaring some useful variables.
        private Log currentLog = new Log();
        private Player One = new Player("Seth");

        // Load the Logs.
        public Log[] logHope = new Log[50];

        public void GetLogs()
        {
            string inName;
            string inDescrip;
            long inNumber;

            // Test Logs
            for (int i = 0; i < 50; i++)
            {
                inNumber = 10 * (i + 1);

                inName = "HOPE Milestone: " + inNumber;
                inDescrip = inNumber + " HOPE produced in total. Maybe this isn't so bad, after all.";
                currentLog = new Log(inName, inDescrip, inNumber);
                logHope[i] = currentLog;
            }

        }

        // Adds a log to the Visible Logs list box.
        public void AddLog()
        {
            logVisible.Items.Add(currentLog);
            txtboxLogName.Text = currentLog.LogName;
            txtboxLogDescrip.Text = currentLog.LogDescrip;
        }

        // Sometimes we need to change the progress bars.
        // (I wonder if there's not already a method for this? Owo)
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

        // Update and synchronise the miscellaneous player data.
        public void UpdatePlayerBox()
        {
            lblName.Text = "Name: " + One.Name;
            lblTotalDays.Text = "Days Worked: " + One.TotalDays.ToString();
            lblTotalHope.Text = "HOPE: " + One.TotalHope.ToString();
        }

        /******************************
         HERE THERE BE FORM'S FUNCTIONS 
         ******************************/

        // START GAME
        public formGame()
        {
            InitializeComponent();

            UpdatePlayerBox();
            GetLogs();

            

            string inName = "First Day Tutorial";
            string inDescrip = "Press the button to produce HOPE, filling the Production bar.";
            currentLog = new Log(inName, inDescrip);
            AddLog();
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
            
            // Update the total number of times the button has been pressed!
            One.TotalHope++;
            UpdatePlayerBox();

            // Check for logs!
            currentLog = (Log) logHope[One.IndexHope];

            if (currentLog.LogNumber == One.TotalHope)
            {
                AddLog();
                One.IndexHope++;
            }

        }

        // Don't dilly dally!
        private void timeProg_Tick(object sender, EventArgs e)
        {

            // Step down the Product progress bar.
            if (StepProgBar(progProduct, -1))
            {
                MessageBox.Show("You're going too slow!");
                System.Windows.Forms.Application.Exit();
            }

            // Step up the Clock progress bar.
            if (StepProgBar(progClock, 1))
            {
                MessageBox.Show("Congratulations! You completed your shift!");
                System.Windows.Forms.Application.Exit();
            }

            /*
            // Check for "Half Way" story log.
            if (progClock.Value == (progClock.Maximum / 2))
            {
                //AddLog(logStory);
            }
            */

            UpdatePlayerBox();
        }

        // Here there be logs to read
        private void lstbxVisibleLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLog = (Log)logVisible.SelectedItem;
            txtboxLogName.Text = currentLog.LogName;
            txtboxLogDescrip.Text = currentLog.LogDescrip;
        }
    }
}