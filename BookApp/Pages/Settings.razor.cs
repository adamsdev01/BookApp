using BookApp.Models;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;

namespace BookApp.Pages
{
    public partial class Settings
    {
        public Settings()
        {

        }

        public bool WindowVisible { get; set; }

        public void WindowButtonClicked()
        {
            navManager.NavigateTo("/", true);
        }

        SettingsModel settingsModel { get; set; } = new SettingsModel()
        {
            Username = "JaxonWhite",
            Nickname = "Jax",
            Email = "jaxon.white@gmail.com",
            Phone = "(+1) 8373-837-93-02",
            Website = "jxnss.com"
        };

        public EditContext EditContext { get; set; }

        protected override void OnInitialized()
        {
            EditContext = new EditContext(settingsModel);
            base.OnInitialized();
        }
    }
}
