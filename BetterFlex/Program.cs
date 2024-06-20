using System.Collections.Specialized;

namespace Iteration1
{
    class Student
    {
        string Name { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        public Student(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }
    };

    class functions
    {
       private string[] id;
       private string[] password;
        private Student s1;
       private Student s2;
       private Student s3;
      
       public functions()
        {
            id = new string[] { "22i-1974", "22i-2049", "22i-1989" };
            password = new string[] {"pass1","pass2","pass3" };
            s1 = new Student("Hamza", id[1], "pass");
            s2 = new Student("Ahsan", id[1], "pass");
            s3 = new Student("Hamza", id[2], "pass");
        }

       public bool Checkid(string user, string pass)
        {
            if(user.Length !=8) 
            {
                return false;
            }
            for(int i=0;i<id.Length;i++)
            {
                if (id[i] == user)
                {
                    if (password[i] == pass)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public string Forgot(string user)
        {
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == user)
                    return (password[i]);
            }
            return "na";
        }

    }
    internal static class Program
    {
        [STAThread]

        static void Main()
        {
            string[] id = new string[] { "22i1974", "2", "3" };
            Student s1 = new Student("hamza", "22i1974", "Pass");
            Student s2 = new Student("ahsan", "2", "Pass");
            Student s3 = new Student("awais", "3", "Pass");

            ApplicationConfiguration.Initialize();
            Login f=new Login();
            Application.Run(f);



        }
    }
}