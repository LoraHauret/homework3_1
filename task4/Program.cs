namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSite site = new WebSite();
            site.setName("Сайт компании Микрософт");
            site.setUrl("https://learn.microsoft.com");
            site.setSiteDescription("Microsoft Learn. Блестящие возможности.\n\tПриобретайте навыки, которые открывают двери в будущее. \n\tУзнайте обо всех возможностях, которые предоставляет вам документация, \n\tпрактические учебные материалы и сертификации, которые помогут с \n\tмаксимальной эффективностью использовать продукты Майкрософт.");
            site.setIpAddress(new uint[] { 104, 81, 63, 149 });
            site.PrintSiteInfo();

            WebSite site1 = new WebSite("METANIT",
                "https://metanit.com",
                "\n\tДанный сайт посвящен различным языкам и технологиям программирования, \n\tкомпьютерам, мобильным платформам и ИТ-технологиям. Здесь будут выкладываться \n\tразличные руководства и учебные материалы, статьи и примеры.\n\tНа сайте можно найти материалы по таким направлениям, \n\tкак язык C# и семейство технологий .NET (ASP.NET, WPF, Entity Framework и т.д.), \n\tтехнологии на базе Java ( Java SE, программирование под ОС Андроид и т.д.), \n\tPython, Dart (в том числе Flutter), работа с базами данных (MS SQL Server, MySQL, MongoDB)\n\t а также WEB-технологии, такие как HTML5, AJAX, jQuery, Node.js, ExtJS, Angular, React и др.",
                new uint[] { 77, 222, 61, 70 });

            site1.PrintSiteInfo();
        }
    }

    internal class WebSite
    {
        private string name;
        public string getName() { return name; }
        public void setName(string Name) { name = Name; }

        private string url;
        public string getUrl() { return url; }
        public void setUrl(string Url) { url = Url; }

        private string siteDescription;
        public string getSiteDescription() { return siteDescription; }
        public void setSiteDescription(string SiteDescription) { siteDescription = SiteDescription; }

        private uint[] ipAddress = new uint[4];
        public uint[] getIpAddress() { return ipAddress; }
        public void setIpAddress(uint[] IpAddress)
        {
            for (int i = 0; i < ipAddress.Length; i++)
            {
                ipAddress[i] = IpAddress[i];
            }
        }

        public WebSite() { }
        public WebSite(string name, string url, string description, uint[] IP)
        {
            this.Init(name, url, description, IP);
        }

        public void Init(string name, string url, string description, uint[] IP)
        {
            this.name = name;
            this.url = url;
            siteDescription = description;
            setIpAddress(IP);
        }

        public void PrintSiteInfo()
        {
            Console.WriteLine("\n\tНазвание сайта: {0}\n", name);
            Console.WriteLine("\tПуть к сайту: {0}\n", url);
            Console.WriteLine("\tОписание сайта: {0}\n", siteDescription);

            Console.Write("\tIP сайта: ");
            foreach (uint el in ipAddress)
                Console.Write("{0}.", el);

            Console.WriteLine("\n\n\n\n");

        }
    }
}