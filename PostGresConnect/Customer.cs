using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace PostGresConnect
{
    [Table(Name = "customer")]
    public class customer
    {
        [Column(Name ="id")]
        public int id { get; set; }

        [Column(Name = "firstname")]
        public string firstname { get; set; }

        [Column(Name = "lastname")]
        public string lastname { get; set; }

        [Column(Name = "address")]
        public string address { get; set; }

    }
}
