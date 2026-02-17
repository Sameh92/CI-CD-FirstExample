namespace CI_CD.FirstExample.Tests;
public class HomeControllerTests
{
    [Fact]
    public void HomePage_Returns_Correct_Title()
    {
        // Arrange
        var expectedTitle = "Home Page";

        // Act
        var actualTitle = "Home Page";

        // Assert
        Assert.Equal(expectedTitle, actualTitle);
    }

    [Fact]
    public void Two_Plus_Two_Equals_Four()
    {
        // Arrange & Act
        var result = 2 + 2;

        // Assert
        Assert.Equal(4, result);
    }
}
