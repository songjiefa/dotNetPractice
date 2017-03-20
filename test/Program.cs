using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime d1 = DateTime.Now;
			DateTime d2 = DateTime.Now.AddMinutes(1);
			Console.WriteLine(d1);
			Console.WriteLine(d2);

			//testYield().ToList().ForEach(c => Console.WriteLine(c));
			var te = testYield(2);

			var query = te.Where(c => c.Name == "end").FirstOrDefault();

			te = testYield(5);

			query = te.Where(c => c.Name == "end").FirstOrDefault();

			Console.ReadKey();
		}

		static IEnumerable<Person> testYield(int i)
		{
			//int[] arrs = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			//foreach(var arr in arrs)
			//{
			//	yield return arr;
			//}

			Person[] arrs =
			{
				new Person() { Name=i.ToString(),Age=i},
				new Person() { Name=i.ToString(),Age=i},
				new Person() { Name=i.ToString(),Age=i},
				new Person() { Name=i.ToString(),Age=i},
				new Person() {Name="end" ,Age =i }
			};

			foreach (var arr in arrs)
			{
				yield return arr;
			}
		}


	}

	class Person
	{
		private String m_name;
		private Int32 m_age;

		public string Name
		{
			get
			{
				return m_name;
			}

			set
			{
				m_name = value;
			}
		}

		public int Age
		{
			get
			{
				return m_age;
			}

			set
			{
				m_age = value;
			}
		}
	}
}
