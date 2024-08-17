using SQLite;
using System;

namespace SAD_Final_Prototype.Models
{
    public class Rental
    {
        [PrimaryKey, AutoIncrement]
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public int EquipmentId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal RentalCost { get; set; }
    }
}
