

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
   
}