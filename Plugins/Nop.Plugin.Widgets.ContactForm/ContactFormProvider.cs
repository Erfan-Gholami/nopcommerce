using System;
using System.Collections.Generic;
using Nop.Core.Domain.Cms;
using Nop.Services.Cms;
using Nop.Services.Common;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.ContactForm
{
    public class ContactFormProvider : BasePlugin, IPlugin, IWidgetPlugin
    {
        private readonly IContactForm _contactForm;
        private readonly WidgetSettings _widgetSettings;
        private readonly ILocalizationService _localrizationService;
        private readonly ISettingService _settingService;

        public ContactFormProvider(IContactForm contactForm, ILocalizationService localizationService, ISettingService settingService, WidgetSettings widgetSettings)
        {
            _contactForm = contactForm;
            _localrizationService = localizationService;
            _settingService = settingService;
            _widgetSettings = widgetSettings;
        }

        public override void Install()
        {
            _localrizationService.AddPluginLocaleResource(new Dictionary<string, string>
            {
                ["Plugins.Widgets.ContactForm.Name"] = "Enter your name",
                ["Plugins.Widgets.ContactForm.Email"] = "Enter your Email",
                ["Plugins.Widgets.ContactForm.Message"] = "Enter your message"
            });
            _settingService.SaveSetting(_widgetSettings);
            base.Install();
        }

        public override void Uninstall()
        {
            _localrizationService.DeletePluginLocaleResources("Plugins.Widgets.ContactForm");

            base.Uninstall();
        }

        public bool HideInWidgetList => false;

        public IList<string> GetWidgetZones()
        {
            var widgetZones = new List<string> { PublicWidgetZones.HeadHtmlTag };
            return widgetZones;
            
        }

        public string GetWidgetViewComponentName(string widgetZone)
        {
            if (widgetZone == null)
                throw new ArgumentNullException(nameof(widgetZone));

            return "test message";

        }

    }
}
