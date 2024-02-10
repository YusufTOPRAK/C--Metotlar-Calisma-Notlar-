using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Projede alınan hatalar deneme için yani kasıtlı hatalardır.

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int s1 = 4;
            int s2 = 5;
                
            Topla(s1,s2);*/ // Topla metodu static olarak tanımlandığı için burada çalıştırılabilindi.
            
            X(); // In komutu konusu için

            #region Başka Sınıfta Tanımlanmış Metotların Erişimi
            // Kullanılan class Program class'ı içinde kullanıldığı için, çağrılacak(kullanılcak)
            // class'ın erişim belirleyicisi ona göre seçilmeli(burada public).
            /*Matamatik matamatik = new Matamatik();
            Console.WriteLine(matamatik.Topla2(4,7));
            Console.WriteLine(matamatik.Carpma(56,3));
            Console.WriteLine(matamatik.Bolme(64, 4));
            Console.WriteLine(matamatik.Cikarma(69,34));
            Console.ReadLine();*/
            #endregion Başka Sınıfta Tanımlanmış Metotların Erişimi

            #region Non Trailing Named Arguments Özelliği
            // İlgili parametlere verilen değerler sırasıyla vermek zorunludur.(a = 4,b = 1,c = "kaya")
            // Bu zorunluluk non trailing named arguments özelliği ile ortadan kaldırılabilir. 
            X(4,1,"kaya"); // zorunlu olan
            X(b:1, c:"kaya", a:4 ); // Non Trailing Named Arguments Özelliği
            #endregion Non Trailing Named Arguments Özelliği

            #region ref KEYWORDÜ 
            // ref, referansın kısaltmasıdır.
            // OOP'de(Nesne Tabanlı Programlamada) nesneler RAM'in heap kısmında tutulur.
            // Heap kısmını direkt olarak erişim yoktur.
            // Heap kısmına erişebilmek için Stack kısmında oluşturulan değişken
            // referans türü olarak tanımlanarak Heap'teki object'e ulaşır(kullanabilmek için).
            // Tanımlanan referans türdeki değişken(r) bir başka referans türdeki değişkene(r2) aktarılırsa(r = r2)
            // r'deki değişim r2'ye yansır. Buradaki "=" assing değil referans etme operatörüdür yani kopyalama yoktur.
            // Primitive(değer) türlü değişkenlerde "=" kopyalama yapar. 
            // Primitive(değer) türlü değişkenlerde "="'in referans operatörü olarak kullanılması istendiğinde
            // yani kopyalama yapmadan atama yapılmak istendiğinde ref keywördü kullanılır.
            // Bu olaya shallow(yüzeysel) kopyalama denir.
            int a = 4;  // a ve b'nin 4 değerleri farklı değerlerdir.
            int b = a; // a değiştiridiğinde b değişmez 4 olarak kalır.

            int x = 5;
            ref int y = ref x; // x ve y'nin değeri(5) aynıdır. Herhangi birindeki değişim diğerine etki eder.
            #endregion ref KEYWORDÜ

            #region ref returns
            // Sadece metotlarda kullanılır.
            // Metotlarda geriye nesne döndürülebilir.
            // Metotlarda değer(primitive) türlü değişkenlerin referansını döndürmek için ref returns kullanılır.
            // Örneğin metoda gönderilen değer değişkenini geriye döndürmek
            #endregion ref returns
        }

        #region TANIM
        // Belirli bir işlevi yerine getirmek için oluşturulan yapılardır.
        // Class'ın bir elemanıdır.
        #endregion TANIM

        #region METOT OLUŞTURMA
        // METOT PARAMETLERİ // 
        // erişim belirleyici(access modifiers) - geri dönüş değeri - metot adı()

        #region ERİŞİM BELİRLEYİCİLER(ACCESS MODIFIERS)
        //// ERİŞİM BELİRLEYİCİLER(ACCESS MODIFIERS) ////
        // Yazılan koda dışarıdan herhangi bir kısıtlama sağlayarak
        // uygulamaların güvenliğini artırmak için kullanılır.
        // Class, struct, function, method ve property'lere uygulanabilir.

        // 5 tane erişim belirleyicisi vardır:
        // 1) Public(Genel) //
        // - Her yerden ulaşılabilir kodlardır. Hiçbir kısıtlama yoktur.

        // 2) Private(Özel) //
        // - Varsayılan erişim belirleyici türdür.
        // - Sadece kodların var olduğu sınıftaki alanda ulaşılabilir.

        // 3) Protected(Korunumlu)
        // - Bulunduğu class ve o class'tan üretilen diğer sınıflardan da ulaşılabilen kodlardır.

        // 4) Internal(İçsel)
        // - Sadece bulunduğu projeden ulaşılablir kodlardır.

        // 5) Protected Internal(İçsel Korunumlu)
        // - Tanımlandığı sınıf ve o sınıfı miras alan sınıflardan erişilebilen kodlardır.
        // - Bu sınıfların aynı projede yer alması gerekir.(Protected ile farkı)
        #endregion ERİŞİM BELİRLEYİCİLER(ACCESS MODIFIERS)

        #endregion METOT OLUŞTURMA

        #region METOT VARYASYONLARI
        // Yapılacak işleme göre 4 farklı şekilde metot oluşturulabilir.
        // erişim belirleyici(access modifiers) - geri dönüş değeri - metot adı()
        #region GERİYE DEĞER DÖNDÜRMEYEN, PARAMETRE ALMAYAN METOT
        // Bu varyasyonda geri döndürülen bir değer olmayacağı için void keywordu kullanılır.,
        private void Metot1()
        {
            Console.WriteLine("GERİYE DEĞER DÖNDÜRMEYEN, PARAMETRE ALMAYAN METOT");
        }
        #endregion GERİYE DEĞER DÖNDÜRMEYEN, PARAMETRE ALMAYAN METOT

        #region GERİYE DEĞER DÖNDÜRMEYEN, PARAMETRE ALAN METOT
        // Metotlar farklı türlerde parametre alabilir.
        private void Metot2(int a, char b, string c, byte d, bool e) // Parametre aldı.
        {
            Console.WriteLine("GERİYE DEĞER DÖNDÜRMEYEN, PARAMETRE ALAN METOT");
        }
        #endregion GERİYE DEĞER DÖNDÜRMEYEN, PARAMETRE ALAN METOT

        #region GERİYE DEĞER DÖNDÜREN, PARAMETRE ALMAYAN METOT
        // Geriye döndürülecek değer her türden olabilir.
        // Geriye döndürülecek türün değeri belirtilmezse hata verir. Belirtmek için return keywordu kullanılır.
        // return ile döndürülecek değer, metot tanımlamasındaki türün alabileceği bir değer olmalıdır.
        // return aynı zamanda fonksiyondan çıkılmasını/fonksiyonun sonlanmasını sağlar.
        private bool Metot3() // geri döndürülecek değerin tipi bool'dur.
        {
            return true;     // belirtilmezse hata verir. 
        } 

        // Metot içinde kullanılan şartlı ifadeden elde edilecek hem true hem false için yapılacak işlem belirtilmelidir.
        // Fonksiyonun en sonunda sonlanabilmesi için her koşulda yapılması gerekenler tanımlanmalıdır.
        private int SartlıMetot()
        {
            if(DateTime.Now.Second > 10)
                return 1; // true durumu
            return 0; // false durumu ==> tanımlanmazsa hata verir.
        }
        #endregion GERİYE DEĞER DÖNDÜREN, PARAMETRE ALMAYAN METOT

        #region GERİYE DEĞER DÖNDÜREN, PARAMETRE ALAN METOT
        public int Metot4(int a)
        {
            return 5;
        }

        // Birden fazla değer aynı anda geri döndürülebilir.
        public int MetotOrnegi()
        {
            return DateTime.Now.Year > 2000 ? 1 : 0; // Şart için true ve false durumları aynı anda tanımlanmış oldu.
        }
        #endregion GERİYE DEĞER DÖNDÜREN, PARAMETRE ALAN METOT

        #endregion METOT VARYASYONLARI

        #region MAIN FONKSİYONU İÇİNDE KULLANABİLME
        // Oluşturulan metodun Main fonksiyonunda çalıştırılabilmesi için static olarak tanımlanmalı.
        // return değeri parametre olarak verilen değerler üzerinden işlem yapılmasını sağlar.
        static public int Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            Console.ReadLine();
            return sonuc;
        }

        // Personelin eklenip eklenmediğinin kontrolü retun'den alınacak değer(geriye dönüş değeri) ile öğrenilir.

        static public bool PersonelEkle(string ad, string soyad, int yas)
        {
            if (yas >= 20)
            {
                // Veri tabanına eklendi
                return true;
            }
            else
            {
                Console.WriteLine("EKLENEMEDİ");
                return false;
            }
        }
        #endregion MAIN FONKSİYONU İÇİNDE KULLANABİLME

        #region  Optional Parameters(İsteğe Bağlı Parametreler)
        // Metot çağrıldığında tanımlanmış parametrelerine değer verilmeli.
        // Metotlara ait parametrelerin zorunlu olarak değer alınması istenmiyorsa optional parameters(isteğe bağlı parametreler) kullanılır.
        // Parametreye varsayılan değer atanarak optional parameters(isteğe bağlı parametre) olması sağlanır.
        static public int Topla2(int a, int b = 5) // a değişkeninin parametre alması zorunludur.
        {                                          // b değişkeninin parametre alması zorunlu değildir.
            int sonuc = a + b;
            return sonuc;
        }
        #endregion  Optional Parameters(İsteğe Bağlı Parametreler)

        // Kod örneği aynı başlık adıyla static void'in dışında yer alıyor.
        #region Başka Sınıfta Tanımlanmış Metotların Erişimi-Referans ve Nesne İlişkisi

        #region Class Nedir?
        // Herhangi bir şeyin özelliklerini barındıran yapıdır.
        // Örnek: Öğrenci(adi,soyadi,yasi,mezun_durumu)
        #endregion Class Nedir?

        #region Nesne Nedir?
        // Class içindeki özelliklere karşılık gelen değerlerin verileridir.
        // Örnek: Ali, Veli, 24, Üniversite mezunu
        #endregion Nesne Nedir?

        #region Referanas Nedir?
        // Class'tan üretilen nesneyi barındırmayı sağlayan tanımlanmış değişkenler.
        // Örnek: Random r = new Random();
        #endregion Referanas Nedir?

        #endregion Başka Sınıfta Tanımlanmış Metotların Erişimi-Referans ve Nesne İlişkisi

        #region Non Trailing Named Arguments Özelliği
        // İlgili parametlere verilen değerler sırasıyla vermek zorunludur(a,b,c).
        // Bu zorunluluk non trailing named arguments özelliği ile ortadan kaldırılabilir.
        static public void X(int a, int b, string c)
        {
            
        }
        #endregion Non Trailing Named Arguments Özelliği

        #region In Keywordü
        // Metot içindeki parametreler metot içerisinde herhangi bir yerde çağırılıp kullanılabilir.
        // Parametrelere değer atanabilir ve bu değerler değiştirilebilir.
        // Metot içindeki parametreye karşılık gelen değerin değiştilmesi istenmiyorsa In keywordü kullanılır.
        // Belirtilen değer dışında başka bir değer verilirse derleyici hatası verilir.
        // In komutu, metodun parametresini readonly(sadece okunabilir) hale getirir.
        static void X(in int a = 123) // a parametresinin değeri değiştirilemezdir.
        {
            a = 35;// HATA VERİR
            Console.WriteLine(a);
            Console.ReadLine();
        }
        #endregion  In Keywordü

        #region Local Functions(Metot İçerisinde Tanımlanabilir Yerel Metotlar) 
        // Metot içinde metot tanımlanabilir.
        // Local function tanımlanırken erişim belirleyicisi kullanılmaz.
        // Sadece tanımlandığı metot içinde kullanılabilir.
        ///// KULLANIM AMACI /////
        //1- Metot içinde tekrarlanacak/tekrarlanabilecek işlemleri local function ile tanımlayarak
        //tekrar yazmaktansa ihtiyaç duyulduğu zaman çağrılması.
        public static void A()
        {
            void B() // local function
            {

            }
        }
        #endregion Local Functions(Metot İçerisinde Tanımlanabilir Yerel Metotlar)

        #region Static Local Functions(Metot İçerisinde Tanımlanabilir Statik Yerel Metotlar)
        // Metot içinde tanımlanmış bir değer(parametre gibi) o metot içindeki local fonksiyonda çağrılabilir.
        // Fakat çağrılması maliyetlidir. Çağrılmasını engellemek için local fonksiyon static olarak tanımlanır.
        // static olarak tanımlanan local fonksiyonun parametre alabilmesi için kendi parametresinde tanımlanır.
        // Burdaki amaç maliyeti azaltmaktır.
        private static void metot()
        {
            int a = 4;
            void metoticindemetot()
            {
                Console.WriteLine(a); // a parametresi çağrılabildi.
            }

            static void metoticindemetot2() // HATA VERDİ. Dosyadan kaynaklı. Kullanım doğru.
            {
                Console.WriteLine(a); // a parametresi çağrılamaz.
            }

            static void metoticindemetot3(int a) // HATA VERDİ. Dosyadan kaynaklı. Kullanım doğru.
            {
                Console.WriteLine(a); // a parametresi local fonksiyonda tanıtıldı ve çağrılabildi.
            }
        }
        #endregion Static Local Functions(Metot İçerisinde Tanımlanabilir Statik Yerel Metotlar)

        // Kod örneği aynı başlık adıyla static void'in dışında yer alıyor.
        #region Metotlarda Overloading(Çoklu Yükleme)
        // Bir class içinde aynı isimde birden fazla metot tanımlanamaz.
        // Fakat bazı uygulanan işlemlerden(kurallardan) dolayı aynı isimde birden fazla metot tanımlanabilir.
        // Örneğin aynı isimde olan metotların parametre sayısı farklıysa tanımlanabilirler.
        // Bu işlemleri(kuralları) gerçekleştirerek aynı isimde birden fazla metot tanımlamaya overloading denir.
        // Aynı isme(Topla3) birden fazla metot uygulandığı için overloading(çoklu yükleme) denir.
        // Overload aynı işlevi farklı şekillerde gören metotlarda kullanılır.
        // Örneğin Random classının Next metodu kendisi dışında 2 overload'a sahiptir.
        //1. Parametre almadan integer değer aralığında rastgele sayı oluşturma. ==> kendi kullanımı
        //2. Alınan parametre maksimim değer kabul edilerek 0 ile o değer arasında rastgele sayı oluşturma. ==> 1.Overload 
        //3. Aralıklar belirlenerek rastgele sayı oluşturma. ==> 2.Overload 

        #region OVERLOADING KURALLARI
        // Aynı isimdeki metotlar arasında fark olmalı(görev olarak).
        // Bu farklar arasında erişim belirleyicisi ve geri dönüş değerinin bir önemi yoktur.
        // Overloading işlemi için metotlar aynı isimde olmalı.
        // Parametre sayıları veya türleri farklı olmalıdır.
        #endregion OVERLOADING KURALLARI

        #endregion Metotlarda Overloading(Çoklu Yükleme)

        #region Recursive(Tekrarlamalı/Özyinelemeli) Metotlar
        // Metodun kendi içinde kendisini çağıran fonksiyonlardır.
        // Recursive fonksiyonun kod olarak herhangi bir tanımlaması yoktur çünkü bu bir yaklaşımdır.
        // Öngürelemeyen durumlarda kullanılır.
        // Döngülerin kullanıldığı her durum için recursive fonksiyonlar kullanılabilir.
        // Ama recursive fonksiyon kullanılan her durum için döngü kullanılamaz.
        // Çünkü döngü öngürülebilir ama recursive fonksiyonlar öngürülemez durumlar içindir.

        // R metodu kendisi içinde çağrıldığı için içindeki işlemler sonsuz devam eder.
        // R metoduna daha sonrasında eklenen "Console.WriteLine("A")" işlemi, öncesinde R metodu
        // tekrar tekrar çağrıldığından dolayı gerçekleşemez.
        public static void R()
        {
            Console.WriteLine("Recursive");
            R(); // Fonksiyon içinde kendisi çağrıldığı için R fonksiyonu recursive fonksiyondur.
            Console.WriteLine("A");
        }

        // Metod Recursive Olmasına Rağmen İstenilen Adette(Şartta) İşlem Gerçekleştirme //
        // Bunun için parametre kullanılarak kontrol sağlanabilir.
        public static void R2(int a=1)
        {
            Console.WriteLine("Recursive");
            if (a<3)
            {
                R2(++a); // R2 burada paramtreye karşılık bir değer beklediği için yukarıda default olarak tanımlanmalı.
                         // Her true durumda(a<3) a'yı 1 artırarak(++a) R2'ye a'yı gönderir. Artırma işlemi
                         // belli bir noktada bitmesi için uygulanır.
            }
        }
        #endregion Recursive(Tekrarlamalı/Özyinelemeli) Metotlar

        #region out 
        // Metotlarda dışarıya herhangi bir değer gönderme işlemi return sayesinde gerçekleşir.
        // Metotların parametreleri üzerinden dışarıya değer gönderilmesini sağlayan bir keyworddür.
        // Bir metodun parametreleri varsayılan olarak inputtur.
        // Bu yüzden parametreler metot içerisine değer göndermeye odaklıdır.
        // Metot içindeki parametre dışarıya değer gönderecekse out ile belirtilmelidir.
        // out ile belirtilen parametrelere değer verilme zorunludur. Verilmezse derleyici hatası oluşur.
        public int AAA(out int a, int b) // sadece a parametresi out'tur.
        {
            a=4;
            return 0;
        }

        #endregion out

    }

    #region Başka Sınıfta Tanımlanmış Metotların Erişimi
    /*class Matamatik
    {
        public int Topla2(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Bolme(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }
    }*/

    #endregion Başka Sınıfta Tanımlanmış Metotların Erişimi

    #region Metotlarda Overloading(Çoklu Yükleme)
    class Matamatik2
    {
        public int Topla3(int s1,int s2)
        {
            return s1 + s2;
        }

        public int Topla3(int s1, int s2, int s3)
        {
            return s1 + s2 + s3;
        }
    }
    #endregion Metotlarda Overloading(Çoklu Yükleme)
}
