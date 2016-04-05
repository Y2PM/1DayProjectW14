using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOClassLibrary
{
    public class DBAccess
    {
        Entities Context;//Injection.
        public DBAccess(Entities GivenContext)//Construction.
        {
            Context = GivenContext;
        }

        //Maybe make this virtual later to mock test.
        public void addItemtoDB(Basket anItem)//:=Write.
        {
            using (Context)
            {
                Context.Baskets.Add(anItem);
                Context.SaveChanges();
            }
                
        }
    }
}
