using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http;

namespace Klavelvet.Client.Features
{
    public class UnsuccessfulStatusCodeHandler
    {
        private readonly NavigationManager _navigationManager;

        public UnsuccessfulStatusCodeHandler(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public void HandleStatusCode(HttpResponseMessage response) 
        {
            if (!response.IsSuccessStatusCode)
            {
                var statusCode = response.StatusCode;

                switch (statusCode)
                {                    
                    case HttpStatusCode.NotFound:
                        _navigationManager.NavigateTo("/404");
                        break;

                    case HttpStatusCode.Unauthorized:
                        _navigationManager.NavigateTo("/unauthorized");
                        break;

                    default:
                        _navigationManager.NavigateTo("/error");
                        break;
                }
            }
        }
    }
}
