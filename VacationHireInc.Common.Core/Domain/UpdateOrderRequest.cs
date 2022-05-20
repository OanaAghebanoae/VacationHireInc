using VacationHireInc.Data.Models;

namespace VacationHireInc.Core.Domain
{
    public class UpdateOrderRequest
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? RentablePropertyId { get; set; }
        public DateTime? RentStartDate { get; set; }
        public DateTime? RentEndDate { get; set; }
        public bool? DamagePresented { get; set; }
        public string? DamageDetails { get; set; }
        public bool? TankFilledUp { get; set; }
        public decimal? PriceUnit { get; set; }
        public string? PriceCurrency { get; set; }
    }
}
