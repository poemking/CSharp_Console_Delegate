using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_Delegate
{
    delegate int NumberChanger(int n);
    class Program
    {
        static int num=10;
        /// <summary>
        /// ref below http
        /// https://www.youtube.com/watch?v=_qrte1XilG8&list=PLTstZD3AK3S_Xk5Q7oSjrEPkzUkH8mzvm&index=1#t=244.259976
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            nc1(25);

            Console.WriteLine("Value of Num :{0}", num);

            //實例化非靜態非法的委託,MyClass
            MyClass mc = new MyClass();
            NumberChanger nc2 = new NumberChanger(mc.AddNum);
            nc2(35);
            Console.WriteLine("Value of instance Num :{0}", mc.num);

            NumberChanger nc3 = new NumberChanger(mc.MutliNum);
            nc3(2);
            Console.WriteLine("Value of mutil instance Num: {0}", mc.num);

            Console.ReadLine();
        }

        public static int AddNum(int p) 
        {
            num += p;
            return num;
        }      
    }

    //非靜態調用方法執行委託
    class MyClass 
    {
        public int num = 10;

        public  int AddNum(int p)
        {
            num += p;
            return num;
        }

        public int MutliNum(int p) 
        {
            num *= p;
            return num;
        }
    }
}
