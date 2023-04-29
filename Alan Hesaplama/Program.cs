using Alan_Hesaplama;

int input = 0;
int input1 = 0;
double param1 = 0;
double param2 = 0;
double param3 = 0;
ÜçgenHesaplama üçgen = new ÜçgenHesaplama();
DaireHesaplama daire = new DaireHesaplama();
KareHesaplama kare = new KareHesaplama();
DikdörtgenHesaplama dikdörtgen = new DikdörtgenHesaplama();
do
{
    Console.WriteLine("Geometrik şekil seçiniz: \n*************************\n(1) Daire\n(2) Üçgen\n" +
        "(3) Kare\n(4) Dikdörtgen\n(0) Exit");
    input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            Console.WriteLine("Daire için işlem seçiniz: \n(1) Çevre \n(2) Alan \n(3) Hacim");
            input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dairenin yarıçapını giriniz: ");
            param1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dairenin yüksekliğini giriniz: ");
            param2 = double.Parse(Console.ReadLine());
            switch (input1)
            {
                case 1:
            daire.Alan(param1);
            break;
        case 2:

                    daire.Çevre(param1);
            break;
        case 3:
                    
                    daire.Hacim(param1,param2);
            break;
                default:
                    Console.WriteLine("Invalid transaction number, try again.");
                    break;
            }
            break;
        case 2:
            Console.WriteLine("Üçgen için işlem seçiniz: \n(1) Çevre \n(2) Alan (3) Hacim");
            input1 = int.Parse(Console.ReadLine());
            switch (input1)
            {
                case 1:
                    Console.WriteLine("Üçgenin 1. kenar uzunluğunu giriniz: ");
                    param1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Üçgenin 2. kenar uzunluğunu giriniz: ");
                    param2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Üçgenin 3. kenar uzunluğunu giriniz: ");
                    param3 = double.Parse(Console.ReadLine());
                    üçgen.Çevre(param1,param2,param3);
                    break;
                case 2:
                    Console.WriteLine("Üçgenin taban uzunluğunu giriniz: ");
                    param1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Üçgenin yüksekliğini giriniz: ");
                    param2 = double.Parse(Console.ReadLine());
                    üçgen.Alan(param1, param2);
                    break;
                case 3:
                    Console.WriteLine("Üçgenin taban uzunluğunu giriniz: ");
                    param1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Üçgenin yüksekliğini giriniz: ");
                    param2 = double.Parse(Console.ReadLine());
                    üçgen.Hacim(param1, param2);
                    break;
                default:
                    Console.WriteLine("Invalid transaction number, try again.");
                    break;
            }
            break;
        case 3:
            Console.WriteLine("Kare için işlem seçiniz: \n(1) Çevre \n(2) Alan \n(3) Hacim");
            input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Karenin kenar uzunluğunu giriniz: ");
            param1 = double.Parse(Console.ReadLine());
            switch (input1)
            {
                case 1:
                    kare.Çevre(param1);
                    break;
                case 2:
                    kare.Alan(param1);
                    break;
                case 3:

                    kare.Hacim(param1);
                    break;
                default:
                    Console.WriteLine("Invalid transaction number, try again.");
                    break;
            }
            break;
        case 4:
            Console.WriteLine("Dikdörtgen için işlem seçiniz: \n(1) Çevre \n(2) Alan \n(3) Hacim");
            input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin 1. kenar uzunluğunu giriniz: ");
            param1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin 2. kenar uzunluğunu giriniz: ");
            param2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin yüksekliğini giriniz: ");
            param3 = double.Parse(Console.ReadLine());
            switch (input1)
            {
                case 1:
                    dikdörtgen.Çevre(param1,param2);
                    break;
                case 2:
                    dikdörtgen.Çevre(param1, param2);
                    break;
                case 3:

                    dikdörtgen.Hacim(param1, param2,param3);
                    break;
                default:
                    Console.WriteLine("Invalid transaction number, try again.");
                    break;
            }
            break;
        case 0:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Invalid transaction number, try again.");
            break;
    }
} while (input != 0);