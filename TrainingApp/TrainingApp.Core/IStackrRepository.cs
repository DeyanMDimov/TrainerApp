using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingApp.Entities;

namespace TrainingApp.Core
{
    public interface IStackrRepository
    {
        IQueryable<Entry> GetUserEntries(int userId);
        IQueryable<Entry> GetUserEntriesBySupplement(int userId, int supplementId);
        IQueryable<Entry> GetUserEntriesByDateRange(int userId, DateTime startDate, DateTime endDate);


        Entry getUserEntry(int userId, int entryId);

        bool InsertNewEntry(Entry entry);
        bool InsertNewStack(Stack stack);
        bool InsertNewUser(Person user);
        bool InsertNewSupplement(Supplement supplement);

        bool Update(Entry entry);
        bool Update(Stack stack);
        bool Update(Person user);

        bool Delete(Entry entry);
        bool Delete(Stack stack);

    }
}