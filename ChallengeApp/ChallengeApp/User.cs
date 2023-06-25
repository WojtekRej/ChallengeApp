namespace ChallengeApp;

// Tworzenie klasy, klasa i nazwa klasy
// modyfikator dostępu public lub private
public class User
{
    private List<int> score = new List<int>();

    public User(string login)
    {
        this.Login = login;
    }

    // konstruktor dodatkowa metoda uruchamiana kiedy tworzony jest nowy obiekt w klasie
    public User(string login, string password)
    {
        // parametry klasy 
        // cechy obiektu w klasie
        this.Login = login;
        this.Password = password;
    }
    // określamy modyfikator dostępu, określamy typ, nazwa, 
    // pola - parametry opisujące nasz obiekt
    public string Login { get; private set; }
    public string Password { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    // metoda
    // która nic nie zwróci a doda punkty naszemu użytkownikowi
    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}
