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
        static Dictionary<string, IComand> supportedComands = new Dictionary<string, IComand>();
        static  DataRerord dataRerord = new DataRerord();

        static void registr()
        {
            supportedComands.Add("search", new Search());
            supportedComands.Add("cs_search", new ParamSearch());
            supportedComands.Add("create_file", new CreateFile());
            supportedComands.Add("delete_file", new DeleteFile());

        }

        static Program()
        {
            registr();
        }

        static void Main(string[] args)
        { 
            dataRerord.WriteDataOfFile(args, supportedComands[args[0]].GetType().Name.ToString());
            try
            {
                supportedComands[args[0]].execute(args);
            }
            catch (IndexOutOfRangeException ex) //как насчет того чтоб вынести логирование и обработку исключений в некий базовый клас для команд?
            {
                Console.WriteLine("Incorrectly entered values ​​to create");
                Console.WriteLine("Enter new value");
                dataRerord.ErrorRecord(ex.Message);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Path is a zero-length string");
                Console.WriteLine("Enter new value");
                dataRerord.ErrorRecord(ex.Message);

            }
            catch (Exception ex)
            {
                dataRerord.ErrorRecord(ex.Message);
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
         
        }
    }
}
