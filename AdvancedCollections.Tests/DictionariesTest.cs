using AdvancedCollections.Core.Data;
using AdvancedCollections.Core.Models;

namespace AdvancedCollections.Tests;
public class DictionariesTest
{
    private readonly List<Country> _countriesList;
    private readonly Dictionary<string, Country> _countriesDict;

    public DictionariesTest()
    {
        var appData = new AppData().Initialize();

        _countriesList = appData.AllCountries;
        _countriesDict = appData.AllCountriesByDict;
    }

    [Fact(DisplayName = "Find country in a list -> O(n)")]
    public void FindingCountryCodeInList_Test()
    {
        var country = _countriesList.Find(x => x.Code == CountriesConst.Spain);

        Assert.True(country.Name.Equals("Spain"));
    }

    [Fact(DisplayName = "Find country in a dict -> O(1)")]
    public void FindingCountryCodeInDictionary_Test()
    {
        _countriesDict.TryGetValue(CountriesConst.Spain, out Country country);

        Assert.True(country.Name.Equals("Spain"));
    }
}
