using ATM_App;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
ATMActions aTMActions = new ATMActions();
int input;
do
{
    Console.WriteLine("Please select the operation you want to perform : \n*************************\n(1) Withdrawals\n(2) Deposit\n" +
        "(3) Payment\n(4) End Of Day\n(0) Exit");
    input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            aTMActions.Withdrawals();
            break;
        case 2:
            aTMActions.Deposit();
            break;
        case 3:
            aTMActions.Payment();
            break;
        case 4:
            aTMActions.EndOfDay();
            break;
        case 0:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Invalid transaction number, try again.");
            break;
    }
} while (input != 0);