using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos_1.Windmill
{
    class Windmill
    {
        public byte[] program;

        public byte[] ram;
        public int index;

        public Windmill(uint mAlloc, byte[] program)
        {
            this.program = program;
            ram = new byte[mAlloc];
        }

        public void RunNext()
        {
            FindCommand();
            index++;
        }

        public void FindCommand()
        {
            switch (program[index] / 16)
            {
                case 0x01:
                    Lib.Memory.FindFunction(this);
                    break;
                case 0x02:
                    Lib.Output.FindFunction(this);
                    break;
                case 0x03:
                    Lib.Input.FindFunction(this);
                    break;
                case 0x04:
                    Lib.Math.FindFunction(this);
                    break;
                case 0x05:
                    Lib.Utilities.FindFunction(this);
                    break;
                case 0x06:
                    Lib.RunnableFunctions.FindFunction(this);
                    break;
            }
        }
    }
}

