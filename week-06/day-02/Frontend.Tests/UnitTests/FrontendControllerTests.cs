using System;
using System.Collections.Generic;
using System.Text;
using Frontend.Controllers;
using Frontend.Models;
using Frontend.Services;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;

namespace Frontend.Tests.UnitTests
{
    public class FrontendControllerTests
    {
        [Fact]
        public void Doubling_NoInput_DisplayErrorMessage()
        {
            // arrange
            var controller = new HomeController(null);

            // act
            var result = controller.Doubling(0);

            // assert
            Assert.Equal("Please provide an input!", result.Value.Error);
        }

        [Fact]
        public void Doubling_WithInput_ReturnActionResultOfDoubling()
        {
            // arrange
            var controller = new HomeController(null);

            // act
            var result = controller.Doubling(15);

            // Because Doubling(a class) here is a reference type,
            // doubling1 != doubling2
            // Doubling doubling1 = new Doubling();
            // Doubling doubling2 = new Doubling();

            // doubling2 == doubling3
            // Doubling doubling1 = new Doubling();
            // Doubling doubling2 = doubling1;
            // Doubling doubling3 = doubling1;

            // assert
            // only works if Equals method is overriden in Doubling class:
            // in this way the two objects are compared by their values.
            // Assert.Equal(new Doubling { Received = 15, Result = 30 }, result.Value);
            //            Assert.True(result.Value.Received == 15 && result.Value.Result == 30);

            Assert.Equal(typeof(ActionResult<Doubling>), result.GetType());
        }

        [Fact]
        public void Greeter_NoName_DisplayErrorMessage()
        {
            var controller = new HomeController(null);

            var result = controller.Greeter(null, "student");

            Assert.Equal("Please provide a name!", result.Value.Error);
        }

        [Fact]
        public void Greeter_NoTitle_DisplayErrorMessage()
        {
            var controller = new HomeController(null);

            var result = controller.Greeter("Jimmy", null);

            Assert.Equal("Please provide a title!", result.Value.Error);
        }

        [Fact]
        public void Greeter_WithNameAndTitle_GreetProperly()
        {
            var controller = new HomeController(null);

            var result = controller.Greeter("Jimmy", "student");

            Assert.Equal("Oh, hi there Jimmy, my dear student!", result.Value.Welcome_message);
        }

        [Fact]
        public void Appenda_WithAppendable_AppendStringWithA()
        {
            var controller = new HomeController(null);

            var result = controller.Appenda("kuty");

            Assert.Equal("kutya", result.Value.Appended);
        }

        [Fact]
        public void Appenda_WithoutAppendable_ReturnNotFound()
        {
            var controller = new HomeController(null);

            var result = controller.Appenda(null);

            Assert.Equal(typeof(NotFoundResult), result.Result.GetType());
        }

        [Fact]
        public void DountilSum_NoNumber_DisplayErrorMessage()
        {
            var controller = new HomeController(null);

            var result = controller.Sum(new Dountil());

            Assert.Equal("Please provide a number!", result.Value.Error);
        }

        [Fact]
        public void DountilSum_WithNumbers_ReturnAnInteger()
        {
            var mockService = Substitute.For<IFrontendServices>();
            mockService.Sum(0).ReturnsForAnyArgs(15);
            var controller = new HomeController(mockService);

            var result = controller.Sum(new Dountil());

            Assert.Equal(typeof(int), result.Value.Result.GetType());
        }

        [Fact]
        public void DountilFactor_NoNumber_DisplayErrorMessage()
        {
            var controller = new HomeController(null);

            var result = controller.Factor(new Dountil());

            Assert.Equal("Please provide a number!", result.Value.Error);
        }

        [Fact]
        public void DountilFactor_WithNumbers_ReturnAnInteger()
        {
            var mockService = Substitute.For<IFrontendServices>();
            mockService.Factor(0).ReturnsForAnyArgs(15);
            var controller = new HomeController(mockService);

            var result = controller.Factor(new Dountil());

            Assert.Equal(typeof(int), result.Value.Result.GetType());
        }

        [Fact]
        public void Arrays_NoActionOrNumbers_DisplayErrorMessage()
        {
            var controller = new HomeController(null);

            var result = controller.Arrays(new Arrays());

            Assert.Equal("Please provide what to do with the numbers!", result.Value.Error);
        }

        [Fact]
        public void Arrays_SumAction_ReturnAnInteger()
        {
            var mockService = Substitute.For<IFrontendServices>();
            mockService.Sum(new int[0]).ReturnsForAnyArgs(5);
            var controller = new HomeController(mockService);

            var result = controller.Arrays(new Arrays { What = "sum", Numbers = new int[0] });

            Assert.Equal(typeof(int), result.Value.Result.GetType());
        }

        [Fact]
        public void Arrays_MultiplyAction_ReturnAnInteger()
        {
            var mockService = Substitute.For<IFrontendServices>();
            mockService.Multiply(new int[0]).ReturnsForAnyArgs(5);
            var controller = new HomeController(mockService);

            var result = controller.Arrays(new Arrays { What = "multiply", Numbers = new int[0] });

            Assert.Equal(typeof(int), result.Value.Result.GetType());
        }

        [Fact]
        public void Arrays_DoubleAction_ReturnAnIntegerArray()
        {
            var mockService = Substitute.For<IFrontendServices>();
            mockService.Double(new int[0]).ReturnsForAnyArgs(new int[1]);
            var controller = new HomeController(mockService);

            var result = controller.Arrays(new Arrays { What = "double", Numbers = new int[0] });

            Assert.Equal(typeof(int[]), result.Value.Result.GetType());
        }
    }
}
