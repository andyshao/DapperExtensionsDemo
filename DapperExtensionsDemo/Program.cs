using DapperExtensionsDemo.Entities;
using System.Data.SqlClient;
using DapperExtensions;
using System;

namespace DapperExtensionsDemo
{
    class Program
    {
        private static readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=TestDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        static void Main(string[] args)
        {
            //Insert();
            GetSingle(1);
            GetSingle(2);
            Console.ReadLine();
        }

        private static void Insert()
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                var customer = new Customer { FirstName = "Rector", LastName = "Liu", Active = true, CreatedOn = DateTime.Now };
                cn.Insert(customer);
                Console.WriteLine("Id: {0}", customer.Id);
            }
        }

        private static void GetSingle(int customerId)
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                var customer = cn.Get<Customer>(customerId);
                Console.WriteLine($"Id: {customer.Id}, FirstName: {customer.FirstName}, LastName: {customer.LastName}, Active: {customer.Active}, CreatedOn: {customer.CreatedOn}");
            }
        }
    }
}