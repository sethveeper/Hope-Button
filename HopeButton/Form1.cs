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
        public Log[] logHope = new Log[11];

        public void GetLogs()
        {
            logHope[0] = new Log("HOPE Milestone: 10", "10 HOPE produced in total. Producing HOPE takes up a small amount of Energy. Try not to run out...", 10);
            logHope[1] = new Log("HOPE Milestone: 50", "50 HOPE produced in total. Maybe this won't be so bad after all...", 50);
            logHope[2] = new Log("HOPE Milestone: 100", "100 HOPE produced in total. It doesn't seem like so many, but there they are...", 100);
            logHope[3] = new Log("HOPE Milestone: 500", "500 HOPE produced in total. How many more will you produce?", 500);
            logHope[4] = new Log("HOPE Milestone: 1000", "1000 HOPE produced in total. Every one of them will be consumed...", 1000);
            logHope[5] = new Log("HOPE Milestone: 10000", "10000 HOPE produced in total. How long have you been here?", 10000);
            logHope[6] = new Log("HOPE Milestone: 100000", "100000 HOPE produced in total. They will never be satisfied, will they...", 100000);
            logHope[7] = new Log("HOPE Milestone: 1000000", "1000000 HOPE produced in total. Perhaps one day you'll be able to rest...", 1000000);
            logHope[8] = new Log("HOPE Milestone: 10000000", "10000000 HOPE produced in total. How much longer can you stick it out?", 10000000);
            logHope[9] = new Log("HOPE Milestone: 100000000", "100000000 HOPE produced in total. You must be weary... Will you ever be able to stop?", 100000000);
            logHope[10] = new Log("HOPE Milestone: 1000000000", "1000000000 HOPE produced in total. Why are you here, anymore? What is the point?", 1000000000);
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