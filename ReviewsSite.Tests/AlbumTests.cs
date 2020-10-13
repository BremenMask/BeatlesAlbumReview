using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewsSite.Tests
{
    public class AlbumTests
    {
        Album sut;
        public AlbumTests()
        {
            sut = new Album(1, "Album name", "Album description", "Album category", "Review", "Image");
        }

        [Fact]
        public void AlbumConstructor_Sets_Id_On_AlbumModel()
        {
            int result = sut.Id;
            Assert.Equal(1, result);
        }

        [Fact]
        public void AlbumConstructor_Sets_Name_On_AlbumModel()
        {
            string result = sut.Name;

            Assert.Equal("Album name", result);
        }

        [Fact]
        public void AlbumConstructor_Sets_Description_On_AlbumModel()
        {
            string result = sut.Description;

            Assert.Equal("Album description", result);
        }

        [Fact]
        public void AlbumConstructor_Sets_Category_On_AlbumModel()
        {
            string result = sut.Category;

            Assert.Equal("Album category", result);
        }

        [Fact]
        public void AlbumConstructor_Sets_Review_On_AlbumModel()
        {
            string result = sut.Review;

            Assert.Equal("Review", result);
        }

        [Fact]
        public void AlbumConstructor_Sets_Image_On_AlbumModel()
        {
            string result = sut.Image;

            Assert.Equal("Image", result);
        }
    }
}
