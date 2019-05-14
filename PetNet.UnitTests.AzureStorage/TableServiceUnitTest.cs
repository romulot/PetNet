using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetNet.AzureStorageAccount;
using PetNet.DataAccess.Entities;

namespace PetNet.UnitTests.AzureStorage
{
    [TestClass]
    public class TableServiceUnitTest
    {
        [TestMethod]
        public void TableStorageTestMethod()
        {
            //Prepare
            var profile = new ProfileAzureTableEntity()
            {
                Id = Guid.NewGuid(),
                Name = "Alexandre",
                Country = "EUA"
            };
            profile.RowKey = profile.Id.ToString();
            profile.PartitionKey = profile.Country;
            var tableService = new TableService<ProfileAzureTableEntity>();

            tableService.AddEntity(profile, "profiles");
            var profiles = tableService.GetAllEntities("profiles", "EUA").ToList();

            Assert.AreEqual(profile.Id, profiles[0].Id);

        }
    }
}
