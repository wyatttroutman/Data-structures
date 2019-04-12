using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class ProgramMenu
    {
        internal void WriteIntroductionMenu()
        {
            Console.WriteLine("Please choose a Data Structure to test. Enter the number beside the chosen data structure:");
            Console.WriteLine("1. Linked List");
        }

        internal int GetStructureType()
        {
            int structureType;
            while (!int.TryParse(Console.ReadLine(), out structureType))
            {
                Console.WriteLine("Entry must be an integer. Please try again.");
            }

            return structureType;
        }
    }
}
