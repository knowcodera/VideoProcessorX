using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net;
using System.Security.Claims;
using VideoProcessingService.Infrastructure.Data;

namespace VideoProcessorX.IntegrationTests
{
    //public class VideosControllerTests
    //{
    //    [Fact]
    //    public async Task GetUserVideos_ReturnsOk_WithVideosList()
    //    {
    //        // Configurando um DbContext em mem�ria para o teste
    //        var options = new DbContextOptionsBuilder<AppDbContext>()
    //            .UseInMemoryDatabase(databaseName: "GetUserVideos_TestDb")
    //            .Options;
    //        using var context = new AppDbContext(options);

    //        // Adiciona um v�deo para o usu�rio com ID 1
    //        context.Videos.Add(new Video
    //        {
    //            Id = 1,
    //            UserId = 1,
    //            OriginalFileName = "teste.mp4",
    //            Status = "COMPLETED",
    //            CreatedAt = DateTime.UtcNow
    //        });
    //        context.SaveChanges();

    //        // Configura as depend�ncias mockadas
    //        var mockEnv = new Mock<IWebHostEnvironment>();
    //        mockEnv.Setup(e => e.ContentRootPath).Returns(Directory.GetCurrentDirectory());
    //        var mockVideoService = new Mock<IVideoService>();

    //        // Cria o controller e simula o usu�rio autenticado
    //        var controller = new VideosController(context, mockEnv.Object, mockVideoService.Object);
    //        controller.ControllerContext = new ControllerContext
    //        {
    //            HttpContext = new DefaultHttpContext
    //            {
    //                User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
    //                {
    //                    new Claim("sub", "1")
    //                }))
    //            }
    //        };

    //        // A��o
    //        var result = await controller.GetUserVideos();

    //        // Verifica��o
    //        var okResult = Assert.IsType<OkObjectResult>(result);
    //        var videos = Assert.IsAssignableFrom<IEnumerable<dynamic>>(okResult.Value);
    //        Assert.Single(videos);
    //    }
    //}
}