/******************************************************************************
                          HESAP MAKİNESİ KODLARI
*******************************************************************************/


class HelloWorld
{
    static void Main()
    {
        string tus;
        do
        {
            Console.Write("İlk sayıyı giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Yapmak istediğini işlemi giriniz : ");
            string islem = Console.ReadLine();

            Console.Write("İkinci sayıyı giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());

            switch (islem)
            {
                case "+": Console.WriteLine("Sonuç = {0}", (sayi1 + sayi2)); break;
                case "-": Console.WriteLine("Sonuç = {0}", (sayi1 - sayi2)); break;
                case "*": Console.WriteLine("Sonuç = {0}", (sayi1 * sayi2)); break;
                case "/": Console.WriteLine("Sonuç = {0}", (sayi1 / sayi2)); break;
                default: Console.WriteLine("Yanlış giriş yaptınız......"); break;
            }
            Console.WriteLine("Devam etmek için d tuşuna basınız....");
            tus = Console.ReadLine();
        }
        while (tus == "d" || tus == "D");
    }
}