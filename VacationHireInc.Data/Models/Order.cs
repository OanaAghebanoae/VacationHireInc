using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacationHireInc.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("RentableProperty")]
        public int RentablePropertyId { get; set; }

        public RentableProperty RentableProperty { get; set; }

        public DateTime? RentStartDate { get; set; }

        public DateTime? RentEndDate { get; set; }

        public bool DamagePresented { get; set; }

        public string DamageDetails { get; set; }

        public bool TankFilledUp { get; set; }

        public decimal PriceUnit { get; set; }

        public string PriceCurrency { get; set; }
    }
}
