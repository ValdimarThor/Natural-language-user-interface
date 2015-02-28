using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natural_input.Model
{
    public class ContentSelection : ContentBase
    {
        private const string selectedItemPropertyName = "SelectedItem";
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
                RaisePropertyChanged(selectedItemPropertyName);
            }
        }

        public IEnumerable<string> Items { get; set; }
    }
}
