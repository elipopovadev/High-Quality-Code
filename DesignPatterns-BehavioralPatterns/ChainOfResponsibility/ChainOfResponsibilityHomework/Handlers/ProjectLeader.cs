using System;

namespace ChainOfResponsibilityHomework.Handlers
{
    public class ProjectLeader : Employee
    {
        private const int MAX_LEAVES_CAN_APPROVE = 20;
        public override void ApplyLeave(string employeeName, int numberofDaysLeave)
        {
            if (numberofDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                Console.WriteLine("ProjectLeader approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                + employeeName); // approve Leave
            }

            else
            {
                this.nextSupervisor.ApplyLeave(employeeName, numberofDaysLeave);
            }
        }
    }
}
