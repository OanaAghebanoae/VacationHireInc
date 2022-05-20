using VacationHireInc.Data.Models;

namespace VacationHireInc.Core.Domain
{
    public class CreateOrderRequest
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RentablePropertyId { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime? RentEndDate { get; set; }
        public bool DamagePresented { get; set; }
        public string? DamageDetails { get; set; }
        public bool TankFilledUp { get; set; }
        public decimal PriceUnit { get; set; }
        public string? PriceCurrency { get; set; }

        public Order Create()
        {
            return new Order
            {
                CustomerId = CustomerId,
                RentablePropertyId = RentablePropertyId,
                RentStartDate = RentStartDate,
                RentEndDate = RentEndDate,
                DamagePresented = DamagePresented,
                DamageDetails = DamageDetails,
                TankFilledUp = TankFilledUp,
                PriceUnit = PriceUnit,
                PriceCurrency = string.IsNullOrEmpty(PriceCurrency) ? string.Empty : PriceCurrency
            };
        }
    }
}
