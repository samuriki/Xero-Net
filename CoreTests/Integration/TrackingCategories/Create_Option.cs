using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class Create_Option : TrackingCategoriesTest
    {
    
        [Test]
        public void Can_create_an_option_to_a_tracking_category()
        {

            Given_a_trackingcategory();

            Given_a_option();


        }

        private Option Given_a_option()
        {

            var option = new Option();

            option.Name = "test option " + Guid.NewGuid();

            return option;
        }
    }
}
