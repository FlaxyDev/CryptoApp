using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Models
{
    public class Coin
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal PriceUsd { get; set; }
        public decimal MarketCapUsd { get; set; }
        public decimal Volume24hUsd { get; set; }
        public decimal PercentChange24h { get; set; }
    }
}
