using System;
using NUnit.Framework;
using Cars.Models;
using Cars.Data;
using System.Collections.Generic;
using Moq;
using Cars.Tests.JustMock.Mocks;
using Cars.Contracts;
using System.Linq;

namespace Cars.Tests.JustMock
{
    [TestFixture]
    public class CarsRepositoryTests
    {
        [Test]
        public void Add_ShouldAddCarToCarRepository()
        {
            // Arrange
            var car = new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 };
            var db = new Database();
            db.Cars = new List<Car>();
            var count = db.Cars.Count;
            var carsRepository = new CarsRepository(db);

            // Act
            carsRepository.Add(car);

            // Assert
            Assert.AreEqual(1, db.Cars.Count);
        }

        [Test]
        public void Add_ShouldThrowArgumentException_IfCarIsNull()
        {
            // Arrange
            Car car = null;
            var db = new Database();
            db.Cars = new List<Car>();
            var count = db.Cars.Count;
            var carsRepository = new CarsRepository(db);

            // Act and Assert
            Assert.Throws<ArgumentException>(() => carsRepository.Add(car), "Null car cannot be added");
        }

        [Test]
        public void Remove_ShouldremoveCarFromCarsRepository_WhenIsCalled()
        {
            // Arrange
            var car = new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 };
            var db = new Database();
            db.Cars = new List<Car>();
            var carsRepository = new CarsRepository(db);

            // Act
            carsRepository.Add(car);
            carsRepository.Remove(car);

            // Assert
            Assert.AreEqual(0, db.Cars.Count);
        }

        [Test]
        public void Remove_ShouldThrowArgumentException_IfCarIsNull()
        {
            // Arrange
            Car car = null;
            var carsRepository = new CarsRepository();

            // Act and Assert
            var ex = Assert.Throws<ArgumentException>(() => carsRepository.Remove(car));
            Assert.IsTrue(ex.Message.Contains("Null car cannot be removed"));
        }

        [Test]
        public void GetById_ShouldFindCarById()
        {
            // Arrange
            var car = new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 };
            var mock = new Mock<IDatabase>();
            mock.Setup(m => m.Cars).Returns(new List<Car>() { });
            var fakeDB = mock.Object;
            fakeDB.Cars.Add(car);
            var carsRepository = new CarsRepository(fakeDB);

            // Act
            var result = carsRepository.GetById(1);

            // Assert
            mock.Verify(m => m.Cars, Times.Exactly(2));
        }

        [Test]
        public void GetById_ShouldThrowException_IfThereIsNoCarWithThatId()
        {
            // Arrange
            var mock = new Mock<IDatabase>();
            mock.Setup(m => m.Cars).Returns(new List<Car>() { }); ;
            var fakeDB = mock.Object;
            var carsRepository = new CarsRepository(fakeDB);

            // Act and Assert
            var ex = Assert.Throws<ArgumentException>(() => carsRepository.GetById(7));
            Assert.IsTrue(ex.Message.Contains("Car with such Id could not be found"));
        }

        [Test]
        public void All_ShouldReturnAllOfTheCarsInTheDB()
        {
            // Arrange
            var firstCar = new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 };
            var secondCar = new Car { Id = 2, Make = "Moskvich", Model = "12-tak", Year = 1980 };
            var thirdCar = new Car { Id = 3, Make = "Lada", Model = "7-marka", Year = 1991 };

            var mock = new Mock<IDatabase>();
            mock.Setup(m => m.Cars).Returns(new List<Car>() { });
            var fakeDB = mock.Object;
            fakeDB.Cars.Add(firstCar);
            fakeDB.Cars.Add(secondCar);
            fakeDB.Cars.Add(thirdCar);
            var carsRepository = new CarsRepository(fakeDB);

            // Act
            var result = carsRepository.All();

            //Assert
            Assert.AreEqual(3, result.Count);
        }

        [Test]
        public void SortedByMake_ShouldReturnSortedListOfCarsByMake()
        {
            // Arrange
            var datebase = new List<Car>();
            var firstCar = new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 };
            var secondCar = new Car { Id = 2, Make = "Moskvich", Model = "12-tak", Year = 1980 };
            var thirdCar = new Car { Id = 3, Make = "Lada", Model = "7-marka", Year = 1991 };
            datebase.Add(firstCar);
            datebase.Add(secondCar);
            datebase.Add(thirdCar);

            var mock = new Mock<IDatabase>();
            mock.Setup(m => m.Cars).Returns(datebase);
            var fakeDB = mock.Object;
            var carsRepository = new CarsRepository(fakeDB);

            // Act
            var sortedListByMake = carsRepository.SortedByMake();
            var expected = "Audi";

            // Assert
            Assert.AreEqual(expected, (sortedListByMake.First()).Make);
        }

        [Test]
        public void SortedByYear_ShouldReturnSortedListOfCarsByYear()
        {
            // Arrange
            var datebase = new List<Car>();
            var firstCar = new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 };
            var secondCar = new Car { Id = 2, Make = "Moskvich", Model = "12-tak", Year = 1980 };
            var thirdCar = new Car { Id = 3, Make = "Lada", Model = "7-marka", Year = 1991 };
            datebase.Add(firstCar);
            datebase.Add(secondCar);
            datebase.Add(thirdCar);

            var mock = new Mock<IDatabase>();
            mock.Setup(m => m.Cars).Returns(datebase);
            var fakeDB = mock.Object;
            var carsRepository = new CarsRepository(fakeDB);

            // Act
            var sortedListByYear = carsRepository.SortedByYear();
            var expected = 2005;

            // Assert
            Assert.AreEqual(expected, (sortedListByYear.First()).Year);
        }

        [Test]
        public void Search_ShouldReturnCarByGivenString()
        {
            // Arrange
            var datebase = new List<Car>();
            var firstCar = new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 };
            datebase.Add(firstCar);
            var mock = new Mock<IDatabase>();
            mock.Setup(m => m.Cars).Returns(datebase);
            var fakeDB = mock.Object;
            var carsRepository = new CarsRepository(fakeDB);

            // Act
            var result = carsRepository.Search("Audi");

            // Assert
            mock.Verify(m => m.Cars, Times.Exactly(1));
        }

        [Test]
        public void Search_ShouldReturnListOfAllCars_IfStringIsNullOrEmpty()
        {
            // Arrange
            var datebase = new List<Car>();
            var firstCar = new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 };
            var secondCar = new Car { Id = 2, Make = "Moskvich", Model = "12-tak", Year = 1980 };
            datebase.Add(firstCar);
            datebase.Add(secondCar);
            var mock = new Mock<IDatabase>();
            mock.Setup(m => m.Cars).Returns(datebase);
            var fakeDB = mock.Object;
            var carsRepository = new CarsRepository(fakeDB);

            // Act
            var result = carsRepository.Search("");

            // Assert
            mock.Verify(m => m.Cars, Times.Exactly(1));
        }

        [Test]
        public void Testing_GetterOnClassCarsRepository()
        {
            // Arrange
            var datebase = new List<Car>();
            var firstCar = new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 };
            datebase.Add(firstCar);
            var mock = new Mock<IDatabase>();
            mock.Setup(m => m.Cars).Returns(datebase);
            var fakeDB = mock.Object;
            var carsRepository = new CarsRepository(fakeDB);

            // Act
            var totalCars = carsRepository.TotalCars;
            var expected = 1;

            // Assert
            Assert.AreEqual(expected, totalCars);
        }
    }
}
