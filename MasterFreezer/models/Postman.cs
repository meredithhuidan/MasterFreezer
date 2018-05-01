using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFreezer.models
{
    public class Postman
    {

        [SugarColumn(IsPrimaryKey = true, IsIdentity = true,  IsNullable = false)]
        public int Id { get; set;  }

        [SugarColumn(Length =10, IsNullable = true)]
        public string Gender { get; set; }

        [SugarColumn(Length = 20, IsNullable = false)]
        public string Password { get; set; }

        [SugarColumn(Length = 20, IsNullable = false)]
        public string Name { get; set; }

        [SugarColumn(Length = 20, IsNullable = false)]
        public string Phone { get; set; }

        [SugarColumn(Length = 20, IsNullable = true)]
        public string PiCard { get; set; }

        [SugarColumn(Length = 20, IsNullable = true)]
        public string State { get; set; }

        [SugarColumn(Length = 50, IsNullable = true)]
        public string Company { get; set; }

        [SugarColumn(IsNullable = true)]
        public DateTime Create { get; set; }
    }
}
