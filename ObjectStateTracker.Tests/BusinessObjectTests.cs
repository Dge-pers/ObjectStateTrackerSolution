using NUnit.Framework;
using ObjectStateTracker;
using System;

namespace ObjectStateTracker.Tests
{
    [TestFixture]
    public class BusinessObjectTests
    {
        [Test]
        public void BusinessObject_Creation_InitialStateSet()
        {
            // Arrange
            string expectedState = "Draft";
            BusinessObject myObject = new BusinessObject("Document", expectedState);

            // Act
            string actualState = myObject.CurrentState;

            // Assert
            Assert.AreEqual(expectedState, actualState);
        }

        [Test]
        public void BusinessObject_ChangeState_StateUpdated()
        {
            // Arrange
            BusinessObject myObject = new BusinessObject("Document", "Draft");
            string newState = "Under Review";
            string description = "Submitted for review";

            // Act
            myObject.ChangeState(newState, description);

            // Assert
            Assert.AreEqual(newState, myObject.CurrentState);
        }

        [Test]
        public void BusinessObject_DisplayStateHistory_NoExceptions()
        {
            // Arrange
            BusinessObject myObject = new BusinessObject("Document", "Draft");
            myObject.ChangeState("Under Review", "Submitted for review");

            // Act & Assert
            Assert.DoesNotThrow(() => myObject.DisplayStateHistory());
        }
    }
}