using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class Update : TrackingCategoriesTest
    {
        [Test]
        public void Can_I_update_a_trackingCategory()
        {
            var tracking = Given_a_trackingcategory();

            tracking.Name = "Another Name " + Guid.NewGuid();

            var result = Api.Update(tracking);

            Assert.IsTrue(result.Name == tracking.Name);

            // not working until we can delete tracking categories
        }

    }
}
