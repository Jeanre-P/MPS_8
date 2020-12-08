using System;
using System.Collections.Generic;
using System.Text;

namespace MPS_Assignment_8.Models
{
    public class Customer
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100), Unique]
        public string Fullname { get; set; }

        [MaxLength(100), Unique]
        public string Gender { get; set; }

        [MaxLength(100), Unique]
        public string Tshirtsize { get; set; }

        [MaxLength(100), Unique]
        public string Dateoforder { get; set; }

        [MaxLength(100), Unique]
        public string Tshirtcolour { get; set; }

        [MaxLength(100), Unique]
        public string Shippingaddress { get; set; }
    }
}
