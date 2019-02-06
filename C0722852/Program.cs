using System;

namespace C0722852
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            MethodA();
        }
        
            public static void MethodA()
        {
            while (Peanut())
            {
                Console.WriteLine(" i is {0} ", i);
                if (i> 10)
                    {
                        return;
                    }
            }
 
        }
        public static bool Peanut()
        {
            return true;
        }
    }
}
