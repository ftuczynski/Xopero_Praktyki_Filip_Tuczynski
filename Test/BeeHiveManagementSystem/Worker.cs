﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class Worker : Bee
    {
        private string currentJob;
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        const double honeyUnitsPerShiftWorked = .65;

        public Worker(string[] jobsICanDo,double weightMg)
            :base(weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for(int i=0;i<jobsICanDo.Length;i++)
                if(jobsICanDo[i]==job)
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            return false;
        }
        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }
        public override double HoneyConsumptionRate() 
        {
            return base.HoneyConsumptionRate() + (shiftsWorked * honeyUnitsPerShiftWorked);
        }
    }
}
