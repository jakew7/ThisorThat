// for ViewResult
using Microsoft.AspNetCore.Mvc;
// for DbContextBuilder
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// enables use of controllers from ThisorThat
using ThisorThat.Controllers;
// reference for ApplicationDbContext
using ThisorThat.Data;

namespace ThisorThatTests
{
    [TestClass]
    public class ItemsControllerTests
    {
        // Create database to be used in all tests
        private ApplicationDbContext _context;

        // initializes automatically for global arrangement before every test 
        [TestInitialize]

        public void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                // unique id database
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            // create new database
            _context = new ApplicationDbContext(options);

        }


        [TestMethod]
        public void IndexLoadsIndexView()
        {
            // arrange
            var controller = new ItemsController(_context);

            // act
            var result = (ViewResult)controller.Index().Result;

            // assert
            Assert.AreEqual("Index", result.ViewName);


        }

    }
}
