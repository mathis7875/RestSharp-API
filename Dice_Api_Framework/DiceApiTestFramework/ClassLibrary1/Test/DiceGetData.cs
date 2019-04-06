using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    [TestFixture]
    public class DiceGetData
    {
      
       //[SetUp]
       // public void setup()
       // {
       //     var client = new RestClient("");

       // }

        [Test]
        public void Validate_Dice_Get_Data_Call_Status_200_OK()
        {
            //TODO Aks HAL about the Content
            var client = new RestClient("http://apidev.bhg-inc.com/");
            var request = new RestRequest("dice/Data", Method.GET);
            request.AddUrlSegment("UseOfFunds",1);

            var response = client.Execute(request);
            JObject result = JObject.Parse(response.Content);
            Assert.That(result["StatusCode"].ToString(), Is.EqualTo("200"), "Invalid Response");
        }

        [Test]
        public void Validate_Dice_Data_Get_Call_Json_Reponse()
        {
            //TODO Aks HAL about the Content
            var client = new RestClient("http://apidev.bhg-inc.com/");
            var request = new RestRequest("dice/Data", Method.GET);
            request.AddUrlSegment("StatusCode",0);

            var response = client.Execute(request);
            JObject result = JObject.Parse(response.Content);
            Assert.That(result["StatusCode"].ToString(), Is.EqualTo("404"), "Invalid test");
        }
    }
}
