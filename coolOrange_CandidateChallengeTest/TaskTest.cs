using NUnit.Framework;
using coolOrange_CandidateChallenge;

namespace coolOrange_CandidateChallengeTest
{
    [TestFixture]
    public class TaskTest
    {
        [Test]
        public void Constructor_sets_default_values_correctly()
        {
            Task task = new Task("Test Task");
            Assert.AreEqual("Test Task", task.GetName());
            Assert.AreEqual((int)Priority.MED_PRIORITY, task.GetPriority());
            Assert.AreEqual(0, task.GetComplexity());
        }

        [Test]
        public void SetPriority_and_GetPriority_work_correctly()
        {
            Task task = new Task("Test Task");
            task.SetPriority((int)Priority.MAX_PRIORITY);
            Assert.AreEqual(10, task.GetPriority());
        }

        [Test]
        public void SetComplexity_and_GetComplexity_work_correctly()
        {
            Task task = new Task("Test Task");
            task.SetComplexity(7);
            Assert.AreEqual(7, task.GetComplexity());
        }

        [Test]
        public void CompareTo_correctly_identifies_higher_priority()
        {
            Task lowTask = new Task("Low");
            lowTask.SetPriority(1);

            Task highTask = new Task("High");
            highTask.SetPriority(10);

            Assert.IsTrue(highTask.CompareTo(lowTask) > 0);
            Assert.IsTrue(lowTask.CompareTo(highTask) < 0);
        }
    }
}
