using System;
using System.Collections.Generic;
using System.Text;

namespace MPS_Assignment_8.Models
{
    public class PeopleRepo
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public PeopleRepo(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Customer>();
        }

        public void AddNewPerson(string name, string gender, string tshirtsize, string dateoforder, string tshirtcolour, string shippingaddress)
        {
            int result = 0;
            try
            {
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Invalid Name");

                result = conn.Insert(new Customer { Fullname = name, Gender = gender, Tshirtsize = tshirtsize, Dateoforder = dateoforder, Tshirtcolour = tshirtcolour, Shippingaddress = shippingaddress });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }
        }

        public List<Customer> GetAllPeople()
        {
            try
            {
                return conn.Table<Customer>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Customer>();
        }
    }
}
