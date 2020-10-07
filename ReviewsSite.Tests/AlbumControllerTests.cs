using System;
using System.Web.Mvc;
using Xunit;

namespace ReviewsSite.Tests
{
    public class AlbumControllerTests
    {
        [Fact]
        public void Index_Returns_View()
        {
            // Arrange
            AlbumController sut = new AlbumController();
            // Act
            var result = sut.Index();
            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
