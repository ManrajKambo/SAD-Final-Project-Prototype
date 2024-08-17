using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SAD_Final_Prototype.Code;

namespace SAD_Final_Prototype.ViewModels
{
    public abstract class BaseViewModel<TModel> where TModel : class, new()
    {
        protected readonly DatabaseContext _dbContext;

        public ObservableCollection<TModel> Items { get; private set; } = new ObservableCollection<TModel>();

        protected BaseViewModel(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task LoadItemsAsync()
        {
            var items = await _dbContext.GetAllAsync<TModel>();
            Items.Clear();
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }

        public async Task AddItemAsync(TModel item)
        {
            await _dbContext.AddItemAsync(item);
            Items.Add(item);
        }

        public async Task RemoveItemAsync(TModel item)
        {
            await _dbContext.DeleteItemAsync(item);
            Items.Remove(item);
        }

        public async Task UpdateItemAsync(TModel item)
        {
            await _dbContext.UpdateItemAsync(item);
        }
    }
}