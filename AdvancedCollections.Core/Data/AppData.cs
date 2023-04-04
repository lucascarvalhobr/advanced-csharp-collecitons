using AdvancedCollections.Core.Models;
using System.Collections.Concurrent;
using System.Reflection;

namespace AdvancedCollections.Core.Data;
public class AppData
{
    public List<Country> AllCountries { get; private set; }

    public Dictionary<string, Country> AllCountriesByDict { get; private set; }

    public ConcurrentDictionary<string, Country> AllCountriesByDictConcurrent { get; private set; }

    public Dictionary<CountryCode, Country> AllCountriesByCustomDict { get; private set; }

    public LinkedList<Country> ItineraryBuilder { get; } = new LinkedList<Country>();

    public SortedDictionary<string, Tour> AllTours { get; private set; } = new SortedDictionary<string, Tour>
    {
        {"Tour one" , new Tour("Tour one", Array.Empty<Country>()) },
        {"Tour two" , new Tour("Tour two", Array.Empty<Country>()) },
    };

    public SortedDictionary<string, Country> AllCountriesBySortedDict { get; private set; }

    public Stack<ItineraryChange> Changelog { get; } = new Stack<ItineraryChange>();

    public List<Customer> Customers { get; private set; }
        = new List<Customer>() { new Customer("Simon"), new Customer("Kim") };

    public Queue<(Customer theCustomer, Tour theTour)> BookingRequest { get; }
        = new Queue<(Customer, Tour)>();
    public AppData Initialize()
    {
        string csvFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data", "countries.csv");

        CsvReader reader = new CsvReader(csvFilePath);

        AllCountries = reader.ReadAllCountries().OrderBy(x => x.Name).ToList();
        AllCountriesByDict = AllCountries.ToDictionary(x => x.Code, StringComparer.OrdinalIgnoreCase);
        AllCountriesByDictConcurrent = new ConcurrentDictionary<string, Country>(AllCountriesByDict);
        AllCountriesByCustomDict = AllCountries.ToDictionary(x => x.CountryCode);
        AllCountriesBySortedDict = new SortedDictionary<string, Country>(AllCountriesByDict);

        return this;
    }
}
