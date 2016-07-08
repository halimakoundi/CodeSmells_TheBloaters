using System;

namespace LongMethods
{
    public class Issue
    {
        public float EffortManHours { get; set; }

        public string Description { get; set; }

        public Priority Priority { get; set; }

        private Issue(float effortManHours, string description)
        {
            EffortManHours = effortManHours;
            Description = description;
        }

        private Issue(float effortManHours, string description, Priority priority)
            : this(effortManHours, description)
        {
            this.Priority = priority;
        }

        public static Issue WithEffortAndDescription(float effortManHours, string description)
        {
            if (effortManHours > 1000 || effortManHours <= 0)
            {
                throw new ArgumentException("Cannot register tech debt where effort is bigger than 1000 man hours to fix");
            }

            var issue = new Issue(effortManHours, description, GetPriority(effortManHours));
            return issue;
        }

        private static Priority GetPriority(float effortManHours)
        {
            var priority = Priority.Low;

            if (effortManHours > 100)
            {
                priority = Priority.Medium;
            }

            if (effortManHours > 250)
            {
                priority = Priority.High;
            }

            if (effortManHours > 500)
            {
                priority = Priority.Critical;
            }
            return priority;
        }
    }
}