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
            sut = new Album(1);
        }

        [Fact]

        public void AlbumConstructor_Sets_Id_On_CourseModel()
        {
            int result = sut.Id;
            Assert.Equal(1, result);
        }



    }
}
