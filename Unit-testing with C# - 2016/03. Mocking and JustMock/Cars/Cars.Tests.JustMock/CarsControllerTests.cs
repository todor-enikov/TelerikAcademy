namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    using Telerik.JustMock;
    using Moq;
    using Cars.Data;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        // : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void Search_ShouldSearchForACar_ByGivenString()
        {
            // Arrange
            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.Search(It.IsAny<string>())).Returns(new List<Car>());
            var fakeCar = mock.Object;
            var controller = new CarsController(fakeCar);

            // Act
            var result = controller.Search(string.Empty);

            // Assert
            mock.Verify(m => m.Search(It.IsAny<string>()), Times.Exactly(1));

        }

        [TestMethod]
        public void Sort_ShouldThrowException_IfStringIsNotCorrect()
        {
            // Arrange
            bool actual = false;
            var differentSortingParameter = "Kvo ne chu?!";
            var controller = new CarsController();

            // Act
            try
            {
                var result = controller.Sort(differentSortingParameter);
            }
            catch (Exception ex)
            {
                actual = ex.Message.Contains("Invalid");
            }

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Sort_ShouldCoverCaseMake_IfStringIsmake()
        {
            //Arrange
            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.SortedByMake());
            var fakeCarRepository = mock.Object;
            var controller = new CarsController(fakeCarRepository);

            // Act
            var result = controller.Sort("make");

            // Assert
            mock.Verify(m => m.SortedByMake(), Times.Exactly(1));
        }

        [TestMethod]
        public void Sort_ShouldCoverCaseYear_IfTheStringIsyear()
        {
            // Arrange
            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.SortedByYear());
            var fakeCarRepository = mock.Object;
            var controller = new CarsController(fakeCarRepository);

            // Act
            var result = controller.Sort("year");

            // Assert
            mock.Verify(m => m.SortedByYear(), Times.Exactly(1));
        }

        [TestMethod]
        public void Details_ShouldThrowException_IfCarIsNull()
        {
            // Arrange
            Car car = null;

            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.GetById(It.IsAny<int>())).Returns(car);

            var fakeCarRepository = mock.Object;
            var controller = new CarsController(fakeCarRepository);
            var actual = false;

            // Act
            try
            {
                var result = controller.Details(5);
            }
            catch(ArgumentNullException ex)
            {
                actual = ex.Message.Contains("Car");
            }

            // Assert
            Assert.IsTrue(actual);

        }
        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
