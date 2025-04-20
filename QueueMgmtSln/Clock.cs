using System;
using System.Threading;

namespace QueueMgmtSln
{
    /* ======================= Event Publisher =============================== */

    // Our subject -- it is this class that other classes
    // will observe. This class publishes one event:
    // SecondChange. The observers subscribe to that event.
    public class Clock
    {
        // Private Fields holding the hour, minute and second
        private int _hour;
        private int _minute;
        private int _second;

        // The delegate named SecondChangeHandler, which will encapsulate
        // any method that takes a clock object and a TimeInfoEventArgs
        // object as the parameter and returns no value. It's the
        // delegate the subscribers must implement.
        public delegate void SecondChangeHandler(
           object clock,
           TimeInfoEventArgs timeInformation
        );

        // The event we publish
        public event SecondChangeHandler SecondChange;

        // The method which fires the Event
        protected void OnSecondChange(
           object clock,
           TimeInfoEventArgs timeInformation
        )
        {
            // Check if there are any Subscribers
            if (SecondChange != null)
            {
                // Call the Event
                SecondChange(clock, timeInformation);
            }
        }

        // Set the clock running, it will raise an
        // event for each new second
        public void Run()
        {
            for (; ; )
            {
                // Sleep 1 Second
                Thread.Sleep(1000);

                // Get the current time
                System.DateTime dt = System.DateTime.Now;

                // If the second has changed
                // notify the subscribers
                if (dt.Second != _second)
                {
                    // Create the TimeInfoEventArgs object
                    // to pass to the subscribers
                    TimeInfoEventArgs timeInformation =
                       new TimeInfoEventArgs(
                       dt.Hour, dt.Minute, dt.Second);

                    // If anyone has subscribed, notify them
                    OnSecondChange(this, timeInformation);
                }

                // update the state
                _second = dt.Second;
                _minute = dt.Minute;
                _hour = dt.Hour;

            }
        }
    }

}
