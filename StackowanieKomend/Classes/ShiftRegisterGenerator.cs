using Interfaces;
using System;

namespace CommandStacking.Classes
{
    public class ShiftRegisterGenerator : ICalculateXor, ICleanUpArray, ICopyLastValues, IInitializeArray
    {
        public ShiftRegisterGenerator InitializeArray()
        {
            Console.WriteLine("Initialize first 7 values of test vector");
            return this;
        }

        public ShiftRegisterGenerator CalculateXor()
        {
            Console.WriteLine($"Calulate Xor value of :{Consts.firstXorValue } & {Consts.secondXorValue} is " +
                $"{ Consts.firstXorValue ^ Consts.secondXorValue}");
            return this;
        }

        public ShiftRegisterGenerator CopyLastValues()
        {
            Console.WriteLine("Copying last 7 values to start of the array");
            return this;
        }

        public ShiftRegisterGenerator CleanUpArray()
        {
            Console.WriteLine("Cleaning Up last 25 values in test vector");
            return this;
        }
    }
}
