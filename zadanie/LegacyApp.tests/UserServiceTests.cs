

using LegacyApp;

namespace LegacyAppTests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameIsEmpty(){
    
        // Arrange
        var userService = new UserService();
        // Act

        var result = userService.AddUser(
            null,
            "Kowalski",
            "kowalski@kowal.com",
            DateTime.Parse("2000-01-01"),
            1
        );

        //Asert
        
        Assert.False(result);

    }
    [Fact]
    public void AddUser_ReturnsFalseWhenLastNameIsEmpty(){
    
        // Arrange
        var userService = new UserService();
        // Act

        var result = userService.AddUser(
            "Jan",
            null,
            "kowalski@kowal.com",
            DateTime.Parse("2000-01-01"),
            1
        );

        //Asert
        
        Assert.False(result);

    }
    [Fact]
    public void AddUser_ReturnsFalseWhenEmailWithoutMonkey(){
    
        // Arrange
        var userService = new UserService();
        // Act

        var result = userService.AddUser(
            "Jan",
            null,
            "kowalskikowal.com",
            DateTime.Parse("2000-01-01"),
            1
        );

        //Asert
        
        Assert.False(result);

    }
    
    
    [Fact]
    public void AddUser_ReturnsFalseWhenEmailWithoutDot(){
    
        // Arrange
        var userService = new UserService();
        // Act

        var result = userService.AddUser(
            "Jan",
            null,
            "kowalski@kowalcom",
            DateTime.Parse("2000-01-01"),
            1
        );

        //Asert
        
        Assert.False(result);

    }
   
}