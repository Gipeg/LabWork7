using Task1;

Order order = new();
order.Print();
Console.WriteLine("_____________");

Console.WriteLine("Operators:"); //вывод операторов

Order order1 = new() { Summ = 0 };
Console.WriteLine(order1.Summ);
order1++;
order1.Print();

Console.WriteLine("________________________________"); //вывод заказа
Order order2 = new() { Summ = 2000, Address = "ул. Пушкина д. Колотушкино", Name = "Илья" };
Order order3 = new() { Summ = 500 };
Console.WriteLine(order2.Summ);
Console.WriteLine(order3.Summ);


Order order4 = order2 + order3;
Console.WriteLine(order4.Summ);
order4.Print();

Console.WriteLine("______________________________"); //анализ заказов на 'и' и 'или'

Console.WriteLine("______________________________");
Order order5 = new() { Summ = 100 };
Console.WriteLine(order5.Summ);


if (order5) //анализ пятого заказа
    Console.WriteLine("Сумма заказа больше или равно 0 (>=0)");
else
    Console.WriteLine("сумма заказа меньше 0 (<0)");