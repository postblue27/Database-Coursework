using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseAche_db
{
    static class CarBuffer
    {
        public static int id;
        public static string mark;
        public static string model;
        public static DateTime releaseDate;
        public static string vinCode;
        public static string engineModel;
        public static string enginePower;
        public static string engineCapacity;
        public static string weight;
        public static string country;
        public static decimal price;
        public static bool IsChanging;
    }
    static class ClientBuffer
    {
        public static int id;
        public static string name;
        public static string sex;
        public static string phoneNumber;
        public static string passport;
        public static DateTime birthDate;
        public static string residence;
        public static string email;
        public static bool IsChanging;
    }
    static class EmployeeBuffer
    {
        public static int id;
        public static string name;
        public static string post;
        public static string phoneNumber;
        public static string passport;
        public static DateTime birthDate;
        public static string residence;
        public static string email;
        public static DateTime StartWorkingDate;
        public static bool IsChanging;
    }
    static class SaleBuffer
    {
        public static int id;
        public static int carId;
        public static int clientId;
        public static int employeeId;
        public static DateTime dateOfSale;
        public static string paymentType;
        public static bool IsChanging;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
