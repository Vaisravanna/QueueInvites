using System.Diagnostics.Metrics;

List<string> invites = new List<string>();
bool repeater = true;
do
{
    Console.WriteLine("=== ТЕХПОДДЕРЖКА ===" +
        "\n 1. Показать заявки" +
        "\n 2. Добавить заявку" +
        "\n 3. Обработать первую заявку" +
        "\n 4. Количество заявок" +
        "\n 0. Выход");
    if (invites.Count > 4)
    {
        Console.WriteLine("Высокая нагрузка");
    }
    string MenuChooser = Console.ReadLine();
    if (MenuChooser == "1")
    {
        if (invites.Count == 0)
        {
            Console.WriteLine("Заявки пусты");
        }
        else
        {
            int Counter = 1;
            foreach (string i in invites)
            {
                
                Console.WriteLine(Counter +".  "+ i);
                Counter++;
            }
            Counter = 1;
            Console.WriteLine("нажмите любую кнопку чтобы продолжить");
        }
    }
    else if (MenuChooser == "2")
    {
        Console.WriteLine("Введите заявку");
        string add = Console.ReadLine();
        invites.Add(add);
        
    }

    else if (MenuChooser == "3")
    {
        if (invites.Count == 0)
        {
            Console.WriteLine("Заявки пусты");

        }
        else
        {
            Console.WriteLine(invites[0]);
            Console.WriteLine("Удалить заявку? Да/Нет");
            string delchoose = Console.ReadLine();
            if (delchoose == "Да")
            {
                invites.RemoveAt(0);
                Console.Clear();
            }
        }
        
    }
    if (MenuChooser == "4")
        {
        if (invites.Count == 0)
        {
            Console.WriteLine("Заявки пусты");

        }
        Console.WriteLine(invites.Count);
        }
        if (MenuChooser == "0")
        {
            repeater = false;
        }
    Console.WriteLine("нажмите любую кнопку чтобы продолжить");
        Console.ReadLine();
    Console.Clear();
} while (repeater);