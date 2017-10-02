using Presentation.DialogBox.ExistingEmployeeRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlEmployeeInfo info = new ControlEmployeeInfo();
            foreach(var controls in info.Controls)
            {
                Console.WriteLine((controls as Control).Name);
            }

            Console.ReadLine();
        }
    }
}
