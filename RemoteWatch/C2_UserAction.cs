using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteWatch
{
    internal class C2_UserAction
    {
        public string applicationName { get; set; }
        public string applicationTitle { get; set; }
        public DateTime workStartTime { get; set; }
        public DateTime workEndTime { get; set; }
        public TimeSpan idleTime { get; set; }
        public TimeSpan workDuration { get; set; }



        //Work duration calculate by subtracting workStartTime-workEndTime
        public void CalculatingWorkDuration()
        {
            this.workDuration = workEndTime.Subtract(workStartTime);
        }

        //Worker idle time calculate 
        public void CalculatingWorkerRestTime()
        {
            //Is workduration greater than five minutes
            if (workEndTime.Subtract(workStartTime).TotalSeconds > 300)
            {
                //Substract five minutes from workduration and calculate the idle time, since no active work from five minutes
                TimeSpan redusingTime = TimeSpan.FromMinutes(5);
                this.idleTime += (workEndTime.Subtract(workStartTime)).Subtract(redusingTime);
            }
        }
    }
}
