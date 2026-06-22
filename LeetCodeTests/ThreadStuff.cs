using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    public static class ThreadStuff
    {
        public static void TestTask()
        {
            string myMessage = "This is a test";
            Task<string> t = Task<string>.Factory.StartNew(() => { Thread.Sleep(2000);  return myMessage;  });
            Console.WriteLine(t.Result);
        }


    }
}
