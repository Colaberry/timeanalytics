using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimesheetsWeb;
using TimesheetsWeb.Controllers;
using TimesheetsWeb.Models;
using System.Diagnostics;

namespace TimesheetsWeb.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            OrganizationController controller = new OrganizationController();

            // Act comments
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void About()
        //{
        //    // Arrange
        //    OrganizationController controller = new OrganizationController();

        //    // Act
        //    ViewResult result = controller.About() as ViewResult;

        //    // Assert
        //    Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        //}

        //[TestMethod]
        //public void Contact()
        //{
        //    // Arrange
        //    OrganizationController controller = new OrganizationController();

        //    // Act
        //    ViewResult result = controller.Contact() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        //test for new checking  
        [TestMethod]
        public void AddOrganization()
        {
            using (var db = new TimesheetsWebContext())
            {
                Organization first = new Organization();
                first.OrganizationId = Guid.NewGuid();
                first.Name = "Apple Inc";
                db.Organization.Add(first);
                Console.Write(db.SaveChanges());
            }
        }
    }
}
