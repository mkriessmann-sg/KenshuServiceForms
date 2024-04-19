using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KenshuServiceDatabaseLibrary
{
    public class KenshuDBHandler
    {
        private readonly ModelContext context;

        public KenshuDBHandler()
        {
            context = new ModelContext();
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

        public List<T_Charge> GetCharges()
        {
            return context.Charges.ToList();
        }

        public object SearchObjectInTableByID(int id, string table_name)
        {
            if (table_name == "Members")
            {
                return context.Members.FirstOrDefault(x => x.member_id == id);

            }
            else if (table_name == "Charges")
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
                T_Member memberToUpdate = context.Members.FirstOrDefault(m => m.member_id == member.member_id);
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
            else if (table_name == "Charges")
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
            else if (table_name == "Charges")
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
                    query = query.Where(m => m.name.ToLower().Contains(name.ToLower())) ;
                }

                if (email != null)
                {
                    query = query.Where(m => m.mail.ToLower().Contains(email.ToLower()));
                }
                return query.ToList();
            }
            return null;

        }
        //TODO:Atomawashi
        public void CreateBillingDetails(T_Billing_Detail_Data _Billing_Detail_Data)
        {
            context.Billing_Data_Detail.Add(_Billing_Detail_Data);
        }
        //TODO:Atomawashi
        public void CreateBillingData(T_Billing_Data _Billing_Data)
        {
            context.Billing_Data.Add(_Billing_Data);
        }
        //TODO:Atomawashi
        public void CreateBillingStatus(T_Billing_Status _Billing_Status)
        {
            context.Billing_Status.Add(_Billing_Status);
        }

        public List<T_Billing_Status> GetT_Billing_Statuses(DateOnly _requestedDate) 
        {
            if (context.Billing_Status != null)
            {
                IQueryable<T_Billing_Status> query = context.Billing_Status.AsQueryable();


                if (_requestedDate != null)
                {
                    query = query.Where(m => m.billing_ym == _requestedDate);
                }
                return query.ToList();
            }
            return null;
        }

        //Shelved approach
        //public List<T_Billing_Status> GetT_Billing_Data(DateOnly _requestedDate)
        //{
        //    if (context.Billing_Status != null)
        //    {
        //        IQueryable<T_Billing_Status> query = context.Billing_Status.AsQueryable();


        //        if (_requestedDate != null)
        //        {
        //            query = query.Where(m => m.billing_ym == _requestedDate);
        //        }
        //        return query.ToList();
        //    }
        //    return null;
        //}

        //Less flexible but faster approach
        public void DeleteDesignatedDateData( DateOnly _requestedDate)
        {
            if (context.Billing_Data != null)
            {
                IQueryable<T_Billing_Data> query = context.Billing_Data.AsQueryable();


                if (_requestedDate != null)
                {
                    query = query.Where(m => m.billing_ym == _requestedDate);
                    if (query != null)
                    {
                        foreach (T_Billing_Data b in query)
                        {
                            var datatodelete = b as T_Billing_Data;
                            context.Billing_Data.Remove(datatodelete);
                        }
                    }
                   
                }                
            }
            if (context.Billing_Data_Detail != null)
            {
                IQueryable<T_Billing_Detail_Data> query = context.Billing_Data_Detail.AsQueryable();


                if (_requestedDate != null)
                {
                    query = query.Where(m => m.billing_ym == _requestedDate);
                    if (query != null)
                    {
                        foreach (T_Billing_Detail_Data b in query)
                        {
                            var datatodelete = b ;
                            context.Billing_Data_Detail.Remove(datatodelete);
                        }
                    }

                }
            }
            if (context.Billing_Data_Detail != null)
            {
                IQueryable<T_Billing_Status> query = context.Billing_Status.AsQueryable();


                if (_requestedDate != null)
                {
                    query = query.Where(m => m.billing_ym == _requestedDate);
                    if (query != null)
                    {
                        foreach (T_Billing_Status b in query)
                        {
                            var datatodelete = b;
                            context.Billing_Status.Remove(datatodelete);
                        }
                    }

                }
            }
        }

        public List<T_Member> GetMembersByDate(DateOnly startDate, DateOnly endDate)
        {

            IQueryable<T_Member> query = context.Members.AsQueryable();


            if (startDate != null && endDate != null)
            {
                query = query.Where(m => (m.start_date < endDate && (m.end_date >= startDate || !m.end_date.HasValue)));

                //disfuctional inverted query
                //query = query.Where(m => (m.start_date < startDate || m.end_date < startDate) && (m.start_date > endDate || m.end_date > endDate) && (m.start_date > endDate || !m.end_date.HasValue));
            }
            return query.ToList();
        }
        public List<T_Charge> GetChargesByDate(DateOnly startDate, DateOnly endDate)
        {

            IQueryable<T_Charge> query = context.Charges.AsQueryable();


            if (startDate != null && endDate != null)
            {
                query = query.Where(m => (m.startDate < endDate && (m.endDate >= startDate ||!m.endDate.HasValue)));
                
                
                //disfunctional inverted query
                //query = query.Where(m => (m.startDate < startDate || m.endDate < startDate) && (m.startDate > endDate || m.endDate > endDate) && (m.startDate > endDate|| !m.endDate.HasValue));
            }
            return query.ToList();
        }

        public void SaveChanges() { context.SaveChanges(); }

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
