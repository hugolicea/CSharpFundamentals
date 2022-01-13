using Xunit;

namespace GradeBook.Test;

public class BookTest
{
    [Fact]
    public void BookCalculatesAnAverageGrade()
    {
        //arrange
        var book = new Book("");
        book.AddGrades(79.99);
        book.AddGrades(89.99);
        book.AddGrades(99.99);

        //act
        var result = book.GetStatistics();

        //assert
        Assert.Equal(89.99, result.Agerage, 2);
        Assert.Equal(79.99, result.LowValue, 2);
        Assert.Equal(99.99, result.HighValue, 2);
        Assert.Equal('B', result.Letter);

    }
}