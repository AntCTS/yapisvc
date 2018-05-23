using System.Runtime.Serialization;

namespace yapisvc.Models
{
    [DataContract(Name = "FormattedStock")]
    public class FormattedStock
    {
        [DataMember(Name="StockCode")]
        public string StockCode
        {
            get;
            set;
        }
    }
}