using System;
using System.Threading;

namespace ObjectStateTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example#1 usage:
            BusinessObject myObject1 = new BusinessObject("Absence's request", "Created");

            myObject1.ChangeState("Pending approval", "Pending manager's approval");
            myObject1.ChangeState("Approved", "Request approved");
            myObject1.ChangeState("Archived", "Request archived");
           
            myObject1.DisplayStateHistory();

            // Example#2 usage with pause:
            Thread.Sleep(2000);
            BusinessObject myObject2 = new BusinessObject("Purchase order", "Created");
            myObject2.ChangeState("Pending approval", "Pending approval");
            myObject2.ChangeState("Rejected", "Request rejected");
            myObject2.ChangeState("Archived", "Request archived");
            myObject2.DisplayStateHistory();

        }
    }
}