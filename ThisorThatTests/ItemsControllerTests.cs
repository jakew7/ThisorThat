// for DbContextBuilder
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                // unique id
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
        }


        [TestMethod]
        public void IndexLoadsIndexView()
        {
            // arrange
            var controller = new ItemsControllerTests();

            // act


            // assert



        }

    }
}
