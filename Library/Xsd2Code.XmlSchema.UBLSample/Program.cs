using System;
using Xsd2Code.XmlSchema.UBL;

namespace ConsoleAppUBL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello UBL World!");

            Console.WriteLine("Load XML UBL file");
            var invoice = InvoiceType.LoadFromFile(@"..\..\..\xml\UBL-Invoice-2.0-Enveloped.xml");
            invoice.SaveToFile(@"..\..\..\xml\UBL-Invoice-2.0-Enveloped2.xml");
        }
    }
}
