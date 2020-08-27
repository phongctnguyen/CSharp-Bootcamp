using System;

namespace Anonymous_Function
{
    class Program
    {
        public delegate string GetTextDelegate(string name);

        static void Main(string[] args)
        {
            GetTextDelegate getTextDelegate = delegate(string name)
            {
                return "Hello, " + name;
            };

            Console.WriteLine(getTextDelegate("Phong"));
            Display(getTextDelegate);
        }

        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("World"));
        }
    }
}
