using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class TrackingCategoriesTest : ApiWrapperTest
    {
        [Test]
        public void Can_I_create_a_trackingCategory()
        {
            var name = Given_a_trackingcategory().Name;

            Assert.IsTrue(name.Contains("Tracking Name"));

            // not working until we can delete tracking categories

        }

        [Test]
        public void Can_I_update_a_trackingCategory()
        {
           var tracking = Given_a_trackingcategory();

            tracking.Name = "Another Name " + Guid.NewGuid();

            var result= Api.Update(tracking);

            Assert.IsTrue(result.Name == tracking.Name);

            // not working until we can delete tracking categories
        }
        
        private TrackingCategory Given_a_trackingcategory()
        {
            var trackingCategory = new TrackingCategory();

            trackingCategory.Name = "Tracking Name " + Guid.NewGuid();
            
            return Api.Create(trackingCategory);
        }
    }
}
