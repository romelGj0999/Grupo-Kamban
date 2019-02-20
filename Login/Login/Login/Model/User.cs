using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using SQLite;

namespace Login.Model
{
    [SQLite.Net.Attributes.Table("user")]
    public class User
    {
        [SQLite.Net.Attributes.PrimaryKey, SQLite.Net.Attributes.AutoIncrement]
        public int Id { get; set; }

        [SQLite.Net.Attributes.MaxLength(100), SQLite.Net.Attributes.Unique]
        public String Username { get; set; }

        [SQLite.Net.Attributes.MaxLength(100), SQLite.Net.Attributes.Unique]
        public String Email { get; set; }

        [SQLite.Net.Attributes.MaxLength(70), SQLite.Net.Attributes.Unique]
        public String Password{ get; set; }

    }
}
