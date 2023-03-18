using Contracts.CategoryContracts;
using Microsoft.AspNetCore.Components;
using System.Globalization;

namespace Klavelvet.Client.Shared
{
    public partial class ShopNavMenu
    {
        [Inject]
        public ICategoryService? CategoryService { get; set; }

        private bool collapseNavMenu = true;
        private bool CollpaseNavMenu { get; set; } = true;

        private string? NavMenuCssClass
            => CollpaseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
            => collapseNavMenu = !collapseNavMenu;

        protected override async Task OnInitializedAsync()
        {
            if(CategoryService != null)
            {               
                await CategoryService.GetCategories();
            }            
        }
    }
}
