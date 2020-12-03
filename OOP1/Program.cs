using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
			MyClass instance = new MyClass();
            Console.Write("Enter instance name: ");
			instance.Name = Console.ReadLine();
			Console.WriteLine(instance.Name);
		}
	}

	class MyClass
	{
		private string name;
		public string Name
		{
            get
            {
				if(name == "" || name == null)
                {
					return "Name is not defined";

				}
                else
                {
					return name;
                }
            }
            set
            {
				name = value;
            }
		}

	}
}
