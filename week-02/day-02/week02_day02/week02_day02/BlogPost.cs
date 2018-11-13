using System;
using System.Collections.Generic;
using System.Text;

namespace week02_day02
{
    public class BlogPost
    {
        private string AuthorName = "";
        private string Title = "";
        private string Text = "";
        private string PublicationDate = $"{0:####}.{1:##}.{2:##}.";

        public BlogPost(string Title, string AuthorName,
            string PublicationDate, string Text)
        {
            this.Title = Title;
            this.AuthorName = AuthorName;
            this.PublicationDate = PublicationDate;
            this.Text = Text;
        }

        BlogPost blogPostObj1 = new BlogPost("Lorem Ipsum",
            "John Doe",
            "2000.05.04.",
            "Lorem ipsum dolor sit amet.");
        BlogPost blogPostObj2 = new BlogPost("Wait but why",
            "Tim Urban",
            "2010.10.10.",
            "A popular long-form, stick-figure-illustrated blog about almost everything.");
        BlogPost blogPostObj3 = new BlogPost("One Engineer Is Trying to Get IBM to Reckon With Trump",
            "William Turton",
            "2017.03.28.",
            "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. " +
            "When I asked to take his picture outside one of IBM’s New York City offices, he told me that he " +
            "wasn’t really into the whole organizer profile thing.");
    }
}
