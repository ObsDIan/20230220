using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeAction action1 = new SomeAction(ShowText);
            action1 += ShowMessage;

            SomeAction action2 = ShowText;

            action1.Invoke("第一個");

            action2("第二個");

            Console.ReadLine();
        }

        static void ShowText(string msg)
        {
            Console.WriteLine($"showText {msg}");
        }

        static void ShowMessage(string str)
        {
            Console.WriteLine($"showMessage {str}");
        }
    }
}
