Console.WriteLine("Basic.Ketma-ketlik bo'limi uchun 2-amaliy vazifa\n\n");

while (true)
{
    Console.Clear();
    Console.WriteLine("Basic.Ketma-ketlik bo'limi uchun 2-amaliy vazifa\n\n");
    Console.WriteLine("1. Kalkulyator \n" +
                      "2. Raqamlar qatorining yig‘indisini hisoblash \n" +
                      "3. Paritet tekshiruvi \n" +
                      "4. Chiqish");

    Console.Write("tanlang: ");
    var menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1:
            Calculator();
            break;
        case 2:
            Summmator();
            break;
        case 3:
            CheckParitet();
            break;
        case 4:
            return; 
        default:
            Console.WriteLine("Noto'g'ri kalit");
            break;
    }
    Console.WriteLine("Davom etish uchun biror tugmani bosing...");
    Console.ReadKey();
}

void Calculator()
{
    Console.WriteLine("\nCalculator");

    Console.WriteLine("faqat butun sonlar!");
    Console.Write("1 raqam: ");
    var first = int.Parse(Console.ReadLine());

    Console.WriteLine("only + - * /");

    Console.Write("ishora: ");
    var operation = Console.ReadLine();

    Console.Write("2 raqam: ");
    var second = int.Parse(Console.ReadLine());

    double result = 0;
    bool isValidOperation = true;

    switch (operation)
    {
        case "+":
            result = first + second;
            break;
        case "-":
            result = first - second;
            break;
        case "*":
            result = first * second;
            break;
        case "/":
            if (second != 0)
            {
                result = first / second;
            }
            else
            {
                Console.WriteLine("Nolga bo'lib bo'lmaydi");
                isValidOperation = false;
            }
            break;
        default:
            Console.WriteLine("Noto'g'ri operatsiya");
            isValidOperation = false;
            break;
    }

    if (isValidOperation)
    {
        Console.WriteLine($"Natija: {result}");
    }
}

void Summmator()
{
    Console.WriteLine("\nSummmator");

    Console.Write("Musbat butun son N ni kiriting: ");
    int n = int.Parse(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }

    Console.WriteLine($"1 dan {n} gacha sonlarning raqamlar yig'indisi: {sum}");

}




void CheckParitet()
{
    Console.WriteLine("\nCheckParitet");

    Console.Write("Raqamni kiriting: ");
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("Juft");
    }
    else
    {
        Console.WriteLine("Toq");
    }

}