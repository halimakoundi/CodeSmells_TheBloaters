using System;

namespace LongMethods
{
    public class Issue
    {
        public float EffortManHours { get; set; }

        public string Description { get; set; }

        public Priority Priority { get; set; }

        public Issue(float effortManHours, string description)
        {
            EffortManHours = effortManHours;
            Description = description;
            ValidateEffortManHours();
            Priority = GetPriority();
        }

        public void ValidateEffortManHours()
        {
            if (EffortManHours > 1000 || EffortManHours <= 0)
            {
                throw new ArgumentException("Cannot register tech debt where effort is bigger than 1000 man hours to fix");
            }
        }

        public Priority GetPriority()
        {
            var priority = Priority.Low;

            if (EffortManHours > 100)
            {
                priority = Priority.Medium;
            }

            if (EffortManHours > 250)
            {
                priority = Priority.High;
            }

            if (EffortManHours > 500)
            {
                priority = Priority.Critical;
            }

            return priority;
        }
    }
}