using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace firstos
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.WriteLine("Welcome TO My Own Operating System");
        }
        protected override void AfterRun()
        {
            
        }
    }
}
