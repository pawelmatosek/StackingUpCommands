
using CommandStacking.Classes;

namespace Example
{
    class StackingUpCommands
    {
        static void Main()
        {
            ShiftRegisterGenerator algoritm = new ShiftRegisterGenerator();
            algoritm
                .InitializeArray()
                .CalculateXor()
                .CopyLastValues()
                .CleanUpArray();
        }
    }
}
