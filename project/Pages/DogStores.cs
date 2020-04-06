using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace project.Pages
{
    class DogStores
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string img { get; set; }

        public class GroupedByStores : ObservableCollection<DogStores>
        {
            public string Title { get; set; }

        }
    }
}
