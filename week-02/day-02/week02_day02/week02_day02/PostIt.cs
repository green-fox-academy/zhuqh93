using System;
using System.Collections.Generic;
using System.Text;

namespace week02_day02
{
    public class PostIt
    {
        private string BackgroundColor = "";
        private string Text = "";
        private string TextColor = "";

        public PostIt(string backgroundColor, string Text, string TextColor)
        {
            this.BackgroundColor = backgroundColor;
            this.Text = backgroundColor;
            this.TextColor = TextColor;
        }

        PostIt postItObj1 = new PostIt("Orange", "Idea 1", "Blue");
        PostIt postItObj2 = new PostIt("Pink", "Awesome", "Black");
        PostIt postItObj3 = new PostIt("Yellow", "Superb!", "Green");
    }

}