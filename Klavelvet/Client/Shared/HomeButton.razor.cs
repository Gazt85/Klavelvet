﻿using Microsoft.AspNetCore.Components;

namespace Klavelvet.Client.Shared
{
    public partial class HomeButton
    {

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private void GoToHome()
        {
            NavigationManager.NavigateTo("");
        }
    }
}
