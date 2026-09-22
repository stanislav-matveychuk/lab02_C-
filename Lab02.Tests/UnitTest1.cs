using Xunit;

public class Variant19UtilsTests
{
    private readonly Variant19Utils _utils;

    public Variant19UtilsTests()
    {
        _utils = new Variant19Utils();
    }

    [Theory]
    [InlineData("Hello World", 10)]
    [InlineData("C# is good", 8)]
    [InlineData("Test", 4)]
    [InlineData("   ", 0)]
    [InlineData("", 0)]
    public void CountCharactersWithoutSpaces_ShouldReturnCorrectCount(
        string text, int expected)
    {
        // Act
        int result = _utils.CountCharactersWithoutSpaces(text);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MergeSortedArrays_ShouldMergeTwoArrays()
    {
        // Arrange
        int[] array1 = { 1, 3, 5 };
        int[] array2 = { 2, 4, 6 };
        int[] expected = { 1, 2, 3, 4, 5, 6 };

        // Act
        int[] result = _utils.MergeSortedArrays(array1, array2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MergeSortedArrays_ShouldWorkWithNegativeNumbers()
    {
        // Arrange
        int[] array1 = { -5, -1, 4 };
        int[] array2 = { -3, 0, 7 };
        int[] expected = { -5, -3, -1, 0, 4, 7 };

        // Act
        int[] result = _utils.MergeSortedArrays(array1, array2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MergeSortedArrays_ShouldWorkWithDuplicates()
    {
        // Arrange
        int[] array1 = { 1, 2, 2 };
        int[] array2 = { 2, 3, 4 };
        int[] expected = { 1, 2, 2, 2, 3, 4 };

        // Act
        int[] result = _utils.MergeSortedArrays(array1, array2);

        // Assert
        Assert.Equal(expected, result);
    }
}