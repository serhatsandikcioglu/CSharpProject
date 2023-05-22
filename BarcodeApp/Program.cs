using BarcodeLib;
using BarcodeApp;
using System.Diagnostics;
int input;
do
{
    Console.WriteLine("Please select the operation you want to perform : \n*************************\n(1) Create Barcode\n(2) ReadBarcode\n" +
        "(0) Exit");
    input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            Console.Write("Enter Barcode Data: ");
            string data = Console.ReadLine();
            Barcode barcode = BarcodeActions.CreateAndSaveBarcode(data);
            break;
        case 2:
            BarcodeActions.ReadBarcode(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\barcode.png");
            break;
        case 0:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Invalid transaction number, try again.");
            break;
    }
} while (input != 0);