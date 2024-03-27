
using System.Collections;
using System.Collections.Generic;

public class LibraryItem
    {
        private string _itemname;
        public string ItemName { get { return _itemname; } set { _itemname = value; } }
        public bool Avalible;
    }

class LibraryItems
{
    public List<LibraryItem> LibraryItem;
}