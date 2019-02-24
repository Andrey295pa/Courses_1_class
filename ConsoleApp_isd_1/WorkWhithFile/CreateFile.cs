using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_isd_1.WorkWhithFile
{
    class CreateFile : IWorkFile
    {
        public void WorkFile(string[] arg)
        {
            File.Create(arg[0] + "\\Mytest.txt");
        }
    }
}
