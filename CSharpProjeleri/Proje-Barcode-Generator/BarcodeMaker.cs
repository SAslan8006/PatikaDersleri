using BarcodeLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje_Barcode_Generator
{
    public class BarcodeGenerator
    {
        static TYPE type = TYPE.PHARMACODE;
       
        public static Barcode BarcodeMaker(string data)
        {
            Barcode barcode = new Barcode(data,type);
            barcode.Encode(type, data);

            barcode.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 
                + @"\Pratikler\MiniProjects\Proje-Barcode-Generator\barcode.png", BarcodeLib.SaveTypes.PNG);
            Console.WriteLine("Barkod Oluşturuldu ve kaydedildi,saklanan data => {0}",data);
            return barcode;
        }
        public static string BarcodeReader(Barcode barcode) 
        {
            return "Barkod değeri = " + barcode.RawData + "\n";
        }
    }
}
