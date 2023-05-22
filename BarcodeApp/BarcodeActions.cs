using BarcodeLib;
using IronBarCode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using ZXing;
using ZXing.Common;

namespace BarcodeApp
{
    public class BarcodeActions
    {
        static TYPE type = TYPE.PHARMACODE;
        public static Barcode CreateAndSaveBarcode(string data)
        {
            Barcode barcode = new Barcode(data, type);
            barcode.Encode(type, data);
            barcode.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\barcode.png", BarcodeLib.SaveTypes.PNG);
            Console.WriteLine("The barcode was created and saved, the stored data -> {0}", data);
            return barcode;
        }
        public static string ReadBarcode(string imagePath)
        {
            var barcodeReader = BarcodeReader.QuicklyReadOneBarcode(imagePath);
            if (barcodeReader != null)
            {
                return barcodeReader.Text;
                Console.WriteLine($"Data Value: {barcodeReader.Text}");
            }

            return null;
        }
    }
}

