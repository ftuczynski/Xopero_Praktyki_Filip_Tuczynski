using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.Imaging;

namespace Wpf_JimmysComics {
    using System.Collections.ObjectModel;

    class ComicQueryManager
    {

        public ObservableCollection<ComicQuery> AvailableQueries { get; private set; }

        public ObservableCollection<object> CurrentQueryResults { get; private set; }

        public string Title { get; set; }

        public ComicQueryManager()
        {
            UpdateAvailableQueries();
            CurrentQueryResults = new ObservableCollection<object>();
        }

        private void UpdateAvailableQueries()
        {
            AvailableQueries = new ObservableCollection<ComicQuery> {
                new ComicQuery("LINQ ułatwia zapytania", "Proste zapytanie",
                    "Pokażmy Jankowi jak elastyczna jest technologia LINQ",
                    CreateImageFromAssets("purple_250x250.jpg")),

                new ComicQuery("Drogie komiksy", "Komiksy powyżej 500 zł.",
                    "Komiksy o wartości przekraczającej 500 zł."
                    + " Janek może użyć tych danych do wybrania najbardziej pożądanych komiksów.",
                    CreateImageFromAssets("captain_amazing_250x250.jpg")),

                new ComicQuery("LINQ jest wszechstronne 1", "Modyfikuje wszystkie zwracane dane",
                    "Ten kod doda łańcuch znaków na końcu każdego tekstu przechowywanego w tablicy.",
                    CreateImageFromAssets("bluegray_250x250.jpg")),
            
                new ComicQuery("LINQ jest wszechstronne 2", "Wykonuje obliczenia na kolekcjach",
                    "LINQ udostępnia metody rozszerzające dla kolekcji (oraz wszystkich innych"
                    + " typów implementujących interfejs IEnumerable<T>).",
                    CreateImageFromAssets("purple_250x250.jpg")),
            
                new ComicQuery("LINQ jest wszechstronne 3",
                    "Zapisuje całe wyniki lub ich część w nowej sekwencji",
                    "Czasami będziesz chciał zachować wyniki zapytania, by ich"
                    + " użyć w przyszłości.",
                    CreateImageFromAssets("bluegray_250x250.jpg")),

                new ComicQuery("Grupuj komiksy według zakresu cen",
                    "Pogrupuj komiksy Janka według cen",
                    "Janek kupuje dużo tanich komiksów, trochę średniej wartości "
                         + " i pojedyncze sztuki drogich, jednak przed zakupem chciałby"
                         + " wiedzieć jakie ma możliwości.",
                        CreateImageFromAssets("captain_amazing_250x250.jpg")),

                new ComicQuery("Połącz zakupy z cenami",
                    "Przekonajmy się, czy Janek ostro się targuje",
                    "To zapytanie tworzy listę obiektów Purchase zawierających zakupy Janka"
                         + " i porównuje je z cenami z Listy Grzegorza.",
                    CreateImageFromAssets("captain_amazing_250x250.jpg")),

                new ComicQuery("Wszystkie komiksy w kolekcji", 
                   "Zobacz wszystkie komiksy w kolekcji",
                   "To zapytanie zwraca wszystkie komiksy",
                   CreateImageFromAssets("captain_amazing_zoom_250x250.jpg")),
            };
        }

        private static BitmapImage CreateImageFromAssets(string imageFilename)
        {
            try {
                Uri uri = new Uri(imageFilename, UriKind.RelativeOrAbsolute);
                return new BitmapImage(uri);
            }
            catch (System.IO.IOException) {
                return new BitmapImage();
            }
        }

        public void UpdateQueryResults(ComicQuery query)
        {
            Title = query.Title;

            switch (query.Title)
            {
                case "LINQ ułatwia zapytania": LinqMakesQueriesEasy(); break;
                case "Drogie komiksy": ExpensiveComics(); break;
                case "LINQ jest wszechstronne 1": LinqIsVersatile1(); break;
                case "LINQ jest wszechstronne 2": LinqIsVersatile2(); break;
                case "LINQ jest wszechstronne 3": LinqIsVersatile3(); break;
                case "Grupuj komiksy według zakresu cen":
                    CombineJimmysValuesIntoGroups();
                    break;
                case "Połącz zakupy z cenami":
                    JoinPurchasesWithPrices();
                    break;
                case "Wszystkie komiksy w kolekcji": AllComics(); break;
            }
        }

