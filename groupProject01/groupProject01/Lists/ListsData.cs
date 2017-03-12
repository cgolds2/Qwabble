using System;
using System.Collections.Generic;
using System.Text;

namespace groupProject01
{
    class ListsData
    {

        /// <summary>
        /// This is the base class, not to be instanciated explictly
        /// </summary>
         public class ListsBase
        {
            protected ListsBase()
            {
                throw new NotImplementedException();
            }
            public int add()
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
    }
   

   
}
