﻿using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RBT.Xperience.Core.Components
{
    public class EditableImageWidgetProperties : IWidgetProperties
    {
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 0)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        public IList<MediaFilesSelectorItem> Image { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3)]
        [EditingComponentProperty("Label", "Alternate Text")]
        public string AlternateText { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 4)]
        [EditingComponentProperty("Label", "Image CSS Class")]
        public string ImagClass { get; set; }


        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 5)]
        [EditingComponentProperty("Label", "Render with Link")]
        public bool ShowImageAsLink { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 6)]
        [EditingComponentProperty("Label", "Redirection Link URL")]
        public string RedirectionURL { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 7)]
        [EditingComponentProperty("Label", "Link CSS Class")]
        public string LinkClass { get; set; }

        public EditableImageWidgetProperties()
        {
            
        }
    }
}
