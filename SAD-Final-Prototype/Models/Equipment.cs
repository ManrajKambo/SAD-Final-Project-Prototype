using SQLite;

namespace SAD_Final_Prototype.Models
{
    public class Equipment
    {
        [PrimaryKey, AutoIncrement]
        public int EquipmentId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal DailyRentalCost { get; set; }
    }
}