using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;

namespace Natural_input.Model
{
    public abstract class ContentBase : ViewModelBase
    {
        public ContentType Type { get; set; }
    }
}
