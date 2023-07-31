using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.BL;
using System.IO;
namespace TMS.DL
{
    class CustomerDL
    {
        private static List<Customer> customerList = new List<Customer>();
        internal static List<Customer> CustomerList { get => customerList; set => customerList = value; }
        public static void StoreCustomerDetailToList(Customer customer)
        {
            customerList.Add(customer);
        }
        public static void RemoveFromList(Customer customer)
        {
            customerList.Remove(customer);
        }
        public static void StoreCustomerDetailToFile(Customer customer, string CustomerName)
        {
            string path = "TicketData.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(customer.TrainName + "," + customer.GoingFrom + "," + customer.GoingTo + "," + customer.DepartureTime + "," + customer.TicketType + "," + customer.Fare + "," + customer.CustomerName);

            file.Flush();
            file.Close();
        }
        public static void StoreCustomerDetailAfterUpdate()
        {
            string path = "TicketData.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (var i in customerList)
            {
                file.WriteLine(i.TrainName + "," + i.GoingFrom + "," + i.GoingTo + "," + i.TicketType + "," + i.DepartureTime + "," + i.Fare + "," + i.CustomerName);
            }
        }
        public static void LoadCustomerDataFromFile()
        {
            string path = "TicketData.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)

                {
                    string[] word = record.Split(',');

                    Customer customer = new Customer(word[0], word[1], word[2], DateTime.Parse(word[3]), word[4], float.Parse(word[5]), word[6]);
                    StoreCustomerDetailToList(customer);
                }
                fileVariable.Close();
            }
        }
        public static Customer isValidCustomerName(string CustomerName)
        {
            foreach (var i in customerList)
            {
                if (i.CustomerName == CustomerName)
                {
                    return i;
                }
            }
            return null;
        }
        public static string getTrainNameFromCustomerList(string name)
        {
            foreach (var i in customerList)
            {
                if (name == i.CustomerName)
                {
                    return i.TrainName;
                }
            }
            return null;
        }



    }
}
