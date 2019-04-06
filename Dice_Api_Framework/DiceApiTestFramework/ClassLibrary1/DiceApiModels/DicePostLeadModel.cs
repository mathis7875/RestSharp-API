using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.DiceApiModels
{
    public class DicePostLeadModel
    {
        public string ResponseType { get; set; }
        public string channel { get; set; }
        public string Referral { get; set; }
        public int IntegrationId { get; set; }
        public string IntegrationKeys { get; set; }
        public string Practitioner { get; set; }
        public string LeadType { get; set; }
        public string CreatedBy { get; set; }
        public string Opportunities { get; set; }
        public string Id { get; set; }
        public int TransactionId { get; set; }
        public string UseOfFunds { get; set; }
        public int AmountRequested { get; set; }
    }
}
