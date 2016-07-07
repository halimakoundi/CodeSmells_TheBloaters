using System;
using System.Collections.Generic;

namespace LongMethods
{
    public class TechnicalDebt
    {
        private readonly IList<Issue> _issues = new List<Issue>();

        public float Total { get; private set; }

        public Issue LastIssue => _issues[(_issues.Count - 1)];

        public string LastIssueDate { get; private set; }

        public void Fixed(float amount)
        {
            Total -= amount;
        }

        public void Register(float effortManHours, string description)
        {
            var priority = GetPriorityFor(effortManHours);
            var issue = new Issue(effortManHours, description, priority);

            AddToTotal(effortManHours);

            AddToIssues(issue);

            UpdateLastIssueDate();
        }

        private static Priority GetPriorityFor(float effortManHours)
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

        private void AddToTotal(float effortManHours)
        {
            Total += effortManHours;
        }

        private void AddToIssues(Issue issue)
        {
            _issues.Add(issue);
        }

        private void UpdateLastIssueDate()
        {
            var now = DateTime.Now;
            LastIssueDate = now.Date + "/" + now.Month + "/" + now.Year;
        }
    }
}