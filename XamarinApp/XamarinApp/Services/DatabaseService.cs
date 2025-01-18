using System;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinApp.Model;
using System.IO;

namespace XamarinApp.Services
{
	public class DatabaseService
	{
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "app.db");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>().Wait();
        }

        public Task<List<Person>> GetPeopleAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            if (person.Id != 0)
                return _database.UpdateAsync(person);
            else
                return _database.InsertAsync(person);
        }

        public Task<int> DeletePersonAsync(Person person)
        {
            return _database.DeleteAsync(person);
        }

    }
}

