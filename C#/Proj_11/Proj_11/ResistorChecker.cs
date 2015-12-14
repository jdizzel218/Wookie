
/*
Pseudo-Code:

P = v^2/r
#1. 

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Proj_11
{
    class ResistorChecker
    {
        const int ARRAY_SIZE = 50;
        double[] voltages = new double[ARRAY_SIZE];

        int restitorNum = 0;
        double dissipation;
        string passed;

        int count;



        public void GetData()
        {
            Console.WriteLine("Name of file: ");
            string usrInput = Console.ReadLine();

            string fileLocation = System.Environment.SpecialFolder.Personal + "\\" + usrInput;

            StreamReader reader = new StreamReader(fileLocation);

            for (int i = 0; i <= count; i++)
            {
                if(double.TryParse(reader.ReadLine(), out voltages[i]))
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("There is an error in the file");
                }
                
            }
            
        }

        public void CalcDisipation()
        {

        }


    }
}
