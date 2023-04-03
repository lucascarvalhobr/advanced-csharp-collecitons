using AdvancedCollections.Core.Models;
using System.Reflection;

namespace AdvancedCollections.Core.Data;
public class AppData
{
    public List<Country> AllCountries { get; private set; }

    public Dictionary<string, Country> AllCountriesByDict { get; private set; }

    public Dictionary<CountryCode, Country> AllCountriesByCustomDict { get; private set; }

    public LinkedList<Country> ItineraryBuilder { get; } = new LinkedList<Country>();

    public SortedDictionary<string, Tour> AllTours { get; private set; } = new SortedDictionary<string, Tour>();

    public SortedDictionary<string, Country> AllCountriesBySortedDict { get; private set; }

    public AppData Initialize()
    {
        string csvFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data", "countries.csv");

        CsvReader reader = new CsvReader(csvFilePath);

        AllCountries = reader.ReadAllCountries().OrderBy(x => x.Name).ToList();
        AllCountriesByDict = AllCountries.ToDictionary(x => x.Code, StringComparer.OrdinalIgnoreCase);
        AllCountriesByCustomDict = AllCountries.ToDictionary(x => x.CountryCode);
        AllCountriesBySortedDict = new SortedDictionary<string, Country>(AllCountriesByDict);

        return this;
    }
}
