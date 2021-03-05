using System;

namespace Adaptör
{
    class Program
    {
        interface IHedef
        {
            string İstek(int i);
        }
        class Adapte
        {
            public double Özelİstek(double a, double b)
            {
                return a / b;
            }
        }
            class Adaptör: Adapte, IHedef
            {
                public string İstek(int i)
                {
                 return "Sayının yuvarlanmış hali:" + (int)Math.Round(Özelİstek(i, 3));
                }
            }
        static void Main(string[] args)
        {
            Adapte _adapte = new Adapte();
            Console.WriteLine("Yeni arayüzden önce");
            Console.WriteLine(_adapte.Özelİstek(7, 3));
            IHedef _hedef= new Adaptör();
            Console.WriteLine("Yeni arayüzden sonra");
            Console.WriteLine(_hedef.İstek(5));
            Console.ReadKey();

        }
    }
}
