namespace CurrenciesTest
{
    public class ExchangeRatesHist
    {
        public string BaseCurrency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Rate> Rates { get; set; }
    }

    public class Rate
    {
        public DateTime Date { get; set; }
        public List<Currency> Values { get; set; }
    }

    public class Currency
    {
        public string Name { get; set; }
        public double Value { get; set; }
    }
}
