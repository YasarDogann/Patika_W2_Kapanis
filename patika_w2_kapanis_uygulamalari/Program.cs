using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace patika_w2_kapanis_uygulamalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SORU 1
            Quest1_Hello(); //methodu çağırıyoruz.
            #endregion

            #region SORU 2
            int num = 5;
            string text = "soru2";

            Quest2_Variable(num, text); //parametre olarak dışarıdan alınan 2 veriyi methodun parametresi olarak koyuyoruz
            #endregion

            #region SORU 3
            int return_num = Quest3_Random(); //döndürülen int değeri yakalıyoruz ve değişkene atıyoruz.
            Console.WriteLine("Üretilen Random Sayı: " + return_num);

            #endregion

            #region SORU 4
            int random_number;
            double result;

            result = Quest4_NumMod(out random_number); //out anahtar kelimesi ile methoddan bir deüer döndürüldüğünü belirtiyoruz
            Console.WriteLine($"Rastgele Üretilen sayi {random_number} ve 3'e bölümünden kalan: {result}");
            #endregion

            #region SORU 5

            Console.Write("Yaşınızı Giriniz: ");
            byte age = byte.Parse(Console.ReadLine());
            Quest5_CheckAge(age);

            #endregion

            #region SORU 6  
            Quest6_Message();
            #endregion

            #region SORU 7
            Console.Write("1.İsim: ");
            string name1 = Console.ReadLine();

            Console.Write("2.İsim: ");
            string name2 = Console.ReadLine();

            Quest7_Swap(ref name1, ref name2); //ref ile, metot dışındaki name1 ve name2 değişkenleri doğrudan değiştiriliyor.

            Console.WriteLine("Yer Değiştirdikten Sonra: ");
            Console.WriteLine("1.İsim: " + name1);
            Console.WriteLine("2.İsim: " + name2);

            #endregion

            #region SORU 8
            BenDegerDondurmem();
            #endregion

            #region SORU 9
            int num1; int num2; int sum_result;

            Console.Write("1.Sayı: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayı: ");
            num2 = int.Parse(Console.ReadLine());

            sum_result = Quest9_Sum(num1, num2);
            Console.WriteLine("Toplam: " + sum_result);

            #endregion

            #region SORU 10
            bool user_input;

            Console.Write("True yada false giriniz: ");
            user_input = bool.Parse(Console.ReadLine().ToLower());

            Console.WriteLine(Quest10_TrueFalseConvert(user_input));
            #endregion

            #region SORU 11
            Console.WriteLine("En Yaşlı: " + Quest11_OldPeople(15, 12, 51));
            #endregion

            #region SORU 12
            int com_number = Quest12_FindMaxNumber();
            Console.WriteLine("En büyük Sayı: " + com_number);

            #endregion

            #region SORU 13
            Console.Write("1.İsim gir: ");
            string name1 = Console.ReadLine();

            Console.Write("2.İsim gir: ");
            string name2 = Console.ReadLine();

            Quest13_ReplaceName(name1, name2);

            Console.WriteLine("\r\n------- İsimler Yer Değiştirildi --------\r\n");
            Console.WriteLine("1.İsim: " + name2);
            Console.WriteLine("2.İsim: " + name1);

            #endregion

            #region SORU 14
            Console.WriteLine("\n------------------- Girilen Sayı ÇİFT ise TRUE, TEK sayı ise FALSE -------------------");

            Console.WriteLine(Quest14_CheckOddOrEven(6));

            #endregion

            #region SORU 15

            Console.WriteLine(Quest15_CalculateDistance(100, 5));

            #endregion

            #region SORU 16
            Quest16_Circle(5);

            #endregion

            #region SORU 17
            Quest17_ToLowerToUpper();
            #endregion

            #region SORU 18
            Quest18_DeleteText();
            #endregion

        }

        static void Quest1_Hello()
        {
            /*1 - Aşağıdaki çıktıyı yazan bir program.

            Merhaba
            Nasılsın ?
            İyiyim
            Sen nasılsın ?
            */

            Console.WriteLine("Merhaba\r\nnasılsın? \r\nİyiyim\r\nsen nasılsın?");
        }

        static void Quest2_Variable(int num, string text)
        {
            //2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız.
            //Bunların değerlerini atayıp , ekrana yazdırınız.

            Console.WriteLine("Gelen sayı: " + num);
            Console.WriteLine("Gelen yazı: " + text);

        }

        static int Quest3_Random()
        {
            //3 - Rastgele bir sayı üretip , ekrana yazdırınız.

            Random rnd = new Random();  //randm sayı için bir nesne oluşturduk
            int num = rnd.Next(); //nesne'den bir random sayı ürettik

            return num;  // üretilen sayıyı int değer olarak döndürdük
        }

        static double Quest4_NumMod(out int num)
        {
            //4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
            Random rnd = new Random();
            num = rnd.Next();

            double result = (double)num % 3;
            return result;

        }

        static void Quest5_CheckAge(byte age)
        {
            //5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

            if (age >= 18)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }

        static void Quest6_Message()
        {
            //6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
            Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
        }

        static void Quest7_Swap(ref string name1, ref string name2)//ref anahtar kelimesi kullanarak değişkenlerin referansları üzerinde değişiklik yaptık
        {
            //7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
            string temp = name1;
            name1 = name2;
            name2 = temp;
        }

        static void BenDegerDondurmem()
        {
            //8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.Ekrana "Ben değer döndürmem ,
            //benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
            Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
        }

        static int Quest9_Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static string Quest10_TrueFalseConvert(bool input)
        {
            //10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            if (input == true)
            {
                return "True değer girdiniz";
            }
            else
            {
                return "false değer girdiniz.";
            }
        }

        static int Quest11_OldPeople(int age1, int age2, int age3)
        {
            //11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

            // age1 ve age2 arasında büyük olanı aldı daha sonra age3 ile karşılaştırdı.
            int maxAge = Math.Max(Math.Max(age1, age2), age3);
            return maxAge;  //Büyük olan yaş bilgisini return yaptık
        }

        static int Quest12_FindMaxNumber()
        {
            //12 - Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve
            //aynı zamanda geriye dönen bir metot yazınız.


            int number; //girilen ve diziye kaydedilecek sayı
            int maxNumber = int.MinValue; //başlangıçta en küçük tam sayı değerini atadık.

            List<int> numbers = new List<int>(); //dinamik liste

            //sınırsız sayıda sayı alma
            while (true)
            {
                Console.Write("Sayı gir (Çıkmak için q bas): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q") //q girildiğinde döngüden çıkılacak.
                {
                    break;
                }
                //sayı kontrolü
                if (int.TryParse(input, out number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Geçerli Sayı gir.");
                }
            }

            foreach (int num in numbers) //dizi içindeki sayıları tek tek gezmek için foreach döngüsü
            {
                maxNumber = Math.Max(maxNumber, num); //dizideki sayılarla karşılaştırma yap

            }
            return maxNumber;   //geriye en büyük sayı değeri döndürüldü
        }

        static void Quest13_ReplaceName(string name1, string name2)
        {
            //13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
            string temp = name1;  //1. isim'i değişkene atadık
            name1 = name2;        // name2 değişkenin'in değerini name1'in içine atadık
            name2 = temp;         // daha sonra temp içindeki (baştaki name1) değerini atadık.  
        }

        static bool Quest14_CheckOddOrEven(int number) //sayıyı parametre olark aldık
        {
            Console.WriteLine("Girilen sayı: " + number);
            return number % 2 == 0 ? true : false; //ternany if ile tek satırda durum kontrolü yaptım ve return ile değer döndürdüm.
        }

        static double Quest15_CalculateDistance(double speed, double time) // hız ve zaman değişkenini parametre olarak alıyoruz.
        {
            //15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

            //mesafe = hız * zaman
            double distence = speed * time;
            return distence;// hesaplanan mesafeyi döndürür

        }

        static void Quest16_Circle(int r)
        {

            //16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
            // alan = pi* (r*r)
            double pi = Math.PI; //pi sayısı

            double area = pi * (Math.Pow(r, 2)); //Math.pow ile yarıçap'ın karesini aldık.
            Console.WriteLine($"Dairenin Yarı Çap'ı: {r} ve Alanı: {area}");
        }

        static void Quest17_ToLowerToUpper()
        {
            //17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.
            string text = "Zaman bir GeRi SayIm";

            Console.WriteLine("Büyük Harfler ile: "+ text.ToUpper()); //toupper ile hepsini büyük harf yaptık
            Console.WriteLine("Küçük Harfler ile: " + text.ToLower()); //tolower ile hepsini küçük harf yaptık

        }
    
        static void Quest18_DeleteText()
        {
            //18 - "    Selamlar   " metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
            string text = "    Selamlar   ";

            Console.WriteLine(text.Trim()); //Trim methodu ile baştaki ve sondaki bütün boşlular silindi
            Console.Read();
        }
    }
}
