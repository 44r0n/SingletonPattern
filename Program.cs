using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton example1 = Singleton.GetInstance();
            Console.WriteLine(example1.Text);
            example1.ChangeData();
            Singleton example2 = Singleton.GetInstance();
            Console.WriteLine(example2.Text);
        }
    }
}
