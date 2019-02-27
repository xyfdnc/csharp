using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Demo
    {
        private string _UserName;
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        public Demo(string userName)
        {
            _UserName = userName;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y = 3;
            x = 10;
            int z = x + y;
            char ch = 'A';
            double db = 67.45;
            float ky = 56.8f;
            long ll = 100;
            z = (int)ll;
            z = Convert.ToInt32(ll);
            int m = ch + 1;
            //System.Console.WriteLine("Hello,world!");
            System.Console.WriteLine("x={0},y={1}",x,y);
            System.Console.WriteLine("x+y={0}", x + y);
            System.Console.WriteLine("x-y={0}", x - y);
            System.Console.WriteLine("x*y={0}", x * y);
            System.Console.WriteLine("x/y={0}", x / y);
            System.Console.WriteLine("x%y={0}", x % y);
            System.Console.WriteLine("++x :{0}",++x);
            System.Console.WriteLine("m={0}",ch);
            System.Console.ReadKey();
        }
    }
}
