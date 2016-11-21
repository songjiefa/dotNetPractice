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
			var timeNow = DateTime.Now;
			var UtcTimeNow = DateTime.Now.ToUniversalTime();
			var localTime = new DateTime(2016, 7, 17, 0, 0, 0, DateTimeKind.Local);
			var utcTime = new DateTime(2016, 7, 17, 0, 0, 0, DateTimeKind.Utc);
			var unspecifiedTime = new DateTime(2016, 7, 17, 0, 0, 0, DateTimeKind.Unspecified);
			var localToUtcTime = new DateTime(2016, 12, 17, 0, 0, 0, DateTimeKind.Local).ToUniversalTime();
			var utcToUtcTime = new DateTime(2016, 7, 17, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime();
			Console.WriteLine("localTime:{0}", localTime);
			Console.WriteLine("utcTime:{0}", utcTime);
			Console.WriteLine("unspecifiedTime:{0}", unspecifiedTime);
			Console.WriteLine("localToUtcTime:{0}", localToUtcTime);
			Console.WriteLine("utcToUtcTime:{0}", utcToUtcTime);
			Console.WriteLine("timeNow:{0}", timeNow);
			Console.WriteLine("UtcTimeNow:{0}", UtcTimeNow);
			Console.ReadKey();
		}
	}
}
