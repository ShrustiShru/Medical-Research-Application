using System;
using System.IO;
using MyHelperClassRepo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    class UI
    {
        public static void Run(string menu)
        {
            bool Repeat = true;
            string Menu = File.ReadAllText(menu);

            while (Repeat)
            {
                Console.WriteLine(menu);
                int choice = Convert.ToInt32(Console.ReadLine());
                Repeat = Loop(choice);
            }
        }
        public static void Loop(int choice)
        {
            switch(choice)
            {
                case 1: DiseaseManager disease=ResearchFactory
            }
        }

            public static Disease getDisease()
            {
            string DiseaseName= MyHelper.GetValue("Enter the Disease Name");
            DisplaySeverity();
            int Severity = MyHelper.GetNumber("Enter the Severity from the above options");
            DisplayCause();
            int Cause = MyHelper.GetNumber("Enter the Cause from the above options");
            string Description = MyHelper.GetValue("Enter the description");
            }

        public static void DisplayCause()
        {
            Console.WriteLine();
            foreach (var item in Enum.GetValue()
            {

            }
        }
    }
}
