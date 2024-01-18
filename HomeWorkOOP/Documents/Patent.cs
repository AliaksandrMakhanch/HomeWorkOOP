using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP.Documents
{
    public class Patent : Document
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string UniqueId { get; set; }

        public override string GetCardInfo()
        {
            return $"Type: Patent, Title: {Title}, Authors: {Authors}, Date Published: {DatePublished.ToShortDateString()}, Expiration Date: {ExpirationDate.ToShortDateString()}, Unique ID: {UniqueId}";
        }
    }
}
