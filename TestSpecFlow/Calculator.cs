using System;

namespace TestSpecFlow
{
    public class Calculator
    {
        public int Input1 { get; set; }
        public int Input2 { get; set; }
        public int Result { get; set; }

        public void Sum()
        {
            Result = Input1 + Input2;
        }
    }
}
