using System;
using System.Collections.Generic;

namespace coolOrange_CandidateChallenge
{
    public class TaskDriver
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            Task task1 = new Task("Doing Homework");
            task1.SetPriority((int)Priority.MAX_PRIORITY);
            task1.SetComplexity(8);
            tasks.Add(task1);

            Task task2 = new Task("Eating Lunch");
            task2.SetPriority((int)Priority.MIN_PRIORITY);
            task2.SetComplexity(2);
            tasks.Add(task2);

            Task task3 = new Task("Programming");
            task3.SetPriority((int)Priority.MED_PRIORITY);
            task3.SetComplexity(5);
            tasks.Add(task3);

            Console.WriteLine("TO-DO");
            Console.WriteLine("---------");

            tasks.Sort();
            tasks.Reverse();

            for (int i = 0; i < tasks.Count; i++)
            {
                Task task = tasks[i];
                Console.WriteLine($"{task.GetName()} priority: {task.GetPriority()} complexity: {task.GetComplexity()}");
            }

            Task mostImportant = tasks[0];
            Console.WriteLine($"{mostImportant.GetName()} is one of the most important tasks");
        }
    }
}
