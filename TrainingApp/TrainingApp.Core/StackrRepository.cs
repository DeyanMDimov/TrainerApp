using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingApp.Entities;

namespace TrainingApp.Core
{
    public class StackrRepository : IStackrRepository
    {
        public IQueryable<Entry> GetUserEntries(int userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entry> GetUserEntriesBySupplement(int userId, int supplementId)
        {
            throw new NotImplementedException();
        }
        public IQueryable<Entry> GetUserEntriesByDateRange(int userId, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }


        public Entry getUserEntry(int userId, int entryId)
        {
            throw new NotImplementedException();
        }

        public bool InsertNewEntry(Entry entry)
        {
            throw new NotImplementedException();
        }
        public bool InsertNewStack(Stack stack)
        {
            throw new NotImplementedException();
        }
        public bool InsertNewUser(Person user)
        {
            throw new NotImplementedException();
        }
        public bool InsertNewSupplement(Supplement supplement)
        {
            throw new NotImplementedException();
        }

        public bool Update(Entry entry)
        {
            throw new NotImplementedException();
        }
        public bool Update(Stack stack)
        {
            throw new NotImplementedException();
        }
        public bool Update(Person user)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Entry entry)
        {
            throw new NotImplementedException();
        }
        public bool Delete(Stack stack)
        {
            throw new NotImplementedException();
        }

    }
}