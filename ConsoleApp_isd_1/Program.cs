using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_isd_1.Comands;
using ConsoleApp_isd_1.Comands.FileOperation;
using ConsoleApp_isd_1.LogFile.DataRecord;

namespace ConsoleApp_isd_1
{
    class Program
    {
       // static Dictionary<string, IComand> supportedComands = new Dictionary<string, IComand>();
        static Dictionary<string, IComand> supportedComands = new Dictionary<string, IComand>();
        static  DataRerord dataRerord = new DataRerord();


        static void registr()
        {
            supportedComands.Add("search", new Search());
            supportedComands.Add("cs_search", new ParamSearch());
            //supportedComands.Add(1, new Search());
            //supportedComands.Add(2, new ParamSearch());

        }

        static Program()
        {
            registr();
        }

        static void Main(string[] args)
        {
           // File.Create("D:\\testIsd.txt");
           // File.Delete("D:\\test.txt");
            dataRerord.WriteDataOfFile(args);
            supportedComands[args[0]].execute(args);
            
            Console.ReadKey();

            //dataRerord.WriteDataOfFile("Andrey2", "1984_2");
            // Console.WriteLine(nameof(dataRerord.GetType));
            // Console.ReadKey();

            //string path = args[0];
            //string param = args[1];

            // supportedComands["search"].execute("D:", ".txt");


            //if (path == "search")
            //{
            //    IComand comand = new Search();
            //    comand.execute(path, string.Empty);
            //}

            //if (path == "cs_search")
            //{
            //IComand comand = new ParamSearch();
            //comand.execute(path,param);
            //}

            
        }
    }
}
