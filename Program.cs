using System.Security.Cryptography.X509Certificates;

namespace Boksystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Bok> books = new List<Bok>();

            books.Add(new Bok("Iron flame", "Rebecca Yarros", 12345678));
            books.Add(new Bok("Egendom", "Hernan Diaz", 12345678));
            books.Add(new Bok("Norrsken ", "Carl Bergstrand", 12345678));
            books.Add(new Bok("Dune", "Alf", 12345678));
            books.Add(new Bok("Dune", "Alf", 12345678));
            books.Add(new EBok("Dune", "Alf", 12345678, 650, "test.com"));

            foreach(Bok bok in books)
            {
                bok.SkrivUtInfo();
            }
        }
    }
}