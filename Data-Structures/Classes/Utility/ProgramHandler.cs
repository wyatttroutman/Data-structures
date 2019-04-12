using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Classes.Utility
{
    class ProgramHandler
    {
        private int structureType;

        public ProgramHandler(int structureType)
        {
            this.structureType = structureType;
        }

        internal object InitializeDataStructure()
        {
            DataStructureBuilder dataStructureBuilder = new DataStructureBuilder();
            object dataStructure;
            switch (structureType)
            {
                case 1:
                     dataStructure = dataStructureBuilder.GetLinkedListDataStructure();
                    break;
                default:
                    dataStructure = null;
                    break;
            }

            return dataStructure;
        }
    }
}
