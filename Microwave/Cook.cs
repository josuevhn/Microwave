using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Microwave
{

    delegate void TimeoutDelegate(object source, TimeoutEventArgs args);

    class Cook
    {

        public event TimeoutDelegate timeoutEvent;

        public int time { get; set; }

        public Cook() { } // Constructor

        public void defrost()
        {

            Console.WriteLine();

            Console.WriteLine("Defrosting...");

            Thread.Sleep(time);

            OnTimeout(packagingEventInformation("Defrost"));

        } // defrost

        public void keepWarm()
        {

            Console.WriteLine();

            Console.WriteLine("Keeping warm...");

            Thread.Sleep(time);

            OnTimeout(packagingEventInformation("Keep Warm"));

        } // keepWarm

        private TimeoutEventArgs packagingEventInformation(string timedfunction)
        {

            return new TimeoutEventArgs { function = timedfunction };

        } // packRelatedInformation

        public void askForTime()
        {

            Console.WriteLine();

            Console.Write("Tiempo (segundos): ");

            int time = int.Parse(Console.ReadLine().ToString());

            this.time = (time * 1000);


        } // askForTime

        protected virtual void OnTimeout(TimeoutEventArgs args)
        {

            if(timeoutEvent != null)
            {

                timeoutEvent(this, args);

            } // if 

        } // OnTimeout

    } // Cook

    class TimeoutEventArgs : EventArgs
    {

        public string function { get; set; }

        public TimeoutEventArgs() { } // TimeoutEventArgs

    } // TimeoutEventArgs

} // Microwave
