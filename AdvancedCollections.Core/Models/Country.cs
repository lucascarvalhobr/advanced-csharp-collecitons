namespace AdvancedCollections.Core.Models;
public class Country
{
    public string Name { get; set; }

    public string Code { get; set; }

    public CountryCode CountryCode { get; set; }

    public string Region { get; set; }

    public int Population { get; set; }

    public Country(string name, string code, string region, int population)
    {
        Name = name;
        Code = code;
        CountryCode = new CountryCode(code);
        Region = region;
        Population = population;
    }

    public override string ToString() => $"{Name} ({Code})";
}
