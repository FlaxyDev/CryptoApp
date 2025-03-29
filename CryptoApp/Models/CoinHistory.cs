using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Models
{
    public class CoinHistory
    {
        public DateTime TimeStamp { get; set; }    
        public decimal PriceUsd { get; set; }       
        public decimal MarketCapUsd { get; set; }   
        public decimal TotalVolumeUsd { get; set; } 
    }
}
