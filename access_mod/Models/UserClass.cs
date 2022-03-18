using System;
namespace access_mod.Models
{
    class UserClass
    {
        
        private string _Username;
        private int _Age;
        private object _Password;

        public string username
        {
            get
            {
                return _Username;
            }
            set
            {
                //Console.WriteLine("Enter Your username: ");
                //_Username = Console.ReadLine();
                //Console.WriteLine(_Username);
                _Username = value;
                Console.WriteLine(_Username);

            }

        }
        public int age
        {
            get
            {
                return _Age;
            }
            set
            {
                //Console.WriteLine("Please enter your age");
                //int v = int.Parse(Console.ReadLine());
                //_Age = v;
                
                if (value < 0)
                {
                    Console.WriteLine("age cannot be negative number");
                    return;
                }
                _Age = value;

                Console.WriteLine(_Age);

            }

        }
        public object password
        {
            get
            {
                return _Password;
            }
            set
            {
                string sym = "bukayooooooo";
                for (int i = 0; i < sym.Length; i++)
                {
                    if (sym.Length<8)
                    {
                        Console.WriteLine("Password cannot be less than 8");
                        return;
                    }
                }
                 _Password = value;
                Console.WriteLine(_Password);
            }

        }
        



    }
}
