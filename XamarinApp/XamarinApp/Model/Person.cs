using System;
using SQLite;

namespace XamarinApp.Model
{
	public class Person
	{
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

