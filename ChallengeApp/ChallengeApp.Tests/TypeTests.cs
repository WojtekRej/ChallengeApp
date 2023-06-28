namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareTwoTypeOfInt()
        {
            // arrange - przygotowujemy

            int age1 = 20;
            int age2 = 30;

            // act - uruchamiamy

            // assert - sprawdzamy czy zostały spełnione pewne warunki
           
            Assert.AreNotEqual(age1, age2);
        }

        [Test]
        public void CompareTwoTypeOfString()
        {
            // arrange - przygotowujemy

            string string1 = "kot1";
            string string2 = "kot2";

            // act - uruchamiamy

            // assert - sprawdzamy czy zostały spełnione pewne warunki

            Assert.AreNotEqual(string1, string2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arrange - przygotowujemy
            var user1 = GetUser("Wojtek", "Rej");
            var user2 = GetUser("Tadek", "Kot");

            // act - uruchamiamy

            // assert - sprawdzamy czy zostały spełnione pewne warunki
            Assert.AreNotEqual(user1, user2);
        }

        private Employee GetUser(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}