using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using System.Collections.Generic;
using Xunit;

namespace ReviewsSite.Tests
{
    public class AlbumControllerTests
    {
        AlbumController sut;

        public AlbumControllerTests()
        {
          //  sut = new AlbumController();
        }

        [Fact]
        public void Index_Returns_View()
        {

            // Act
            var result = sut.Index();
            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Returns_AlbumModel_To_View()
        {
            var result = sut.Index();

            Assert.IsType<List<Album>>(result.Model);
        }
    }
}
