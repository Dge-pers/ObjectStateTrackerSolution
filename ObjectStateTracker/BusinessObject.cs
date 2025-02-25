using System;

namespace ObjectStateTracker
{
    // Represents a business object that can change state.
    public class BusinessObject
    {
        public string Name { get; }
        public string CurrentState { get; private set; }
        private StateHistory stateHistory;

        public BusinessObject(string name, string initialState)
        {
            Name = name;
            CurrentState = initialState;
            stateHistory = new StateHistory();
            // stateHistory.AddStateChange(initialState, "Object's creation", DateTime.Now);
            stateHistory.AddStateChange(initialState, Name + " creation", DateTime.Now);
        }

        public void ChangeState(string newState, string description)
        {
            CurrentState = newState;
            stateHistory.AddStateChange(newState, description, DateTime.Now);
        }

        public void DisplayStateHistory()
        {
            stateHistory.DisplayHistory(Name);
        }
    }
}