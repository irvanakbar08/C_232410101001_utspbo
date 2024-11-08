using _1012_Muhammad_Irvan_Akbar_UTS.App.Context;
using _1012_Muhammad_Irvan_Akbar_UTS.Views;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1012_Muhammad_Irvan_Akbar_UTS.App.Core
{
    internal class DatabaseWrapper
    {
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "Inventory_Management";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "12345";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;
    }


    

    
        
}
