using System;
using System.Linq;
using Xero.Api.Example.TokenStores;
using Xero.Api.Infrastructure.OAuth;

namespace Xero.Api.Example.WebSite
{
    public partial class Example : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
        {
           var user = new ApiUser { Name = Environment.MachineName };
           var tokenStore = new MemoryTokenStore();

            var api = new Applications.Public.Core(tokenStore,user)
            {
                UserAgent = "Xero Api WebSite - Files Example"
            };

           
            Response.Write("Your organisation is called " + api.Organisation.LegalName);
            
            Response.Write("</br>");

            Response.Write("Your files is count " + api.Files.Find().Count() );

            Response.Write("</br>");

           Response.Write("Your tokens " + tokenStore.Find("stuff"));


        }
    }
}