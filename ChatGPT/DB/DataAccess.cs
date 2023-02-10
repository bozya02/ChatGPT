using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ChatGPT.DB
{
    public class DataAccess
    {
        public delegate void AddNewItem();
        public static AddNewItem AddNewItemEvent;

        public static List<Employee> GetEmployees() => ChatGPTEntities.GetContext().Employees.ToList();
        public static List<Chatroom> GetChatrooms() => ChatGPTEntities.GetContext().Chatrooms.ToList();
        public static List<Department> GetDepartments() => ChatGPTEntities.GetContext().Departments.ToList();

        public static Employee Login(string username, string password)
        {
            string hashPassword = StringToMD5(password);
            return GetEmployees().FirstOrDefault(x => x.Username == username && x.Password == hashPassword);
        }

        private static string StringToMD5(string password)
        {
            StringBuilder sb = new StringBuilder();
            var md5 = MD5.Create();

            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            foreach (var b in hash)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        public static void SaveChatroom(Chatroom chatroom)
        {
            if (chatroom.Id == 0)
                ChatGPTEntities.GetContext().Chatrooms.Add(chatroom);

            ChatGPTEntities.GetContext().SaveChanges();
        }
    }
}
