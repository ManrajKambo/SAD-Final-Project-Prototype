using SAD_Final_Prototype.Models;
using SAD_Final_Prototype.Code;

namespace SAD_Final_Prototype.ViewModels
{
    public class RentalViewModel : BaseViewModel<Rental>
    {
        public RentalViewModel(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}