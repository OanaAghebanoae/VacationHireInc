using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacationHireInc.Data.Models
{
    public class RentableProperty
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("LookupType")]
        public int TypeId { get; set; }

        public LookupType Type { get; set; }
    }
}
