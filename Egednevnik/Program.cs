using Egednevnik;

zametki zametki = new zametki();
zametki.da = new DateTime(2022, 10, 21);

Console.SetCursorPosition(10, 0);
Console.WriteLine(zametki.da.ToString("dd.MM.yyyy"));
Console.SetCursorPosition(3, 1);


int pos1 = 0;
int pos2 = 0;

Console.SetCursorPosition(pos1, pos2);
Console.WriteLine("->");
while (true)
{

    ConsoleKeyInfo kay = Console.ReadKey();
    switch (kay.Key)
    {

        case ConsoleKey.LeftArrow:
            pos1--;
            if (pos1 < 0)
                pos1 = 0;
            break;
        case ConsoleKey.RightArrow:
            pos1++;
            if (pos1 > 2)
                pos1 = 2;
            break;
    }
    Console.Clear();
    switch (pos1)
    {
        case 0:
            zametki.da = new DateTime(2022, 10, 21);
            Console.SetCursorPosition(10, 0);
            Console.WriteLine(zametki.da.ToString("dd.MM.yyyy"));
            Console.SetCursorPosition(3, 1);
            break;
        case 1:
            zametki.da = new DateTime(2022, 10, 24);
            Console.SetCursorPosition(10, 0);
            Console.WriteLine(zametki.da.ToString("dd.MM.yyyy"));
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("Поиграть");
            break;
        case 2:
            zametki.da = new DateTime(2022, 10, 26);
            Console.SetCursorPosition(10, 0);
            Console.WriteLine(zametki.da.ToString("dd.MM.yyyy"));
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("Birthday!!!");
            break;
        case 3:
            zametki.da = new DateTime(2022, 10, 28);
            Console.SetCursorPosition(10, 0);
            Console.WriteLine(zametki.da.ToString("dd.MM.yyyy"));
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("УСТАЛЬ! Надо отдохнуть)");
            break;
        case 4:
            zametki.da = new DateTime(2022, 10, 30);
            Console.SetCursorPosition(10, 0);
            Console.WriteLine(zametki.da.ToString("dd.MM.yyyy"));
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("На учебу(");
            break;
        case 5:
            zametki.da = new DateTime(2022, 11, 4);
            Console.SetCursorPosition(10, 0);
            Console.WriteLine(zametki.da.ToString("dd.MM.yyyy"));
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("ЖИТЬ-ЖИТЬ!!!");
            break;
        case 6:
            zametki.da = new DateTime(2022, 11, 5);
            Console.SetCursorPosition(10, 0);
            Console.WriteLine(zametki.da.ToString("dd.MM.yyyy"));
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("(!!!");
            break;
        case 7:
            zametki.da = new DateTime(2022, 11, 5);
            Console.SetCursorPosition(10, 0);
            Console.WriteLine(zametki.da.ToString("dd.MM.yyyy"));
            Console.SetCursorPosition(3, 1);
            Console.WriteLine(")!!!");
            break;



            {

                if (kay.Key == ConsoleKey.Enter)
                {
                    string opisanie = ("Кушать");
                    Console.WriteLine("Описание:" + opisanie);
                    zametki.da = new DateTime(2022, 11, 7);
                    Console.WriteLine("Дата выполнения:" + zametki.da.ToString("dd.MM.yyyy"));
                    break;
                }
                if (kay.Key == ConsoleKey.Enter)
                {
                    string opisanie = ("Погулять");
                    Console.WriteLine("Описание:" + opisanie);
                    List<string> plany = new List<string>() { "Зайти в магази" };
                    foreach (string Person in plany)
                    {
                        Console.WriteLine("Пригласительный для:" + Person);
                    }
                    zametki.da = new DateTime(2022, 12, 13);
                    Console.WriteLine("Дата выполнения:" + zametki.da.ToString("dd.MM.yyyy"));
                }
            }
            Console.SetCursorPosition(pos1, pos2);
            Console.WriteLine("->");

    }
}