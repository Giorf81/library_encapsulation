namespace library_encapsulation
{
    internal class User
    {
        private int age;
        private string Login;
        private string Email;

        public string ChecksLog
        {
            get
            {
                return Login;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("login must have more than 3 symbols");
                }
                else
                {
                    Login = value;
                }
            }
        }
        public string ChecksEm
        {
            get { return Email; }
            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Ошибка ввода почты");
                }
                else
                    Email = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }
        
    }
}
