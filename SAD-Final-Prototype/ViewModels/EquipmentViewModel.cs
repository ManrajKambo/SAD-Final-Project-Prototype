using SAD_Final_Prototype.Models;
using SAD_Final_Prototype.Code;

namespace SAD_Final_Prototype.ViewModels
{
    public class EquipmentViewModel : BaseViewModel<Equipment>
    {
        public EquipmentViewModel(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}