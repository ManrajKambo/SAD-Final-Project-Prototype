using SAD_Final_Prototype.Models;
using SAD_Final_Prototype.Code;

namespace SAD_Final_Prototype.ViewModels
{
    public class CategoryViewModel : BaseViewModel<Category>
    {
        public CategoryViewModel(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}