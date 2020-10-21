using ReviewsSite.Models;
using ReviewsSite.Repositories;
using Xunit;
using NSubstitute;
using ReviewsSite.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace ReviewsSite.Tests
{
    public class ReviewControllerTests
    {
        ReviewController sut;
        IRepository<Review> reviewRepo;

        public ReviewControllerTests()
        {
            reviewRepo = Substitute.For<IRepository<Review>>();
            sut = new ReviewController(reviewRepo);
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
        public void Index_Returns_Reviews_To_View()
        {
            var expectedReviews = new List<Review>();
            reviewRepo.GetAll().Returns(expectedReviews);

            var result = sut.Index();

            Assert.IsType<List<Review>>(result.Model);
        }

        [Fact]
        public void Index_Passes_All_Reviews_To_View()
        {
            var expectedReviews = new List<Review>();
            reviewRepo.GetAll().Returns(expectedReviews);

            var result = sut.Index();

            Assert.Equal(expectedReviews, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = sut.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Review_To_View()
        {
            var expectedReview = new Review();
            reviewRepo.GetById(1).Returns(expectedReview);

            var result = sut.Details(1);

            Assert.Equal(expectedReview, result.Model);
        }

    }
}
