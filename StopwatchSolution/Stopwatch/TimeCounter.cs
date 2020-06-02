using System;
using System.Windows.Forms;
using System.Drawing;

namespace Stopwatch
{
    public enum CounterState
    {
        Idle,
        Active,
        Paused
    }

    public enum CounterResetType
    {
        FullStop,
        ResetRest
    }   

    class TimeCounter
    {       
        public Label LabelWork { get; private set; } = null;
        public Label LabelRest { get; private set; } = null;
        public TimeSpan WorkTime { get; private set; }
        public TimeSpan RestTime { get; private set; }
        /// <summary>
        /// Interval between display updates in milliseconds
        /// </summary>
        public int UpdateInterval 
        { 
            get { if (timer != null) return timer.Interval; else return 0; }
            set { if (timer != null) timer.Interval = value; }
        }

        private CounterState state = CounterState.Idle;
        private DateTime lastUpdateTime;
        private Timer timer;

        // Display colors
        private Color workColor = Color.Black;
        private Color restColor = Color.DarkRed;
        private Color idleColor = Color.DimGray;

        #region Constructors
        public TimeCounter()
        {
            this.Reset(CounterResetType.FullStop);
            
            timer = new Timer();
            timer.Interval = 250;
            // Action that will hapen every time "the interval reaches 0"
            timer.Tick += new EventHandler(OnUpdateDisplayTick);
            timer.Start();
        }
        public TimeCounter(Label labelWork, Label labelRest) 
            : this()
        {
            this.LabelWork = labelWork;
            this.LabelRest = labelRest;

            UpdateLabelColors();
        }
        #endregion

        #region Counter Management
        public void Start()
        {
            if (state == CounterState.Idle) this.Reset(CounterResetType.FullStop);
            UpdateDisplay();
            
            state = CounterState.Active;
            UpdateLabelColors();
        }
        public void Stop()
        {
            UpdateDisplay();

            state = CounterState.Paused;
            UpdateLabelColors();
        }
        public void Reset(CounterResetType type)
        {
            // Deep reset, stop the timer and reset all displays with their values
            if (type == CounterResetType.FullStop)
            {
                WorkTime = new TimeSpan(0, 0, 0);
                lastUpdateTime = DateTime.Now;
                state = CounterState.Idle;
            }
            
            // Rest time is reset in both possible types
            RestTime = new TimeSpan(0, 0, 0);
            // Displays must be updated in all possible reset types
            UpdateLabelColors();
            ShowTime();         
        }
        public void Reset()
        {
            this.Reset(CounterResetType.FullStop);
        }
        #endregion

        #region Display Updater
        // Updates corresponding values with elapsed time
        private void OnUpdateDisplayTick(Object myObject, EventArgs myEventArgs)
        {
            UpdateDisplay();
        }
        /// <summary>
        /// Adds all the leftovers between current time and last update to corresponding variables
        /// and updates thier visual displays with new values
        /// </summary>
        private void UpdateDisplay()
        {
            switch (state)
            {
                case CounterState.Active:
                    WorkTime += DateTime.Now - lastUpdateTime;
                    lastUpdateTime = DateTime.Now;

                    if (LabelWork != null) LabelWork.Text = TimeConverter.TimeSpanToString(WorkTime);
                break;

                case CounterState.Paused:
                    RestTime += DateTime.Now - lastUpdateTime;
                    lastUpdateTime = DateTime.Now;

                    if (LabelRest != null) LabelRest.Text = TimeConverter.TimeSpanToString(RestTime);
                break;       
                
                case CounterState.Idle: 
                    // Counter hasn't been started yet
                break;
            } 
        }
        /// <summary>
        /// Shows time as it is stored in TimeCounter, doesn't change any values
        /// </summary>
        private void ShowTime()
        {
            if (LabelWork != null) LabelWork.Text = TimeConverter.TimeSpanToString(WorkTime);
            if (LabelRest != null) LabelRest.Text = TimeConverter.TimeSpanToString(RestTime);
        }
        /// <summary>
        /// Changes display color based on current state
        /// </summary>
        private void UpdateLabelColors()
        {
            if (LabelWork == null || LabelRest == null) return;
            
            switch (state)
            {
                // Work timer is active
                case CounterState.Active:
                    LabelWork.ForeColor = workColor;
                    LabelRest.ForeColor = idleColor;  
                break;
                // Rest timer is active
                case CounterState.Paused:
                    LabelWork.ForeColor = idleColor;
                    LabelRest.ForeColor = restColor;
                break;       
                // No timer is active
                case CounterState.Idle: 
                    LabelWork.ForeColor = idleColor;
                    LabelRest.ForeColor = idleColor;
                break;
            }
        }
        #endregion
    }
}
