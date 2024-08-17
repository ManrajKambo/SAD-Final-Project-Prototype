using SQLite;

namespace SAD_Final_Prototype.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryId { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}