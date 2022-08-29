using CMS.MediaLibrary;
using CMS.SiteProvider;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Text;

namespace RBT.Xperience.Core.Components
{
    public class EditableImageWidgetViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ComponentViewModel<EditableImageWidgetProperties> componentViewModel)
        {
            var properties = componentViewModel.Properties;

            if (properties.Image?.Count > 0)
            {
                
                var fileguid = properties.Image.FirstOrDefault()?.FileGuid ?? Guid.Empty;
                var fileInfo = MediaFileInfo.Provider.Get(fileguid, SiteContext.CurrentSiteID);
                string fileURL = MediaFileURLProvider.GetMediaFileUrl(fileInfo.FileGUID, fileInfo.FileName) ?? string.Empty;
                return View("~/Components/Widgets/EditableImageWidget/_EditableImageWidget.cshtml", new EditableImageWidgetViewModel()
                {
                    ImageURL = fileURL,
                    AlternateText = properties?.AlternateText,
                    ImageCSSClass = properties.ImagClass,
                    RenderAsLink = properties.ShowImageAsLink,
                    RedirectionURL = properties.RedirectionURL,
                    LinkCSSClass = properties.LinkClass,
                });
            }
            else
            {
                return View("~/Components/Widgets/EditableImageWidget/_EditableImageWidget.cshtml", new EditableImageWidgetViewModel());
            }
        }
    }
}