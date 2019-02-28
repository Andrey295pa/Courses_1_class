using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_isd_1.Comands.FileOperation
{
    class CreateFile : IComand
    {
        public void execute(string[] arg)
        {
            File.Create(arg[1] + "\\Mytest.txt");
        }
    }
}
