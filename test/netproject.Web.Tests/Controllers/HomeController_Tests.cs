using System.Threading.Tasks;
using netproject.Models.TokenAuth;
using netproject.Web.Controllers;
using Shouldly;
using Xunit;

namespace netproject.Web.Tests.Controllers
{
    public class HomeController_Tests: netprojectWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}