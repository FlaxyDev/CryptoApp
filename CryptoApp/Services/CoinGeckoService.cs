using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using CryptoApp.Models;
using Newtonsoft.Json;

namespace CryptoApp.Services
{
    public class  CoinGeckoService
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://api.coingecko.com/api/v3/";

        public CoinGeckoService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Coin>> GetTopCoins(int topN = 10)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}coins/markets?vs_currency=usd&order=market_cap_desc&per_page={topN}&page=1"))
            {
                request.Headers.Add("User-Agent", "CryptoApp/1.0"); 

                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode(); 

                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Coin>>(json);
            }
        }

        public async Task<Coin> GetCoinDetails(string coinId)
        {
            var response = await _httpClient.GetStringAsync($"{ApiUrl}coins/{coinId}");
            return JsonConvert.DeserializeObject<Coin>(response);
        }

        public async Task<List<CoinHistory>> GetCoinHistory(string coinId)
        {
            var response = await _httpClient.GetStringAsync($"{ApiUrl}coins/{coinId}/market_chart?vs_currency=usd&days=30");
            return JsonConvert.DeserializeObject<List<CoinHistory>>(response);
        }
    }
}
