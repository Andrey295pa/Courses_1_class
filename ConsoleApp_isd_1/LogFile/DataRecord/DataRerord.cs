using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_isd_1.LogFile.DataRecord //может имеет смысл использовать какуюто стороннюю либу для логирования? чтоб не писать свой класс
{
    class DataRerord:IRecordFile
    {
       public void WriteDataOfFile(string []param,string nameOparation)
        {
            string fileName = "Log_File.txt";
            FileStream aFile = new FileStream(fileName, FileMode.Append);
            StreamWriter sw = new StreamWriter(aFile);
            aFile.Seek(0, SeekOrigin.End);
            sw.WriteLine(DateTime.Now.ToString());
            sw.WriteLine("----------------------");
            sw.WriteLine("Name method");
            sw.WriteLine(nameOparation);
            for (int i = 0; i < param.Length; i++)
            {
                sw.WriteLine($"Param number {(i + 1).ToString()}={param[i]}");
            }
            sw.WriteLine("----------------------");
            sw.Close();
        }
        public void ErrorRecord( string error)
        {
            string fileName = "Log_File.txt";
            FileStream aFile = new FileStream(fileName, FileMode.Append);
            StreamWriter sw = new StreamWriter(aFile);
            aFile.Seek(0, SeekOrigin.End);
            sw.WriteLine(DateTime.Now.ToString());
            sw.WriteLine("----------------------");
            sw.WriteLine("Name error");
            sw.WriteLine(error);
            sw.WriteLine("----------------------");
            sw.Close();
        }
    }
}
