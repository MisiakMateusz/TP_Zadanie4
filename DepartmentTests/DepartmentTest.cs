using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadanie_4;
using WarstwaUslug;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DepartmentTests
{
    [TestClass]
    public class DepartmentTest
    {
        [TestMethod]
        public void test()
        {
            DataAdventureWorksDataContext dataContext = new DataAdventureWorksDataContext();
        }

        [TestMethod]
        public void AddDepartmentTest()
        {
            int iloscObiektow = DataRepository.GetAllDepartament().Count();

            Department dp2 = new Department()
            {
                DepartmentID = 0,
                GroupName = "GrupaTestowa1",
                Name = "NazwaTestowa1",
                ModifiedDate = DateTime.Now
            };

          
            DataRepository.CreateDepartament(dp2);
            int iloscObiektow2 = DataRepository.GetAllDepartament().Count();
            Assert.AreNotEqual(iloscObiektow, iloscObiektow2);

        }
    }
}

