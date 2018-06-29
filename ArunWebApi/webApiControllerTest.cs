using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Sql;
using System.Xml;

namespace ArunWebApi
{
    public class webApiControllerTest : ApiController
    {        
        public IEnumerable<string> Get()
        {            
            return new string[] { "value1", "value2" };
        }
        public string Get(int id)
        {            
            XmlDocument datainput =new XmlDocument();
            datainput.LoadXml("~/datainput.xml");
            Dictionary<int, string> dict1 = new Dictionary<int, string>();            
            return "value";
        }

       public void Post(string value)
        {

        }

        public void Put(int id, [FromBody]string value)
        {
        }

        
        public void Delete(int id)
        {
        }
    }
}