        public static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic> {
                new Comic { Name = "Johnny America vs. the Pinko", Issue = 6, Year = 1949, CoverPrice = "10 groszy",
                    MainVillain = "Pinko", Cover = CreateImageFromAssets("Captain Amazing Issue 6 cover.png"),
                    Synopsis = "Kapitan Wspaniały musi ratować Amerykę przed komunikstami, gdyż Pinko i jego" 
                        + " komunikstyczne pachołki uknuły plan obrabowania Fort Knox i ukradzenia całego złota." },

                new Comic { Name = "Rock and Roll (edycja limitowana)", Issue = 19, Year = 1957, CoverPrice = "10 groszy",
                    MainVillain = "Doktor Vortran", Cover = CreateImageFromAssets("Captain Amazing Issue 19 cover.png"),
                    Synopsis = "Doktor Vortran sieje spustoszenie wśród młodzieży przy użyciu swego radiowego urządzenia,"
                        + " które korzysta z najnowszego tanecznego szaleństwa, by wprowadzać fanów rock'n'rolla"
                        + " w niekontrolowany trans."},

                new Comic { Name = "Woman’s Work", Issue = 36, Year = 1968, CoverPrice = "12 groszy", 
                    MainVillain = "Hysterianna", Cover = CreateImageFromAssets("Captain Amazing Issue 36 cover.png"),
                    Synopsis = "Kapitan staje twarzą w twarz ze swym pierwszym wrogiem płci żeńskiej, Hysterianna,"
                        + " której niesamowite, telepatyczne i telekinetyczne zdolności pozwalają powołać armię"
                        + " kobiet, jakiej nawet Kapitan będzie miał problemy sprostać." },

                new Comic { Name = "Hippie Madness (źle wydrukowany)", Issue = 57, Year = 1973, CoverPrice = "20 groszy",
                    MainVillain = "Mayor", Cover = CreateImageFromAssets("Captain Amazing Issue 57 cover.png"),
                    Synopsis = "Apokalipsa zombie zagraża istnieniu Obiektowa, gdyż Mayor ustawił wybory"
                        + " wprowadzając agenta zombie do firmy dostarczającej papierosy całemu miastu." },

                new Comic { Name = "Revenge of the New Wave Freak (uszkodzony)", Issue = 68, Year = 1984, 
                    CoverPrice = "75 groszy", MainVillain = "Swindler",
                    Cover = CreateImageFromAssets("Captain Amazing Issue 68 cover.png"),
                    Synopsis = "Zanieczyszczony tusz do powiek zmienia Dr. Alvina Mudda nowe nemezis Kapitana "
                        + " i wprowadzając postać Kanciarza do komiksów o Kapitanie Wspaniałym." },

                new Comic { Name = "Black Monday", Issue = 74, Year = 1986, CoverPrice = "75 groszy",
                    MainVillain = "Mayor", Cover = CreateImageFromAssets("Captain Amazing Issue 74 cover.png"),
                    Synopsis = "Mayor wraca by doprowadzić Obiektowo do finansowego kryzysu poprzez wykorzystanie"
                        + " swych mocy tworzenie zombie przeciwko Giełdzie Obiektowa." },

                new Comic { Name = "Tribal Tattoo Madness", Issue = 83, Year = 1996, CoverPrice = "Dwa złote",
                    MainVillain = "Mokey Man", Cover = CreateImageFromAssets("Captain Amazing Issue 83 cover.png"),
                    Synopsis = "Monkey Man - przerażający Człowiek małpa - ucieka ze swego więzienia na wyspie i wraz" 
                        + " z grupą wytatułowanych cyrkowych pomocników siej spustoszenie przy użyciu śmiertelnego "
                        + " promienia brudu." },

                new Comic { Name = "The Death of an Object", Issue = 97, Year = 2013, CoverPrice = "Cztery złote",
                    MainVillain = "Kanciarz", Cover = CreateImageFromAssets("Captain Amazing Issue 97 cover.png"),
                    Synopsis = "Armia klonów Kanciarza atakuje Obiektowo w desperackiej próbie złapania i zabicia "
                        + " Kapitana Wspniałego. Czy naukowcom z Obiektowa uda się przywrócić go do życia?" },
            };
        }

