using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;

namespace groupProject01
{
    public class ListsData
    {
        public ObservableCollection<ListsViewModel> lists { get; set; }
        public ObservableCollection<ListsViewModel> items { get; set; }
     

        public ListsData()
        {
            refreshAll();
        }

        public void refreshAll()
        {
            lists = new ObservableCollection<ListsViewModel>();
            
            lists.Add(new ListsViewModel { Name = "Grocery", On = true, ID = lists.Count, IsSwitchVisible = true });
            lists.Add(new ListsViewModel { Name = "Shared Items", On = false, ID = lists.Count });
            lists.Add(new ListsViewModel { Name = "Chores", On = true, ID = lists.Count });
            lists.Add(new ListsViewModel { Name = "Repairs", On = true, ID = lists.Count });
            //throw new NotImplementedException();
        }

        public void getItemsInList(int ListID)
        {
            items = new ObservableCollection<ListsViewModel>();
            items.Add(new ListsViewModel { Name = "Bananas", On = true, ID = items.Count });
            items.Add(new ListsViewModel { Name = "Apple", On = false, ID = items.Count });
            items.Add(new ListsViewModel { Name = "Orange", On = true, ID = items.Count });
            items.Add(new ListsViewModel { Name = "Guava", On = true, ID = items.Count });
            if(ListID == 1)
            {
                items.Add(new ListsViewModel { Name = "Custom", On = false, ID = lists.Count });

            }
        }

        public void refreshLists()
        {
            throw new NotImplementedException();
        }

        public void editItem()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This allows the user to add lists. 
        /// </summary>
        public int addList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This allows the user to hide lists. Only allowed on public lists.
        /// </summary>
        public int hideList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This allows the user to delete lists. Only allowed on private lists.
        /// </summary>
        public int deleteList()
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// This is the base class, not to be instanciated explictly
    /// </summary>
    public class ListsBase
    {
        protected ListsBase()
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// This is the Grocery List class.
    /// </summary>
    public class GroceryList : ListsBase
    {
        
        public GroceryList()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// assigns the roommate responsible for buying the item
        /// </summary>
        public void setBuyer()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// This is the Chores List class.
    /// </summary>
    class ChoresList : ListsBase
    {
        ChoresList()
        {
            throw new NotImplementedException();
        }

        //assign method? -> would that be in base list?
    }


    /// <summary>
    /// This is the repairs list class.
    /// </summary>
    class RepairsList : ListsBase
    {
        RepairsList()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// This is the Shared Items list class.
    /// </summary>
    class SharedItemsList : ListsBase
    {
        /// <summary>
        /// This creates a new shared items list.
        /// </summary>
        SharedItemsList()
        {
            throw new NotImplementedException();
        }

    }
    public class ListsViewModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool On { get; set; }
        public bool IsSwitchVisible { get; set; }
    }
}
