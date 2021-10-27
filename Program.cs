using System.Diagnostics;
using System;

namespace Week2BlessingEtok
{
    class Program
    {
          
        static void Main(string[] args)
        {
            LinkedList<string> check = new LinkedList<string>();

            Equeue<string> ada = new Equeue<string>();


            check.AddItem("dead");
            check.AddItem("live");
            check.AddItem("life");
            check.AddItem("run");
            //Console.WriteLine(check.AddItem("hunt"));


            check.Delete("dead");
            //check.Display();

            ada.Enqueue("sd");
            ada.Enqueue("sdd");
            ada.Enqueue("sdfd");
            ada.Enqueue("sdghfd");
            ada.Enqueue("sdaswqww");

            Console.WriteLine(ada.IsEmpty());
            ada.Display();

        }
    }
}
