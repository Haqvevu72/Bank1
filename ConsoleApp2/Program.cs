using ConsoleApp2;
using System.Security.Cryptography;

internal class Program {
    static void Main(string[] args)
    {
        Random random = new Random();
        string cvc = "";
        for (int i = 0; i < 3; i++)
        {
            int digit = random.Next(10);
            cvc += digit.ToString();
        }

        Guid id1  = Guid.NewGuid();
        DateTime ed1 = new DateTime(2027, 6, 5);
        bankcard bc1 = new bankcard("Kapital Bank","Elgun Haqverdiyev ",ed1,"4169738800049656", "4656",cvc,0);
        client c1 = new client(id1, "Elgun", "Haqverdiyev", 18, 0, bc1);

        Console.WriteLine(c1);
    }
}
