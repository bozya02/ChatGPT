using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT.DB
{
    public class DataAccess
    {
        public delegate void AddNewItem();
        public static AddNewItem AddNewItemEvent;

        public static List<Employee> GetEmployees() => ChatGPTEntities.GetContext().Employees.ToList();
        public static List<Chatroom> GetChatrooms() => ChatGPTEntities.GetContext().Chatrooms.ToList();
        public static List<Department> GetDepartments() => ChatGPTEntities.GetContext().Departments.ToList();
    }
}
