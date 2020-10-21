using System;
using ReviewsSite.Models;
using Xunit;
using System.Collections.Generic;
using System.Text;

namespace ReviewsSite.Tests
{
    public class ReviewTests
    {
        Review sut;

        public ReviewTests()
        {
            sut = new Review(1,"Content","ReviewerName",1,"10/21/2020",1); 
        }

        [Fact]
        public void ReviewConstructor_Sets_Id_On_ReviewModel()
        {
            int result = sut.Id;
            Assert.Equal(1, result);
        }

        [Fact]
        public void ReviewConstructor_Sets_ReviewerName_On_ReviewModel()
        {
            string result = sut.ReviewerName;
            Assert.Equal("ReviewerName", result);
        }

        [Fact]
        public void ReviewConstructor_Sets_Rating_On_ReviewModel()
        {
            int result = sut.Rating;
            Assert.Equal(1, result);
        }

        [Fact]
        public void ReviewConstructor_Sets_ReviewDate_On_ReviewModel()
        {
            string result = sut.ReviewDate;
            Assert.Equal("10/21/2020", result);
        }

        [Fact]
        public void ReviewConstructor_Sets_AlbumId_On_ReviewModel()
        {
            int result = sut.AlbumId;
            Assert.Equal(1, result);
        }

    }
}
