using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_isd_1.Comands.FileOperation
{
    class Search : IComand
    {
        public virtual void execute(string []arg)
        {
            search_(arg[1]).ForEach(n => Console.WriteLine(n));

        }

      protected   List<string> search_(string path)
        {
            return Directory.GetFiles(path, "*", SearchOption.AllDirectories).ToList();
        }
    }
}
