using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using reunions.Controllers;



namespace Reunions.Tests
{
    public class ReunionControllerTests
    {
        [Fact]
        public void Index_Returns_A_View ()
        {
            //arrange
            ReunionsController sut = new ReunionsController();

            // act
            var result = sut.Index();
            // assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
