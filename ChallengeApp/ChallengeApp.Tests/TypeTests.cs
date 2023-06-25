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
            var user1 = GetUser("Tadek");
            var user2 = GetUser("Tadek");

            // act - uruchamiamy

            // assert - sprawdzamy czy zostały spełnione pewne warunki
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}