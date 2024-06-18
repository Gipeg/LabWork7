namespace Task1
{
    public class Order  //имена компонентов класса
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Summ { get; set; }

        public Order() //первоначальный класс
           : this("Неизвестна","Неизвестен",0) { }

        public Order(string Name, string Address, int Summ) //присваивание переменным служебные имена
        {
            this.Name = Name;
            this.Address = Address;
            this.Summ = Summ;
        }

        public static Order operator ++(Order order) 
            => new Order
            {
                Name = order.Name,
                Address = order.Address,
                Summ = order.Summ + 1
            };

        public static Order operator +(Order first, Order second) =>
            new Order //присваивание из Program.CS имён в класс
            {
                Name = first.Name,
                Address = first.Address,
                Summ = first.Summ + second.Summ
            };

        //рассчёты операторов
        public static bool operator true(Order order) => order.Summ >= 0;

        public static bool operator false(Order order) => order.Summ < 0;

        public void Print() //вывод класса
        {
            Console.WriteLine($"Заказ: {Name}, адрес: {Address}, Сумма: {Summ}");
        }
    }
}
