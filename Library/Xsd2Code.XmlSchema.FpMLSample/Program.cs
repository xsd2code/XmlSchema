using System;

namespace Xsd2Code.XMLSchema.FpML
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fpml = requestAllocationHeader.LoadFromFile(@"\..\..\..\FpML_Example.xml");
            Fpml.SaveToFile(@"..\..\..\xml\FpML-Enveloped2.xml");

        }
    }
}
