using System;
using System.Collections.Generic;
using System.Text;

namespace Natural_input.Model
{
    public class ContentText : ContentBase
    {
        public ContentText()
        {
            Type = ContentType.Text;
        }

        public string Text { get; set; }
    }
}
