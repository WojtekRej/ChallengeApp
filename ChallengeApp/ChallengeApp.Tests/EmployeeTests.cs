namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsMax()
        {
            // arrange - przygotowujemy
            var employee = new Employee("Wojtek", "Rej");
            employee.AddGrade(3);
            employee.AddGrade(3);
            employee.AddGrade(4);

            // act - uruchamiamy
            var statistics = employee.GetStatistics();

            // assert - sprawdzamy czy zostały spełnione pewne warunki

            Assert.AreEqual(4, statistics.Max);
        }

        [Test]
        public void StatisticsMin()
        {
            var employee = new Employee("Wojtek", "Rej");
            employee.AddGrade(3);
            employee.AddGrade(3);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(3, statistics.Min);
        }

        [Test]
        public void StatisticsAverage()
        {
            var employee = new Employee("Wojtek", "Rej");
            employee.AddGrade(3);
            employee.AddGrade(3);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }
    }
}
