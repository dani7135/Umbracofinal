using Microsoft.VisualStudio.TestTools.UnitTesting;
using Umbracofinal.Services;
using ClassLibrary;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
    private UmbracoContext GetContext()
        {
            var options = new DbContextOptionsBuilder<UmbracoContext>()
                .UseInMemoryDatabase(databaseName: "DummyDB")
                .Options;
            var db = new UmbracoContext(options);
            db.Database.EnsureCreated();
            return db;
        }
        [TestMethod]
        public void GetSerialsNumbers()
        {
            var _db = GetContext();
           // var ser = new ValidateSerialNumber(_db);

        }
    }
}
