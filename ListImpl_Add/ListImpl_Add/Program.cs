using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImpl_Add {
    class Program {
        static void Main(string[] args) {
            MyList list = new MyList();
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
        }
    }
}
