using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace Stopwatch

{    
    public partial class Form1 : Form
    {

        #region Initialize Components
        bool timerSet = false;
        TimeSpan elapsed = new TimeSpan (0, 0, 0);
        TimeSpan elapsedPrevious = new TimeSpan(0, 0, 0);
        DateTime startTime; // Timer Start time;
        System.Timers.Timer tmr = new System.Timers.Timer(); // Only create the Timer once;

        bool timerSetRest = false;
        System.Timers.Timer timerRest = new System.Timers.Timer(); // Timer that shows how much time elapsed after Stop;
        TimeSpan elapsedRest = new TimeSpan (0, 0, 0);
        TimeSpan elapsedPreviousRest = new TimeSpan(0, 0, 0);
        DateTime startTimeRest; // Timer Start time;

        int hh, mm, ss;
        #endregion

        public Form1()
        {
            InitializeComponent();     
        }

        #region Normal Timer
        private void SetTimer()
        {           
            if (!timerSet)
            {
                timerSet = true;

                tmr.Interval = 1000;
                tmr.Elapsed += UpdateTime;                
            }

            if (timerSetRest) // Allows you to press Stop again (it will now have an effect)
            {
                ResetTimerRest(false); // Remembers previous time elapsed                
            }

            elapsedPrevious = elapsed;

            startTime = DateTime.Now;

            tmr.Start();                   
        }

        private void UpdateTime(Object sender, ElapsedEventArgs e)
        {
            // Count how much time has passed
            elapsed = DateTime.Now - startTime + elapsedPrevious;

            Action setNewTime = () => lbStopwatch.Text = CountTime(elapsed);
            lbStopwatch.Invoke(setNewTime);            
        }

        private void ResetTimer()
        {
            // Stop the timer;
            tmr.Stop();

            // Reset the Labels
            Action resetTime = () => lbStopwatch.Text = "00:00:00";
            lbStopwatch.Invoke(resetTime);
           
            // Reset the Variables
            elapsed = new TimeSpan(0,0,0);
            elapsedPrevious = new TimeSpan(0,0,0);

            // Reset the Rest timer
            ResetTimerRest(true);
        }

        private void StopTimer()
        {
            if (timerSet)
            {
                elapsedPrevious = elapsed;
            }

            SetTimerRest();
            tmr.Stop();
        }
        #endregion

        #region Rest Timer
        private void SetTimerRest()
        {           
            if (!timerSetRest && timerSet) // Prevents you from being able to mash the stop button to reset the Rest timer only
            {
                timerSetRest = true;

                timerRest.Interval = 1000;
                timerRest.Elapsed += UpdateTimeRest;    
                
                startTimeRest = DateTime.Now;
                elapsedPreviousRest = elapsedRest;

                timerRest.Start();  
            }

                             
        }              

        private void UpdateTimeRest(Object sender, ElapsedEventArgs e)
        {
            /*
             * Also Works, but loses ~10 seconds every 10 minutes; Isn't precise;
             * 
            string secondsFormat = (seconds % 60).ToString();
            string minutesFormat = (seconds / 60).ToString();
            string hoursFormat = (seconds / 60 / 60).ToString();
            string timeString = string.Format("{0:00}:{1:00}:{2:00}", hoursFormat, minutesFormat, secondsFormat);
            */
            
            // Count how much time has passed
            elapsedRest = DateTime.Now - startTimeRest + elapsedPreviousRest;    
            
            // Without CountTime, I get milliseconds shown
            Action setNewTime = () => lbStopwatchRest.Text = CountTime(elapsedRest); // Without CountTime, I get milliseconds shown
            lbStopwatchRest.Invoke(setNewTime);         
            
            // Change the colour
            if (elapsedRest != new TimeSpan(0,0,0)) 
            {
                SetRedColour();
            } else 
            {
                SetBlackColour();
            }
        }        
     
        private void ResetTimerRest(bool full) // Full reset means reseting Elapsed, too
        {
            // Stop the timer;
            timerRest.Stop();
          
            // Reset the Variables
            timerSetRest = false;
            if (full)
            {
                elapsedRest = new TimeSpan(0,0,0);
                elapsedPreviousRest = new TimeSpan(0,0,0);

                // Reset the Labels
                Action resetTime = () => lbStopwatchRest.Text = "00:00:00";
                lbStopwatchRest.Invoke(resetTime);
            }

            // Change the Colour back
            SetBlackColour();
        }
        #endregion

        #region General Methods
        // Count hrs, mins and seconds without decimals
        private string CountTime(TimeSpan timeSpan)
        // timeSpan - elapsed or elapsedRest, depending on Timer used
        {
            hh = timeSpan.Hours;
            mm = timeSpan.Minutes;
            ss = timeSpan.Seconds;

            string timeString = string.Format("{0:00}:{1:00}:{2:00}", hh, mm, ss);

            return timeString;
        }

        private void SetRedColour()
        {
            Action changeColour = () => lbStopwatchRest.ForeColor = Color.DarkRed;
            lbStopwatchRest.Invoke(changeColour);
        }

        private void SetBlackColour()
        {
            Action changeColour = () => lbStopwatchRest.ForeColor = Color.Black;
            lbStopwatchRest.Invoke(changeColour);
        }
        #endregion

        #region Button Clicks
        private void btnStart_Click(object sender, EventArgs e)
        {
            SetTimer();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Khud0/Stopwatch");
        }        

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void btnResetRest_Click(object sender, EventArgs e)
        {
            ResetTimerRest(true);
        }
        #endregion        
    }
}
