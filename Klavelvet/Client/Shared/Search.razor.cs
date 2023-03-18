using Klavelvet.Client.Services.ProductService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Klavelvet.Client.Shared
{
    public partial class Search
    {
        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private string searchText = string.Empty;
        private List<string> suggestions = new();
        protected ElementReference searchInput;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await searchInput.FocusAsync();
            }
        }

        public void SearchProducts()
        {
            NavigationManager.NavigateTo($"search/{searchText}");
        }

        public async Task HandleSearch(KeyboardEventArgs args)
        {
            if (args.Key == null || args.Key.Equals("Enter"))
            {
                SearchProducts();
            }
            else if (searchText.Length > 1)
            {
                suggestions = await ProductService.GetProductSearchSuggestions(searchText);
            }

        }
    }
}
