using System;

namespace PRACTICALS_OOP
{
    public class Library
    {
        protected string authorName;
        protected string Title;

        public virtual void library_displatInfo()
        {

        }
    }

    public class Book : Library
    {
        public void setBookDetail(string Title, string authorName)
        {
            this.authorName = authorName;
            this.Title = Title;
        }
        public override void library_displatInfo()
        {
            Console.WriteLine("Book Title : " + Title + " Written By:  " + authorName);
        }
    }

    public class Magazine : Library
    {
        public void setMagazineDetail(string Title, string authorName)
        {
            this.authorName = authorName;
            this.Title = Title;
        }
        public override void library_displatInfo()
        {
            Console.WriteLine("Magazine Title : " + Title + " Written By:  " + authorName);
        }
    }
}
