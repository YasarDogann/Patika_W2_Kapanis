# Patika Week2 Kapanış Uygulaması
Merhaba,
Bu proje C# ile Patika+ 2.hafta kapanış soruları alıştırma için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Method kullanımı ve yapısını anlamak.
- Döngüler ve veri yapıları yapısını anlamak
-`ref` ve `out` anahtar kelimeleri kullanımı ve yapısını anlamak
- `Math` kütüphanesi kullanımı



## Sorular
```
1 - Aşağıdaki çıktıyı yazan bir program.

Merhaba
Nasılsın ?
İyiyim
Sen nasılsın ?
```
```
2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
```
```
3 - Rastgele bir sayı üretip , ekrana yazdırınız.
```
```
4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
```
```
5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
```
```
6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
```
```
7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
```
```
8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
```
```
9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
```
```
10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
```
```
11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
```
```
12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
```
```
13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
```
```
14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
```
```
15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
```
```
16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
```
```
17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
```
```
18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
```
## Not
Bütün sorular tek sayfada yapılmıştır. `#Region` ile sorular ayrılmıştır.

## 🚀 1. Soru Kod
```csharp
 Quest1_Hello(); //methodu çağırıyoruz.

static void Quest1_Hello()
{
    //1 - Aşağıdaki çıktıyı yazan bir program.

    //Merhaba
    //Nasılsın ?
    //İyiyim
    //Sen nasılsın?

    Console.WriteLine("Merhaba\r\nnasılsın? \r\nİyiyim\r\nsen nasılsın?");
}
```

## 🚀 2. Soru Kod
```csharp
  //2.Geriye Tamsayı Döndüren Bir metot
public static int Number()
{
    Random rand = new Random();
    int num = rand.Next(1,100);
    Console.WriteLine("Üretilen sayı: "+num);

    return num % 2;
}

 static void Main(string[] args)
 {
     //2. SORU
     int result = Number();
     Console.WriteLine(result);
     Console.Read();
}
```

## 🚀 3. Soru Kod
```csharp
//3.Parametre Alan ve Geriye Değer Döndüren Bir Metot
public static int Carp(int num1, int num2)
{
    return num1*num2;
}

 static void Main(string[] args)
 {
     //3.SORU
int result_carp = Carp(5, 2);
Console.WriteLine("iki sayının çarpımı: "+result_carp);
     Console.Read();
}
```

## 🚀 4. Soru Kod
```csharp
//4.Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
public static void Message(string name, string surname)
{
    Console.WriteLine("Hoşgeldiniz {0} {1}", name, surname);
}

 static void Main(string[] args)
 {
     //3.SORU
//4.SORU
Message("Mauro","Icardi");
     Console.Read();
}

