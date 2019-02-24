using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_isd_1.Comands.FileOperation
{
    class ParamSearch : Search
    {
       // public override void execute(string path,string param)
        public override void execute(string []arg)
        {
            search(arg[1]).ToList<string>().ForEach(n => Console.WriteLine(n));

        }

       IEnumerable<string> search(string path)
        {
            // return  Directory.GetFiles(path, ("*" + ext)).ToList();
            //  return  Directory.GetFiles(path, "*.exe").ToList();

            List<string> rez = search_(path);
            foreach (string n in rez)
            {
                if(Path.GetExtension(n)==".txt")
                    {
                     yield return n;
                    }
            }
        }

    }
}
