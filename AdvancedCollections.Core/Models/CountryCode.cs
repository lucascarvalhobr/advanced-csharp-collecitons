namespace AdvancedCollections.Core.Models;
public class CountryCode
{
    public string Value { get; set; }

    public CountryCode(string value)
    {
        Value = value;
    }

    public override string ToString() => Value;

    #region ::Thoses overrides are necessary to use CountryCode as a key in a Dictionary::
    public override bool Equals(object? obj)
    {
        if (obj is CountryCode countryCode)
            return StringComparer.OrdinalIgnoreCase.Equals(this.Value, countryCode.Value);

        return false;
    }

    public static bool operator ==(Country lhs, CountryCode rhs)
    {
        if (lhs != null)
            return lhs.Equals(rhs);

        return rhs == null;
    }

    public static bool operator !=(Country lhs, CountryCode rhs)
    {
        return !(lhs == rhs);
    }

    public override int GetHashCode() => StringComparer.OrdinalIgnoreCase.GetHashCode(this.Value);
    #endregion
}
