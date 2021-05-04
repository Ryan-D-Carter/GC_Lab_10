using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_10
{
    class Movie
    {
        //fields
        private string title;
        private string category;
        private string index;

        //properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        //constructors
        public Movie()
        {

        }

        public Movie(string _title, string _category, string _index)
        {
            title = _title;
            category = _category;
            index = _index;
        }

        //methods


    }
}
