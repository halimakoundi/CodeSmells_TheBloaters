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
        }

        public Issue(float effortManHours, string description, Priority priority)
            : this(effortManHours, description)
        {

            ValidateEffortManHours();
            Priority = priority;
        }

        public void ValidateEffortManHours()
        {
            if (EffortManHours > 1000 || EffortManHours <= 0)
            {
                throw new ArgumentException("Cannot register tech debt where effort is bigger than 1000 man hours to fix");
            }
        }
    }
}