using System.ComponentModel.DataAnnotations;

namespace Ftc.Models
{
    public class Event
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "dd/MM/yyyy HH:mm:ss")]
        public DateTime Date{ get; set; }
        public required string Address { get; set; }
    }
}
