namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectSumResult()
        {
            // arrange - przygotowujemy

            var user = new User("Mietek", "1234567890");

            user.AddScore(5);
            user.AddScore(6);

            // act - uruchamiamy

            var result = user.Result;

            // assert - sprawdzamy czy zosta³y spe³nione pewne warunki

            Assert.AreEqual(11, result);
        }
    }
}