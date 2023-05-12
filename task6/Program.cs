namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop1 = new Shop("Rozetka");
            shop1.Description = "самый большой онлайн-ритейлер в стране. \n\tС 2005 года мы воплощаем маленькие мечты и грандиозные планы миллионов людей. \n\tУ нас можно найти буквально все. Мы продаем по справедливой цене и \n\tпредоставляем гарантию, так как считаем, что онлайн-шопинг должен быть максимально удобным и безопасным. \n\tИ каждый раз, когда кто-то нажимает «Купить», мы понимаем, что делаем нужное дело.";
            shop1.Address = "https://rozetka.com.ua";
            shop1.Telephone = 1234558947;
            shop1.Email = "sales@rozetka.com.ua";

            shop1.Print();
        }
    }

    internal class Shop
    {
        public string Name
        {
            get; private set;
        }
        public string Address
        { get; set; }

        public string Description
        { get; set; }

        public uint Telephone
        { get; set; }

        public string Email
        { get; set; }
        public Shop()
        {

        }
        public Shop(string name) => Name = name;

        public Shop(string name, string address, uint telephone, string email, string description = "Описание отсутствует.")
        {
            this.Init(name, address, description, telephone, email);
        }

        public void Init(string name, string address, string description, uint telephone, string email)
        {
            Name = name;
            Address = address;
            Description = description;
            Telephone = telephone;
            Email = email;
        }

        public void Print() => Console.WriteLine("\n\tНазвание магазина: {0}\n\n\tАдрес магазина: {1}\n\n\tОписание профиля магазина: {2}\n\n\tКонтактный телефон: {3}\n\n\tКонтактный e-mail: {4}",
                                                Name, Address, Description, Telephone, Email);
    }
}