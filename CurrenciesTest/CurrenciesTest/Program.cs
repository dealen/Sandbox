// See https://aka.ms/new-console-template for more information
using CurrenciesTest;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text.Json;

Console.WriteLine("Hello, World!");

var caller = new Caller();
await caller.GetCurrenciesForGivenCountry();


Console.WriteLine("done");


public class Caller
{
    private HttpClient _client;
    private ExchangeRatesHist _histData;

    public Caller()
    {
        _client = new HttpClient();
        _client.BaseAddress = new Uri("https://api.exchangerate.host/");
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task GetCurrenciesForGivenCountry()
    {
        var apiCall = "timeseries?start_date=2015-01-01&end_date=2022-07-09&base=PLN&symbols=USD,EUR,CZK,NOK";
        _histData = new ExchangeRatesHist();
        try
        {
            HttpResponseMessage response = await _client.GetAsync(apiCall);

            if (response.IsSuccessStatusCode)
            {
                var dataObjects = await response.Content.ReadAsStringAsync();

                var json = JsonConvert.DeserializeObject<JToken>(dataObjects);

                var start_date = json["start_date"].Value<string>();
                _histData.StartDate = DateTime.Parse(start_date);
                var end_date = json["end_date"].Value<string>();
                _histData.EndDate = DateTime.Parse(end_date);
                var _base = json["base"].Value<string>();
                _histData.BaseCurrency = _base;

                var rates = json["rates"]; //contains 5

                _histData.Rates = new List<Rate>();
                foreach (JProperty item in rates)
                {
                    var rate = new Rate
                    {
                        Date = DateTime.Parse(item.Name)
                    };

                    rate.Values = new List<Currency>();

                    foreach (JProperty currency in item.Values())
                    {
                        rate.Values.Add(new Currency { Name = currency.Name, Value = (double)currency.Value });
                    }
                    _histData.Rates.Add(rate);
                }
            }
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}

