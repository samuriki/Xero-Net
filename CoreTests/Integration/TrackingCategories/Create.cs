using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class Create : TrackingCategoriesTest
    {

        [Test]
        public void Can_I_create_a_trackingCategory()
        {
            var name = Given_a_trackingcategory().Name;

            Assert.IsTrue(name.Contains("Tracking Name"));

            // not working until we can delete tracking categories

        }

    }
}
