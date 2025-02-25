using System;

namespace ObjectStateTracker
{
    // Represents a state change event.
    public class StateChange
    {
        public string NewState { get; }
        public string Description { get; }
        public DateTime Timestamp { get; }

        public StateChange(string newState, string description, DateTime timestamp)
        {
            NewState = newState;
            Description = description;
            Timestamp = timestamp;
        }
    }
}