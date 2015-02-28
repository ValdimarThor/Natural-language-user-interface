using Natural_input.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Natural_input
{
    public class MainPageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TextTemplate { get; set; }
        public DataTemplate ContentSelectionTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is ContentText)
            {
                return TextTemplate;
            }
            else if (item is ContentSelection)
            {
                return ContentSelectionTemplate;
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
