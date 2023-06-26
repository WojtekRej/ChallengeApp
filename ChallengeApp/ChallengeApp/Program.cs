using ChallengeApp;

User user1 = new User("Mietek", "1234567890");
User user2 = new User("Zygmunt", "1234567890");
User user3 = new User("Tadek", "1234567890");
User user4 = new User("Grażyna", "1234567890");
User user5 = new User("Wiesiek", "1234567890");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;

Console.WriteLine(result);