using Xunit;
using Modules.Users.Domain.Entities;
namespace Tests;

public class TestUser
{

    [Fact]
    public void Test_UserObjCreation(){
        User user = new User("12312312312312312", "TestName", "TestLastName", "55555555", "test@mail.com");

        Assert.NotNull(user);
        Assert.Equal("12312312312312312", user.Id);
        Assert.Equal("55555555", user.PhoneNumber);
    }
}
