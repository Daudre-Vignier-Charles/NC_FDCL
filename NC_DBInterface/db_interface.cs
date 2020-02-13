using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace NC_DBInterface
{
    public interface DBInterface
    {
        // TODO : Implémentation...
    }

    public class SQLiteDatabase : DBInterface
    {
        private const string db_cs = @"C:\Users\cdaudre-vignier\source\repos\financial_handlers\resources\prealpha.db";
        private SQLiteConnection connection;
        public SQLiteDatabase()
        {
            connection = new SQLiteConnection(db_cs);
            connection.Open();
        }

        
    }
}
