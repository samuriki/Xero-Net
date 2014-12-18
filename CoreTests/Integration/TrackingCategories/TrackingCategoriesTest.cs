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
        protected TrackingCategory Given_a_trackingcategory()
        {
            var trackingCategory = new TrackingCategory();

            trackingCategory.Name = "Tracking Name " + Guid.NewGuid();

            return Api.Create(trackingCategory);
        }
    }
}
