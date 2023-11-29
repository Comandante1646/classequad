using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classequad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato quadrato1 = new Quadrato();
            Console.WriteLine("lato del quadrato?");
            
            quadrato1.lato = float.Parse(Console.ReadLine());

            quadrato1.AreaQuadrato();
            Console.ReadLine();
            
        }
    }
}
