using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber;
        
        public Queen(Worker[] workers,double weightMg)
            :base(weightMg)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobToBePerformed,int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(jobToBePerformed, numberOfShifts))
                    return true;
            return false;
        }
        public string WorkTheNextShift()
        {
            shiftNumber++;
            double unitsConsumed = this.HoneyConsumptionRate();
            string report = "Report fot shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Worker #" + (i + 1) + " finished the job \r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working \r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                        report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob + "' for " + workers[i].ShiftsLeft + " more shifts\r\n";
                    else
                        report += "Worker #" + (i + 1) + " will be done with '" + workers[i].CurrentJob + "' after this shift \r\n";
                unitsConsumed += workers[i].HoneyConsumptionRate();
            }
            report += "Total honey consumed for the shift: " + unitsConsumed + " units\r\n";
            return report;
        }
    }
}
