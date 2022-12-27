using System.Xml.Linq;
sing System.Diagnostics;

namespace pechat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name();
            name.name = Console.ReadLine();
            Console.WriteLine(name.name);
            Console.Clear();

            List<string> text = new List<string>() { "Она хочет на трэп дом придти, давно её не видел и забыл, но кто нибудь скажите, что она забыла в моей комнате. Шёпотом поёт мои припевы, но я имени не помню, я сказал ей выйди ты из комнаты.Снова в этой комнате у брудды вместо балаклавы на глаза есть эти линзы сипи компани " };
            var rand = new Random();
            int tex = rand.Next(0, 2);
            string textvv = text[tex];
            Console.WriteLine(textvv);

            int i = 0;
            Console.SetCursorPosition(0, 0);
            while (i < textvv.Length)
            {
                char c = Console.ReadKey(true).KeyChar;
                if (c == textvv[i])
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(c);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}