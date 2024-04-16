using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KenshuServiceForms.Database
{
    internal class KenshuDBHandler
    {
        private readonly KenshuDBContext context;

        public KenshuDBHandler (KenshuDBContext context)
        {
            this.context = context;
        }
        //TODO: Implement function
        public void CreateNewMemberEntry(T_Member t_Member)
        {
            

        }
        
        //TODO: Implement function
        public void CreateNewChargeEntry(T_Charge t_charge)
        {

        }

        //TODO: Implement function/switch case to go through tables
        public object SearchTableByID(int id, string table_name)
        {

            return null;
        }

        //TODO: Implement function/switch case for tables
        public void UpdateEntryInTable(object entry, string table)
        {

        }

        public void DeleteEntryInTable(int id, string table)
        {

        }
        //TODO: Implement function/switch case for tables
        public List<T_Member> SearchInMembers(string name, string email)
        {
            return new List<T_Member>();
        }
        public void CreateBillingDetails()
        {

        }
        public void CreateBillingData()
        {

        }
        public void CreateBillingStatus() 
        {
        
        }
        //TODO:Implement function
        public int GetHighestIndex(string table) 
        {
        switch (table) {
                case "Members":
                    return 0;
            
            
            }
        
            return 0;
        }
        
    }
}
