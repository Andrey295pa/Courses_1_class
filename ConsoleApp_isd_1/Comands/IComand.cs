using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_isd_1.Comands
{
    interface IComand
    {

        //void execute(string path,string param);
        void execute(string []arg);

    }
}
