using Dice.DiceApiModels;
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
    public class DicePostLead
    {
        [Test]
        public void Validate_Dice_Post_Lead_Data_Status_200_Ok()
        {
            var client = new RestClient("http://apidev.bhg-inc.com/");
            var request = new RestRequest("dice/Lead", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new DicePostLeadModel()
            { ResponseType = "",
                channel ="",
                Referral="",
                IntegrationId = 1 ,
                IntegrationKeys="",
                Practitioner ="",
                LeadType ="",
                CreatedBy ="",
                Opportunities ="",
                Id="",
                TransactionId= 111111111,
                UseOfFunds ="",
                AmountRequested =250000
            });

            var response = client.Execute(request);
            JObject result = JObject.Parse(response.Content);

        }

    }
}
