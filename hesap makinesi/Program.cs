int sayi1;
int sayi2;
string op;

Console.WriteLine("Lütfen ilk değeri giriniz : ");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
op = Convert.ToString(Console.ReadLine());

Console.WriteLine("Lütfen ikinci değeri giriniz : ");
sayi2 = Convert.ToInt32(Console.ReadLine());



switch (op)
{
    case "+": Console.WriteLine($"{sayi1} + {sayi2} toplamı = {sayi1 + sayi2}"); break;

    case "-": Console.WriteLine($"{sayi1} - {sayi2} farkı = {sayi1 - sayi2}"); break;

    case "*": Console.WriteLine($"{sayi1} * {sayi2} çarpımı = {sayi1 * sayi2}"); break;

    case "/": Console.WriteLine($"{sayi1} / {sayi2} bölümü = {sayi1 / sayi2}"); break;

}