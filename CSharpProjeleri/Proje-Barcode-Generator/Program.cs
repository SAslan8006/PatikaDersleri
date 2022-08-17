using BarcodeLib;
using System;

namespace Proje_Barcode_Generator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Barcode barcode = BarcodeGenerator.BarcodeMaker("777");
            Console.WriteLine(BarcodeGenerator.BarcodeReader(barcode));

            barcode = BarcodeGenerator.BarcodeMaker("11");
            Console.WriteLine(BarcodeGenerator.BarcodeReader(barcode));

            barcode = BarcodeGenerator.BarcodeMaker("11");
            Console.WriteLine(BarcodeGenerator.BarcodeReader(barcode));

            barcode = BarcodeGenerator.BarcodeMaker("777");
            Console.WriteLine(BarcodeGenerator.BarcodeReader(barcode));
        }
    }
}
