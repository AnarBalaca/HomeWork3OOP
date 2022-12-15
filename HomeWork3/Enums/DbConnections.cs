using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Enums
{
    public enum DbConnections : byte
    {
        [Display(Name = "Server=localhost;Database=Sql;Trusted_Connection=true;")]
        Sql,
            [Display(Name = "Server=localhost;Database=MongoDb;Trusted_Connection=true;")]
        Mongodb,
            [Display(Name = "Server=localhost;Database=Oracle;Trusted_Connection=true;")]
        Oracle,

    }
}
