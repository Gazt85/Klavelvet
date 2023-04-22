using Klavelvet.Client.Features;
using Klavelvet.Shared.RequestFeatures;
using Microsoft.AspNetCore.Components;
using Klavelvet.I18N.General;

namespace Klavelvet.Client.Shared
{
    public partial class Pagination
    {
        [Parameter]
        public Metadata Metadata{ get; set; } = new Metadata();

        [Parameter]
        public int Spread { get; set; }

        [Parameter]
        public EventCallback<int> SelectedPage { get; set; }

        private List<PagingLink> _links = new();

        protected override void OnParametersSet()
        {
            CreatePaginationLinks();
        }

        private void CreatePaginationLinks()
        {            
            _links = new()
            {
                new PagingLink(Metadata.CurrentPage - 1, Metadata.HasPrevious,GeneralResources.Previous )
            };

            for(int i = 1; i <= Metadata.TotalPages; i++)
            {
                if(i >= Metadata.CurrentPage - Spread && i <= Metadata.CurrentPage + Spread)
                {
                    _links.Add(new PagingLink(i, true, i.ToString())
                    { Active = Metadata.CurrentPage == i });
                       
                }
            }

            _links.Add(new PagingLink(Metadata.CurrentPage + 1, Metadata.HasNext, GeneralResources.Next));
        }

        private async Task OnSelectedPage(PagingLink link)
        {
            if (link.Page == Metadata.CurrentPage || !link.Enabled)
                return;

            Metadata.CurrentPage = link.Page;

            await SelectedPage.InvokeAsync(link.Page);
        }
    }
}
