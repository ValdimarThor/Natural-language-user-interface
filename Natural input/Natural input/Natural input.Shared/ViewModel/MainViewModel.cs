using GalaSoft.MvvmLight;
using Natural_input.Model;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;

namespace Natural_input.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public const string contentListPropertyName = "ContentList";
        private ObservableCollection<ContentBase> contentList = null;

        public MainViewModel()
        {
            ContentList = new ObservableCollection<ContentBase>();
            LoadData();
        }

        private void LoadData()
        {
            var text = "I would like to see blendrocks focus more on #1 and less on #2";
            var words = text.Split(' ');
            foreach (var word in words)
            {
                if (word.StartsWith("#"))
                {
                    var items = new List<string>();

                    if (word == "#1")
                    {
                        items.Add("controls styling");
                        items.Add("C# code samples");
                        items.Add("complete designs");
                        items.Add("custom animations");
                    }
                    else if (word == "#2")
                    {
                        items.Add("kitty pictures");
                        items.Add("movie quotes");
                        items.Add("gardening tips");
                        items.Add("indoor swim guides");
                    }

                    ContentList.Add(new ContentSelection() { Items = items, SelectedItem = items[0], Type = ContentType.ComboBox });
                }
                else
                {
                    ContentList.Add(new ContentText() { Text = word, Type = ContentType.Text });
                }
            }
        }

        public ObservableCollection<ContentBase> ContentList
        {
            get
            {
                return contentList;
            }

            set
            {
                if (contentList == value)
                {
                    return;
                }

                contentList = value;
                RaisePropertyChanged(contentListPropertyName);
            }
        }
    }
}