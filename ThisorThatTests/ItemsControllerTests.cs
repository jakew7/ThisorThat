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
// models
using ThisorThat.Models;

namespace ThisorThatTests
{
    [TestClass]
    public class ItemsControllerTests
    {
        // Create database to be used in all tests
        private ApplicationDbContext _context;
        ItemsController controller;
        List<Item> items = new List<Item>();

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


            // mock data 3 records
            var listit = new ListIt
            {
                ListItId = 1000,
                Name = "Mock ListIt"
            };
            _context.Lists.Add(listit);

            // first mock record
            items.Add(new Item
            {
                ItemId = 19,
                ItemName = "Water",
                ItemDescription = "It is wet",
                Brand = "Smart",
                ListItId = 1000,
                ListIt = listit
            });

            //second mock record
            items.Add(new Item
            {
                ItemId = 29,
                ItemName = "Soda",
                ItemDescription = "It is Fizzy",
                Brand = "Cola",
                ListItId = 1000,
                ListIt = listit
            });

            // third mock record
            items.Add(new Item
            {
                ItemId = 22,
                ItemName = "Lemonade",
                ItemDescription = "It is sweet",
                Brand = "Royal",
                ListItId = 1000,
                ListIt = listit
            });



            // create controller
            controller = new ItemsController(_context);

        }


        [TestMethod]
        public void IndexLoadsIndexView()
        {
            // act
            var result = (ViewResult)controller.Index().Result;

            // assert
            Assert.AreEqual("Index", result.ViewName);


        }

    }
}
