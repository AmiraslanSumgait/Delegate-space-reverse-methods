using System;

namespace Delegate_string_space_methods
{
    public delegate void Func(string str);
    class MyClass
    {
        public void Space(string str)
        {
            int len = str.Length;  

            for (int i = 1; i < 2*len; i++)
            {
                if (i == 2 * len - 1) break;
                str = str.Insert(i, "_");
                i += 1;
            }
            Console.WriteLine($"Space method:{str}");
        }
         public void Reverse(string str)
         {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.Write("Reverse Method:");
            Console.WriteLine(arr);
         }
        public MyClass(string str)
        {
           
        }
    }
     class Run{
       public void runFunc(Delegate @delegate,string str)
        {
            @delegate.DynamicInvoke(str);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            var str = Console.ReadLine();
            MyClass cls = new MyClass(str);
            Func funcDell = new Func(cls.Space);
            funcDell += cls.Reverse;
            Run run = new Run();
            run.runFunc(funcDell, str);           
        }
    }
}
