using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP.Documents
{
    public class Book : Document
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public DateTime DatePublished { get; set; }

        public override string GetCardInfo()
        {
            return $"Type: Book, ISBN: {ISBN}, Title: {Title}, Authors: {Authors}, Number Of Pages: {NumberOfPages}, Publisher: {Publisher}, Date Published: {DatePublished.ToShortDateString()}";
        }
    }

}
