using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM91U5.Load_File
{
    public class Work
    {
        // private data members
        private readonly string nameOfWork;
        private readonly int requiredTimeInMinutes;
        private readonly int materialCosts;

        public Work(string nameOfWork, int requiredTimeInMinutes, int materialCosts)
        {
            this.nameOfWork = nameOfWork;
            this.requiredTimeInMinutes = requiredTimeInMinutes;
            this.materialCosts = materialCosts;
        }

        //read only fields
        public string NameOfWork => nameOfWork;
        public int RequiredTimeInMinutes => requiredTimeInMinutes;
        public int MaterialCosts => materialCosts;
        public int ServiceHour => RequiredTimeInMinutes / 60;
        public int ServiceMinute => RequiredTimeInMinutes % 60;
    }
}