        private static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal> {
            { 6, 3600M }, { 19, 500M }, { 36, 650M }, { 57, 13525M },
            { 68, 250M }, { 74, 75M }, { 83, 25.75M }, { 97, 35.25M },
        };
        }

        private void LinqMakesQueriesEasy()
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var result = from v in values
                         where v < 37
                         orderby v
                         select v;

            CurrentQueryResults.Clear();
            foreach (int i in result)
                CurrentQueryResults.Add(
                     new
                     {
                         Title = i.ToString(),
                         Image = CreateImageFromAssets("purple_250x250.jpg"),
                     }
                    );
        }

        private void ExpensiveComics()
        {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();

            var mostExpensive = from comic in comics
                                where values[comic.Issue] > 500
                                orderby values[comic.Issue] descending
                                select comic;

            CurrentQueryResults.Clear();

            foreach (Comic comic in mostExpensive)
                CurrentQueryResults.Add(
                        new
                        {
                            Title = String.Format("{0} jest warty {1:c}",
                                                  comic.Name, values[comic.Issue] ),
                            Image = CreateImageFromAssets("captain_amazing_250x250.jpg"),
                        }
                    );
        }

        private void LinqIsVersatile1()
        {
            string[] sandwiches = { "szynka z serem", "salami z majonezem",
		                            "indyk z musztardą", "kotlet z kurczaka" };
            var sandwichesOnRye =
                from sandwich in sandwiches
                select sandwich + " na chlebie ryżowym";

            CurrentQueryResults.Clear();
            foreach (var sandwich in sandwichesOnRye)
                CurrentQueryResults.Add(CreateAnonymousListViewItem(sandwich, "bluegray_250x250.jpg"));
        }

        private void LinqIsVersatile2()
        {
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
                listOfNumbers.Add(random.Next(100));

            CurrentQueryResults.Clear();
            CurrentQueryResults.Add(CreateAnonymousListViewItem(
                String.Format("Dostępnych jest {0} liczb", listOfNumbers.Count())));
            CurrentQueryResults.Add(
                CreateAnonymousListViewItem(String.Format("Najmniejsza wartość to: {0}", listOfNumbers.Min())));
            CurrentQueryResults.Add(
               CreateAnonymousListViewItem(String.Format("Największa wartość to: {0}", listOfNumbers.Max())));
            CurrentQueryResults.Add(
               CreateAnonymousListViewItem(String.Format("Suma wartości: {0}", listOfNumbers.Sum())));
            CurrentQueryResults.Add(CreateAnonymousListViewItem(
                      String.Format("Wartość średnia to: {0:F2}", listOfNumbers.Average())));
        }

        private void LinqIsVersatile3()
        {
            List<int> listOfNumbers = new List<int>();
            for (int i = 1; i <= 10000; i++)
                listOfNumbers.Add(i);

            var under50sorted =
                    from number in listOfNumbers
                    where number < 50
                    orderby number descending
                    select number;

            var firstFive = under50sorted.Take(6);

            List<int> shortList = firstFive.ToList();
            foreach (int n in shortList)
                CurrentQueryResults.Add(CreateAnonymousListViewItem(n.ToString(), "bluegray_250x250.jpg"));
        }

        private object CreateAnonymousListViewItem(string title,
                        string imageFilename = "purple_250x250.jpg")
        {
            return new
            {
                Title = title,
                Image = CreateImageFromAssets(imageFilename),
            };
        }

        private void CombineJimmysValuesIntoGroups()
        {
            Dictionary<int, decimal> values = GetPrices();
            var priceGroups =
                from pair in values
                group pair.Key by Purchase.EvaluatePrice(pair.Value)
                    into priceGroup
                    orderby priceGroup.Key descending
                    select priceGroup;
            foreach (var group in priceGroups)
            {
                string stringKey;
                switch (group.Key)
                {
                    case PriceRange.Cheap:
                        stringKey = "tanie";
                        break;
                    case PriceRange.Midrange:
                        stringKey = "średnie";
                        break;
                    default:
                        stringKey = "drogie";
                        break;

                }
                string message = String.Format("Znalazłem {0} {1} komiksy: numery ",
                                               group.Count(), stringKey);
                foreach (var price in group)
                    message += price.ToString() + " ";
                CurrentQueryResults.Add(
                   CreateAnonymousListViewItem(message, "captain_amazing_250x250.jpg"));
            }
        }

        private void JoinPurchasesWithPrices()
        {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();
            IEnumerable<Purchase> purchases = Purchase.FindPurchases();
            var results =
                from comic in comics
                join purchase in purchases
                on comic.Issue equals purchase.Issue
                orderby comic.Issue ascending
                select new
                {
                    Comic = comic,
                    Price = purchase.Price,
                    Title = comic.Name,
                    Subtitle = "Numer " + comic.Issue,
                    Description = String.Format("Kupiony za {0:c}", purchase.Price),
                    Image = CreateImageFromAssets("captain_amazing_250x250.jpg"),
                };

            decimal gregsListValue = 0;
            decimal totalSpent = 0;
            foreach (var result in results)
            {
                gregsListValue += values[result.Comic.Issue];
                totalSpent += result.Price;
                CurrentQueryResults.Add(result);
            }

            Title = String.Format("Wydałem {0:c} na komiksy warte {1:c}",
                     totalSpent, gregsListValue);
        }

        private void AllComics()
        {
            foreach (Comic comic in BuildCatalog())
            {
                var result = new
                {
                    Image = CreateImageFromAssets("captain_amazing_zoom_250x250.jpg"),
                    Title = comic.Name,
                    Subtitle = "Numer " + comic.Issue,
                    Description = "Kapitan Wspaniały kontra " + comic.MainVillain,
                    Comic = comic,
                };
                CurrentQueryResults.Add(result);
            }
        }

    }
}
