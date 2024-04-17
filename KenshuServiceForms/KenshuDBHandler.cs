using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KenshuServiceForms
{
    internal class KenshuDBHandler
    {
        private readonly ModelContext context;

        public KenshuDBHandler()
        {

        }

        public void CreateNewMemberEntry(T_Member t_Member)
        {
            context.Members.Add(t_Member);
            context.SaveChanges();

        }


        public void CreateNewChargeEntry(T_Charge t_charge)
        {
            context.Charges.Add(t_charge);
            context.SaveChanges();
        }


        public object SearchObjectInTableByID(int id, string table_name)
        {
            if (table_name == "Members")
            {
                return context.Members.FirstOrDefault(x => x.member_id == id);

            }
            else if (table_name == "Charge")
            {
                return context.Charges.FirstOrDefault(x => x.charge_id == id);

            }
            else
            {
                return null;
            }

        }


        public void UpdateEntryInTable(object entry, string table_name)
        {
            if (table_name == "Members")
            {
                T_Member member = (T_Member)entry;
                context.Members.FirstOrDefault(x => x.member_id == member.member_id);
                var memberToUpdate = context.Members.FirstOrDefault(m => m.member_id == member.member_id);
                if (memberToUpdate != null)
                {
                    memberToUpdate.name = member.name;
                    memberToUpdate.mail = member.mail;
                    memberToUpdate.start_date = member.start_date;
                    memberToUpdate.end_date = member.end_date;
                    memberToUpdate.address = member.address;
                    memberToUpdate.payment_method = member.payment_method;

                    context.SaveChanges();
                }
            }
            else if (table_name == "Charge")
            {
                T_Charge charge = (T_Charge)entry;
                context.Charges.FirstOrDefault(x => x.charge_id == charge.charge_id);
                var chargeToUpdate = context.Charges.FirstOrDefault(m => m.charge_id == charge.charge_id);
                if (chargeToUpdate != null)
                {
                    chargeToUpdate.charge_name = charge.charge_name;
                    chargeToUpdate.amount = charge.amount;
                    chargeToUpdate.startDate = charge.startDate;
                    chargeToUpdate.endDate = charge.endDate;
                    context.SaveChanges();
                }
            }
            else
            {
                //TODO:throw potential exeption 
            }


        }

        public void DeleteEntryInTable(int id, string table_name)
        {
            if (table_name == "Members")
            {
                var memberToRemove = context.Members.FirstOrDefault(m => m.member_id == id);
                if (memberToRemove != null)
                {
                    context.Members.Remove(memberToRemove);
                    context.SaveChanges();
                }
            }
            else if (table_name == "Charge")
            {

                var chargeToUpdate = context.Charges.FirstOrDefault(m => m.charge_id == id);
                if (chargeToUpdate != null)
                {
                    context.Charges.Remove(chargeToUpdate);
                    context.SaveChanges();
                }
            }
            else
            {
                //TODO:throw potential exeption 
            }
        }

        public List<T_Member> SearchInMembers(string name, string email)
        {
            if (context.Members != null)
            {
                IQueryable<T_Member> query = context.Members.AsQueryable();


                if (name != null)
                {
                    query = query.Where(m => m.name.Contains(name));
                }

                if (email != null)
                {
                    query = query.Where(m => m.mail.Contains(email));
                }
                return query.ToList();
            }
            return null;

        }
        //TODO:Atomawashi
        public void CreateBillingDetails()
        {

        }
        //TODO:Atomawashi
        public void CreateBillingData()
        {

        }
        //TODO:Atomawashi
        public void CreateBillingStatus()
        {

        }

        public int? GetHighestIndex(string table)
        {
            switch (table)
            {
                case "Members":
                    return context.Members.Any() ? context.Members.Max(p => p.member_id) : 0;
                case "Charges":
                    return context.Charges.Any() ? context.Charges.Max(p => p.charge_id) : 0;
                default:
                    return null;


            }
        }

    }
}
