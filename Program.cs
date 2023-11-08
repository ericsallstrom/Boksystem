using System.Security.Cryptography.X509Certificates;

namespace Boksystem
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Bok> books = new List<Bok>();

            books.Add(new Bok("Dune", "Alf", 12345678));
            books.Add(new EBok("Dune", "Alf", 12345678, 650, "test.com"));



        }
    }
}