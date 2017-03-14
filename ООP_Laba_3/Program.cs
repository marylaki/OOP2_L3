using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООP_Laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle P1=new Rectangle(8,9);
            P1.PrintInfo();
            P1.WriteToFile("E:\\OOP_3.txt");
            Button B1=new Button("Press Me!");
            B1.PrintInfo();
            B1.WriteToFile("E:\\OOP_3.txt");
            Tuple<string, string, int, int> bt=B1.Get();
            Console.WriteLine("Вывод кортежа:{0} {1} {2}x{3}", bt.Item1, bt.Item2, bt.Item3, bt.Item4);
            Rectangle P2 = new Rectangle(2, 4);
            P2.WriteToFile("T:\\");
            Console.WriteLine("P1 {0}", P1.ToString());
            Console.WriteLine("P2 {0}", P2.ToString());
            Console.WriteLine("P1 + P2 = {0}", (P1 + P2).ToString());
            Console.WriteLine("P1 - P2 = {0}", (P1 - P2).ToString());
            Console.WriteLine("P1 * P2 = {0}", (P1 * P2).ToString());
            Console.WriteLine("P1 / P2 = {0}", (P1 / P2).ToString());
            Console.WriteLine("P1 > P2  {0}", P1 > P2);
            Console.WriteLine("P1 < P2  {0}", P1 < P2);
            Console.WriteLine("P1 == P2  {0}", P1 == P2);
            Console.WriteLine("P1 != P2  {0}", P1 != P2);
            Rectangle Pmax = new Rectangle(2147483647, 2147483647);
            Console.WriteLine("P2 {0}", P2.ToString());
            Console.WriteLine("Pmax {0}", Pmax.ToString());
            Console.WriteLine("Pmax + P2 = {0}", (Pmax + P2).ToString());
            Console.WriteLine("Singelton:");
            BeginCoord b1 = BeginCoord.Get();
            BeginCoord b2= BeginCoord.Get();
            Console.WriteLine("Object.ReferenceEquals(b1,b2) {0}", Object.ReferenceEquals(b1, b2));
            Console.WriteLine("MEMENTO");
            Button B2 = new Button("moment");
            B2.PrintInfo();
            B2.CreateMemento();
            B2.click();
            B2.PrintInfo();
            B2.CreateMemento();
            B2.move();
            B2.PrintInfo();
            B2.CreateMemento();
            B2.click();
            B2.PrintInfo();
            B2.CreateMemento();
            Restover.rest(ref B2, 1);
            B2.PrintInfo();
            Restover.rest(ref B2, 3);
            B2.PrintInfo();
            Restover.rest(ref B2, 0);
            B2.PrintInfo();
            figura f1 = new Rectangle(10, 10);
            Console.WriteLine("f1 is Rectangle {0}", f1 is Rectangle);
                ((Rectangle)f1).PrintInfo();
            if (f1 is Button)
                f1.PrintInfo();
            else Console.WriteLine("f1 as Button = null\nf1 is Button {0}", f1 is Button);
            Actions a = B1 as Actions;
            B1.PrintInfo();
            Console.WriteLine(" as Actions \n click");
            a.click();
            B1.PrintInfo();


        }
    }
}
