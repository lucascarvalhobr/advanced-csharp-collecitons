namespace AdvancedCollections.Tests;

public class ArraysTest
{
    [Fact]
    public void Array_SequenceEqual_Test()
    {
        DateTime[] dates =
        {
            new DateTime(2023, 4, 3),
            new DateTime(2023, 4, 4),
            new DateTime(2023, 4, 5),
            new DateTime(2023, 4, 6),
            new DateTime(2023, 4, 7),
            new DateTime(2023, 4, 8),
            new DateTime(2023, 4, 9),
            new DateTime(2023, 4, 10),
            new DateTime(2023, 4, 11)
        };

        DateTime[] datesCopy =
        {
            new DateTime(2023, 4, 3),
            new DateTime(2023, 4, 4),
            new DateTime(2023, 4, 5),
            new DateTime(2023, 4, 6),
            new DateTime(2023, 4, 7),
            new DateTime(2023, 4, 8),
            new DateTime(2023, 4, 9),
            new DateTime(2023, 4, 10),
            new DateTime(2023, 4, 11)
        };

        //expensive operation
        Assert.True(dates.SequenceEqual(datesCopy));
    }
}