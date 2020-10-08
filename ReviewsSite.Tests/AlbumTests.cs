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
            sut = new Album(1, "Album name", "Album description");
        }

        [Fact]
        public void AlbumConstructor_Sets_Id_On_CourseModel()
        {
            int result = sut.Id;
            Assert.Equal(1, result);
        }

        [Fact]
        public void AlbumConstructor_Sets_Name_On_CourseModel()
        {
            string result = sut.Name;

            Assert.Equal("Album name", result);
        }

        [Fact]
        public void AlbumConstructor_Sets_Description_On_CourseModel()
        {
            string result = sut.Description;

            Assert.Equal("Album description", result);
        }



    }
}
