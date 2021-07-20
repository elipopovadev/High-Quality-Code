using System;

namespace ChainOfResponsibilityHomework.Handlers
{
    public class HR : Employee
    {
        private const int MAX_LEAVES_CAN_APPROVE = 30;
        public override void ApplyLeave(string employeeName, int numberofDaysLeave)
        {
            if (numberofDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                Console.WriteLine("HR approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                + employeeName); // approve Leave
            }

            else
            {
                Console.WriteLine("Leave application suspended, Please contact HR");
            }
        }
    }
}
