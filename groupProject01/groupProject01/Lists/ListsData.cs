using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;

namespace groupProject01
{
    public class ListsData
    {
        public ObservableCollection<ListOfListsObject> lists { get; set; } //declares lists ObservableCollection that will notify when lists are added, removed, and refreshed
        public List<ListItemObject> items { get; set; } //declares listitem ObservableCollection that will notify when items are added, removed, and refreshed

        public ListsData()
        {
            refreshAll();
        }

        public void refreshAll()                                        //refreshes all data on the page
        {
            lists = new ObservableCollection<ListOfListsObject>();         //instantiates lists ObservableCollection that will notify when lists are added, removed, and refreshed


            //HARD-CODED, WILL CHANGE WITH STUFF FROM SERVER
            lists.Add(new ListOfListsObject { Name = "Grocery", ListOfListID = lists.Count });    //adds the grocery list to the page
            lists.Add(new ListOfListsObject { Name = "Shared Items", ListOfListID = lists.Count });                      //adds the shared items list to the page
            lists.Add(new ListOfListsObject { Name = "Chores",ListOfListID = lists.Count });                             //adds the chores list to the page
            lists.Add(new ListOfListsObject { Name = "Repairs",  ListOfListID = lists.Count });                            //adds the repairs list to the page
            lists.Add(new ListOfListsObject { Name = "Other" , ListOfListID = lists.Count });                             //adds the other list to the page
        }

        async public void getItemsInList(GlobalData gd, int ListOfListID)                       //gets all items for a specific list
        {
            //CONNOR QUESTION
            items = await (ServerHandeler.getList(gd, ListOfListID));

            /*items = new ObservableCollection<ListItemObject>();         //instantiates listitem ObservableCollection that will notify when items are added, removed, and refreshed

            //HARD-CODED, WILL CHANGE WITH STUFF FROM SERVER
            items.Add(new ListItemObject { noteName = "Bananas", On = true, ListID = items.Count });            //adds the bananas item to the page
            items.Add(new ListItemObject { noteName = "Apple", On = false, ListID = items.Count });             //adds the apples item to the page
            items.Add(new ListItemObject { noteName = "Orange", On = true, ListID = items.Count });             //adds the orange item to the page
            items.Add(new ListItemObject { noteName = "Guava", On = true, ListID = items.Count });              //adds the guava item to the page
            if (ListID == 1)              //tests if list specific items work
            {
                items.Add(new ListItemObject { noteName = "Custom", On = false, ListID = lists.Count });        //adds specific item for last list
            }*/
        }

        public int addItem()
        {
            throw new NotImplementedException();
        }

        

        public int deleteItem()
        {
            throw new NotImplementedException();
        }
        
        public int deleteList()
        {
            throw new NotImplementedException();
        }

        //****commented out due to time constraints****//
        //public int hidelist()
        //{
        //    throw new notimplementedexception();
        //}

    }


    //dif types of lists
    //0 - notes
    //
    public class ListOfListsObject                      //the object class for the list of lists which allows the user to select which list they would like to view              
    {
        public string Name { get; set; }                //name of the object
        public int ListOfListID { get; set; }                     //unique ListOfListID for the object
        public int Type { get; set; }                   //specifies type of list - toggleable (1) and not toggleable(0)

        ////POSSIBLY GET RID OF
        //public bool On { get; set; }                    //watches value of trigger
        public bool IsSwitchVisible { get; set; }       //watches visibility of trigger
    }


    public class ListItemObject                        //the object class for the items in a certain list                    
    {
        //createList(username, userID, apartmentID, noteName, listType, data, )
        public string noteName { get; set; }                //name of the object
        public int ListID { get; set; }                     //unique ListID for the object
        public bool On { get; set; }                    //watches value of trigger- true or false
        public bool IsSwitchVisible { get; set; }       //watches visibility of trigger
        public int listType { get; set; }                   //specifies type of item- noAdditionalInfo (0) or AdditionalInfo(1)
        public string data { get; set; }
    }
}
