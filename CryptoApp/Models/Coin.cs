using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoApp.Models
{
    public class Coin
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("current_price")]
        public decimal PriceUsd { get; set; }

        [JsonProperty("market_cap")]
        public decimal MarketCapUsd { get; set; }

        [JsonProperty("total_volume")]
        public decimal Volume24hUsd { get; set; }

        [JsonProperty("price_change_percentage_24h")]
        public decimal PercentChange24h { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; } 
    }
}
