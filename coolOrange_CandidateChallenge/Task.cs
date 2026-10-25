using System;


namespace coolOrange_CandidateChallenge
{

    public enum Priority
    {
        MIN_PRIORITY = 1,
        MED_PRIORITY = 5,
        MAX_PRIORITY = 10,
    }

    public interface IPriority
    {
        void SetPriority(int priority);
        int GetPriority();
    }

    public interface IComplexity
    {
        void SetComplexity(int complexity);
        int GetComplexity();
    }

    public class Task : IPriority, IComplexity, IComparable
    {
        private string name;
        private int priority;
        private int complexity;

        public Task(string name)
        {
            this.name = name;
            this.priority = (int)Priority.MED_PRIORITY;
            this.complexity = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPriority(int priority)
        {
            this.priority = priority;
        }

        public int GetPriority()
        {
            return priority;
        }

        public void SetComplexity(int complexity)
        {
            this.complexity = complexity;
        }

        public int GetComplexity()
        {
            return complexity;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is Task otherTask)
            {
                return this.priority.CompareTo(otherTask.priority);
            }

            throw new ArgumentException("Objekt ist kein Task");
        }
    }
}
