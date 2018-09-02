using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExists
{
    class DataAccess
    {
        public List<Person> Registraion(string emailAddress)
        {         
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.CnnVal("LawDevDB")))
                {
                    //var output = connection.Query<Person>($"select * from people where LastName = '{ lastName }'").ToList();
                    var output = connection.Query<Person>("dbo.UserExist @EmailAddress", new { EmailAddress = emailAddress }).ToList();
                    return output;
                }

        }
    }
}
