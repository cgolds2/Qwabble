using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;

namespace groupProject01
{
    public class ListsData
    {
        public ObservableCollection<ListsViewModel> lists { get; set; } //declares lists ObservableCollection that will notify when lists are added, removed, and refreshed
        public ObservableCollection<ListsViewModel> items { get; set; } //declares listitem ObservableCollection that will notify when items are added, removed, and refreshed


        public ListsData()
        {
            refreshAll();
        }

        public void refreshAll()                                        //refreshes all data on the page
        {
            lists = new ObservableCollection<ListsViewModel>();         //instantiates lists ObservableCollection that will notify when lists are added, removed, and refreshed


            //HARD-CODED, WILL CHANGE WITH STUFF FROM SERVER
            lists.Add(new ListsViewModel { Name = "Grocery", On = true, ID = lists.Count, IsSwitchVisible = true });    //adds the grocery list to the page
            lists.Add(new ListsViewModel { Name = "Shared Items", On = false, ID = lists.Count });                      //adds the shared items list to the page
            lists.Add(new ListsViewModel { Name = "Chores", On = true, ID = lists.Count });                             //adds the chores list to the page
            lists.Add(new ListsViewModel { Name = "Repairs", On = true, ID = lists.Count });                            //adds the repairs list to the page
        }

        public void getItemsInList(int ListID)                          //gets all items for a specific list
        {
            items = new ObservableCollection<ListsViewModel>();         //instantiates listitem ObservableCollection that will notify when items are added, removed, and refreshed

            //HARD-CODED, WILL CHANGE WITH STUFF FROM SERVER
            items.Add(new ListsViewModel { Name = "Bananas", On = true, ID = items.Count });            //adds the bananas item to the page
            items.Add(new ListsViewModel { Name = "Apple", On = false, ID = items.Count });             //adds the apples item to the page
            items.Add(new ListsViewModel { Name = "Orange", On = true, ID = items.Count });             //adds the orange item to the page
            items.Add(new ListsViewModel { Name = "Guava", On = true, ID = items.Count });              //adds the guava item to the page
            if (ListID == 1)                                                                            //tests if list specific items work
            {
                items.Add(new ListsViewModel { Name = "Custom", On = false, ID = lists.Count });        //adds specific item for last list
            }
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


        //commented out due to time constraints
        /// <summary>
        /// this allows the user to hide lists.only allowed on public lists.
        /// </summary>
        //public int hidelist()
        //{
        //    throw new notimplementedexception();
        //}

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
