namespace VacationHireInc.Core
{
    public interface ICurrencyLayerService
    {
        Task<decimal> Convert(string from, string to, decimal amount);
    }
}
