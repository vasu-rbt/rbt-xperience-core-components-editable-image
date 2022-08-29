using CMS;
using Kentico.PageBuilder.Web.Mvc;
using RBT.Xperience.Core.Components;

[assembly: AssemblyDiscoverable]
[assembly: RegisterWidget("RBT.Xperience.Core.Components.EditableImage",
    typeof(EditableImageWidgetViewComponent),
    "Editable Image",
    typeof(EditableImageWidgetProperties),
    Description = "It will render the image which can be seleted from media library and allows editors to add class, alt text, dimensions and redirection link to image.",
    IconClass = "icon-picture")]
