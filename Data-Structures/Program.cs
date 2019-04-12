
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures.Classes.Utility;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramMenu programMenu = new ProgramMenu();
            programMenu.WriteIntroductionMenu();

            int structureType = programMenu.GetStructureType();

            ProgramHandler programHandler = new ProgramHandler(structureType);

            Object dataStructure = programHandler.InitializeDataStructure();
        }
    }
}
