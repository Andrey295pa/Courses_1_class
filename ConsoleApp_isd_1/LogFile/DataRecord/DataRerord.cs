using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_isd_1.LogFile.DataRecord
{
    class DataRerord:IRecordFile
    {
       public void WriteDataOfFile(string []param)
        {
            string fileName = "Log_File.txt";
            FileStream aFile = new FileStream(fileName, FileMode.Append);
            StreamWriter sw = new StreamWriter(aFile);
            aFile.Seek(0, SeekOrigin.End);
            sw.WriteLine(DateTime.Now.ToString());
            sw.WriteLine("----------------------");
            for (int i = 0; i < param.Length; i++)
            {
                sw.WriteLine($"Param number {(i + 1).ToString()}={param[i]}");
            }
            sw.WriteLine("----------------------");
            sw.Close();
        }
    }
}
