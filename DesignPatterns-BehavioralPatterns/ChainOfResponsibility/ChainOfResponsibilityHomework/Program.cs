using ChainOfResponsibilityHomework.Handlers;
using System;

namespace ChainOfResponsibilityHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // example where only one receiver in the chain will handle the request
            // once the request is handled by any handler then it should not forward that request to the next handler

            TeamLeader teamLeader = new TeamLeader();
            ProjectLeader projectLeader = new ProjectLeader();
            HR hr = new HR();
            teamLeader.SetNextSupervisor(projectLeader);
            projectLeader.SetNextSupervisor(hr);

            teamLeader.ApplyLeave("George", 9);
            Console.WriteLine();
            teamLeader.ApplyLeave("Ivo", 18);
            Console.WriteLine();
            teamLeader.ApplyLeave("Pesho", 30);
            Console.WriteLine();
            teamLeader.ApplyLeave("Ani", 50);
        }
    }
}
