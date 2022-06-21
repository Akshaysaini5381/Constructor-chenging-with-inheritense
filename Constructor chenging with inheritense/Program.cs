using System;

namespace Constructor_chenging_with_inheritense
{
    class test
    {
        public test()
        {
            Console.WriteLine("I am perant : ");
        }
      public void mms()
        {
            Console.WriteLine("Hello saini :");
        }
    }
    class mix:test
    {
        public mix()
        {
            Console.WriteLine("I am  also child : ");
        }
    }
    class Program:mix
    {
    public Program()
        {
            Console.WriteLine("I am child: ");
        }

        void msg()
        {
            Console.WriteLine("Hello Akshay :");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.msg();
            obj.mms();

/*
 *              OutPut:-
 *              
            I am perant:
            I am  also child :
            I am child:
            Hello Akshay :
            Hello saini :*/
        }
    }
}
