using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natural_input.Model
{
    public class ContentSelection : ContentBase
    {
        public const string SelectedItemPropertyName = "SelectedItem";

        private string selectedItem = string.Empty;

        public string SelectedItem
        {
            get
            {
                return selectedItem;
            }

            set
            {
                if (selectedItem == value)
                {
                    return;
                }

                selectedItem = value;
                RaisePropertyChanged(SelectedItemPropertyName);
            }
        }

        public IEnumerable<string> Items { get; set; }
    }
}
