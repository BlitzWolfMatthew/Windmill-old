using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos_1.Windmill.Lib
{
    class RunnableFunctions
    {
        public static void FindFunction(Windmill super)
        {
            super.index++;
            switch (super.program[super.index - 1] % 16)
            {
                case 0x00:
                    Goto(super);
                    break;
            }
        }

        private static void Goto(Windmill super)
        {
            int gotoLocation = Memory.GetRamLoc(super);
            super.index = gotoLocation - 1;
        }
    }
}
