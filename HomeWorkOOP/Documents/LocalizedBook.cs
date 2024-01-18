using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP.Documents
{
    public class LocalizedBook : Book
    {
        public string CountryOfLocalization { get; set; }
        public string LocalPublisher { get; set; }

        public override string GetCardInfo()
        {
            return $"{base.GetCardInfo()}, Country Of Localization: {CountryOfLocalization}, Local Publisher: {LocalPublisher}";
        }
    }

}
