namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine mag1 = new Magazine("Cosmopolitan", 1886);
            mag1.Telephone = 1234567890;
            mag1.Email = "privacy@hearst.com.";
            mag1.Description = "Mеждународный женский журнал. \n\tСодержание включает в себя статьи о взаимоотношениях и сексе, здоровье, карьере, \n\tсамосовершенствовании, знаменитостях, а также моде и красоте.";
            mag1.Print();

            Magazine mag2 = new Magazine("Good Housekeeping", 1885, 123456789, "goodhousekeeping@gmail.com", "Жіночий журнал належить Hearst Corporation, \n\tпублікує статті про жіночі інтереси, тестування продуктів за \n\tдопомогою Інституту раціонального господарювання, рецепти, \n\tдієти, здоров'я, а також літературні статті.");
            Console.WriteLine("\n\t************\n");
            mag2.Print();
        }

        internal class Magazine
        {
            public string Name
            {
                get; private set;
            }
            public ushort Year
            { get; private set; }

            public string Description
            { get; set; }

            public uint Telephone
            { get; set; }

            public string Email
            { get; set; }
            public Magazine()
            {

            }
            public Magazine(string name, ushort year)
            {
                Name = name;
                Year = year;
            }
            public Magazine(string name, ushort year, uint telephone, string email, string description = "Описание отсутствует.")
            {
                this.Init(name, year, description, telephone, email);
            }

            public void Init(string name, ushort year, string description, uint telephone, string email)
            {
                Name = name;
                Year = year;
                Description = description;
                Telephone = telephone;
                Email = email;
            }

            public void Print() => Console.WriteLine("\n\tНазвание журнала: {0}\n\n\tГод основания: {1}\n\n\tОписание журнала: {2}\n\n\tКонтактный телефон: {3}\n\n\tКонтактный e-mail: {4}",
                                                    Name, Year, Description, Telephone, Email);
        }
    }

}