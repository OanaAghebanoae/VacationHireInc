using System.ComponentModel.DataAnnotations;

namespace VacationHireInc.Data.Models
{
    public class LookupType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
