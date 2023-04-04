namespace AdvancedCollections.Core.Models;

public enum ChangeType { Append, Insert, Remove }

public class ItineraryChange
{
    public ChangeType ChangeType { get; set; }

    public Country Value { get; set; }

    public int Index { get; set; }

    public ItineraryChange(ChangeType changeType, Country value, int index)
    {
        ChangeType = changeType;
        Value = value;
        Index = index;
    }
}
