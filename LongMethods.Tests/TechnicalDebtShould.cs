using System;
using NUnit.Framework;

namespace LongMethods.Tests
{

    [TestFixture]
    public class TechnicalDebtShould
    {
        private TechnicalDebt _technicalDebt;

        [SetUp]
        public void BeforeEach()
        {
            _technicalDebt = new TechnicalDebt();
        }

        [Test]
        public void FixingIssueIssueDeductsEffortFromTotal()
        {
            _technicalDebt.Register(50, "Declared Issue class in same file as TechnicalDebt class");

            _technicalDebt.Fixed(50);

            Assert.AreEqual(0, _technicalDebt.Total);
        }

        [Test]
        public void RegisteringIssueIncreasesTotal()
        {
            _technicalDebt.Register(50, "Declared Issue class in same file as TechnicalDebt class");

            Assert.AreEqual(50, _technicalDebt.Total);
        }

        [Test]
        public void RegisteringIssueWithEffortBiggerThanFiveHundredMarksItAsCriticalPriority()
        {
            _technicalDebt.Register(501, "Declared Issue class in same file as TechnicalDebt class");

            Assert.AreEqual(Priority.Critical, _technicalDebt.LastIssue.Priority);
        }

        [Test]
        public void RegisteringIssueWithEffortBiggerThanTwoHundredAndFiftyMarksItAsHighPriority()
        {
            _technicalDebt.Register(251, "Declared Issue class in same file as TechnicalDebt class");

            Assert.AreEqual(Priority.High, _technicalDebt.LastIssue.Priority);
        }

        [Test]
        public void RegisteringIssueWithEffortBiggerThanOneHundredMarksItAsHighPriority()
        {
            _technicalDebt.Register(101, "Declared Issue class in same file as TechnicalDebt class");

            Assert.AreEqual(Priority.Medium, _technicalDebt.LastIssue.Priority);
        }

        [Test]
        public void RegisteringIssueWithEffortEqualOrLowerThanOneHundredMarksItAsLowPriority()
        {
            _technicalDebt.Register(100, "Declared Issue class in same file as TechnicalDebt class");

            Assert.AreEqual(Priority.Low, _technicalDebt.LastIssue.Priority);
        }

        [Test]
        public void RegisteringIssueUpdatesLastIssueDate()
        {
            _technicalDebt.Register(50, "Declared Issue class in same file as TechnicalDebt class");

            var now = DateTime.Now;
            Assert.AreEqual(now.Date + "/" + now.Month + "/" + now.Year, _technicalDebt.LastIssueDate);
        }

        [Test]
        public void RegisteringMoreThanMaxAllowedEffortThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _technicalDebt.Register(1001, "The PM forced me to register this"));
        }

        [Test]
        public void RegisteringLessThanMinAllowedEffortThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _technicalDebt.Register(0, "The PM forced me to register this"));
        }
    }
}