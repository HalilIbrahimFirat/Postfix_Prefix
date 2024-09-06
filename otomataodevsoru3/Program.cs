using System;

class Program
{
    static void Main(string[] args)
    {
        int fix;
        
        Console.WriteLine("String giriniz");
        string str = Console.ReadLine();
        Console.WriteLine("Hedef stringi giriniz");
        string hedef = Console.ReadLine();

        if (hedef.Length > 6)
        {
            Console.WriteLine("5'ten küçük hedef giriniz ve tekrar deneyiniz...");
        }
        else if (str.Contains(hedef))// ana stringin içinde bulunuyor mu komutu
        {
            Console.WriteLine("Hedef string, ana stringin içinde bulunuyor.");

            Console.WriteLine("Prefix için 1, Postfix için 2 tuşuna basınız");
            fix = Convert.ToInt32(Console.ReadLine());

            if (fix == 1)
            {
                Console.WriteLine("Prefix'ler:");

                for (int i = 1; i <= hedef.Length; i++)
                {
                    string prefix = hedef.Substring(0, i);
                    Console.WriteLine(prefix);
                }
            }
            else if (fix == 2)
            {
                Console.WriteLine("Postfix'ler:");

                for (int i = 1; i <= hedef.Length; i++)
                {
                    string postfix = hedef.Substring(hedef.Length - i, i);
                    Console.WriteLine(postfix);
                }
            }

        }
        else
        {
            Console.WriteLine("Hedef string, ana stringin içinde bulunmuyor.");
        }

        Console.ReadKey();
    }
}
