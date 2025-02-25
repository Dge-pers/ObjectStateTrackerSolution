using System;
using System.Collections.Generic;

namespace ObjectStateTracker
{
    // Manages the state history of a business object.
    public class StateHistory
    {
        private List<StateChange> stateChanges = new List<StateChange>();

        public void AddStateChange(string newState, string description, DateTime timestamp)
        {
            stateChanges.Add(new StateChange(newState, description, timestamp));
        }

        public void DisplayHistory(string objectName)
        {
            Console.WriteLine($"State history for {objectName}:");
            foreach (var change in stateChanges)
            {
                // String Reformat (FR date format)
                string dateFormatted = change.Timestamp.ToString("dd/MM/yyyy HH:mm:ss");

                Console.WriteLine($"- {dateFormatted}: {change.Description} (New State: {change.NewState})");
            }
        }
    }
}