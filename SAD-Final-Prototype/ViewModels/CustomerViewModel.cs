using SAD_Final_Prototype.Models;
using SAD_Final_Prototype.Code;

namespace SAD_Final_Prototype.ViewModels
{
    public class CustomerViewModel : BaseViewModel<Customer>
    {
        public CustomerViewModel(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}