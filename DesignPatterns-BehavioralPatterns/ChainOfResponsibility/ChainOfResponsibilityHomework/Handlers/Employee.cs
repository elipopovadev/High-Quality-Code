namespace ChainOfResponsibilityHomework.Handlers
{
   public abstract class Employee
    {
        // next element in the chain of responsibility
        protected Employee nextSupervisor;
        public void SetNextSupervisor(Employee nextSupervisor)
        {
            this.nextSupervisor = nextSupervisor;
        }

        public abstract void ApplyLeave(string employeeName, int numberofDaysLeave);
    }
}
