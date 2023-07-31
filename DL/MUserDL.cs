using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.BL;
using System.IO;
using System.Windows.Forms;
namespace TMS.DL
{
    class MUserDL
    {
        public static List<MUser> mUsersList = new List<MUser>();
        public static List<MUser> getList {get => mUsersList; set => mUsersList = value; }
      

        public static void AddIntoList(MUser mUser)
        {
            mUsersList.Add(mUser);
        }
        public static void DeleteFromList(MUser user)
        {
            mUsersList.Remove(user);
        }
        public static MUser SignIn(MUser user)
        {
            foreach (MUser storedUser in mUsersList)
            {
                if (storedUser.UserName == user.UserName && storedUser.Password == user.Password)
                {
                    return storedUser;
                }
            }
            return null;
        }
        public static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }

            }
            return item;
        }
        public static bool readDataFromFile(string path)
        {
            
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path, true);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string userName = ParseData(record, 1);
                    string Password = ParseData(record, 2);
                    string Role = ParseData(record, 3);
                    MUser user = new MUser(userName, Password, Role);
                    AddIntoList(user);
                     MessageBox.Show(userName);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void StoreUserIntoFile(MUser user, string path)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(user.UserName + "," + user.Password + "," + user.Role);
            file.Flush();
            file.Close();
        }
        public static void StoreAllUserIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach(var user in mUsersList)
            {
                file.WriteLine(user.UserName + "," + user.Password + "," + user.Role);
            }
            file.Flush();
            file.Close();
        
        }
        public static MUser isValidLoginData(string name, string password)
        {
            foreach (var i in mUsersList)
            {
                if (i.UserName == name && i.Password == password)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
