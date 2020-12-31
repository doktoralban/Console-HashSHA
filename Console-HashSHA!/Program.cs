using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Console_HashSHA_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HashSHA1("Hello World!"));//2EF7BDE608CE5404E97D5F042F95F89F1C232871
			Console.ReadKey();
        } 
		public static string HashSHA1(string value)
		{
			return string.Join("", (new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(value))).Select(x => x.ToString("X2")).ToArray());
  
		}

		#region"way 1 "
		//Console.WriteLine(HashSHA1("Hello World!"));//2EF7BDE608CE5404E97D5F042F95F89F1C232871

		//var sha1 = SHA1.Create();
		//var inputBytes = Encoding.ASCII.GetBytes(value);
		//var hash = sha1.ComputeHash(inputBytes);
		//var sb = new StringBuilder();
		//for (var i = 0; i < hash.Length; i++)
		//{
		//	sb.Append(hash[i].ToString("X2"));//X2 = upper, x2= lower case return
		//	//"X2" indicates the string should be formatted in Hexadecimal.
		//}
		//return sb.ToString();
		#endregion


		#region"way  2 "
		//Console.WriteLine(HashSHA1("Hello World!"));//2E-F7-BD-E6-08-CE-54-04-E9-7D-5F-04-2F-95-F8-9F-1C-23-28-71
		//	using (var sha1 = new SHA1Managed())
		//	{
		//		return BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(value)));
		//	}

		#endregion


		#region"way  3 "
		//Console.WriteLine(HashSHA1("Hello World!"));//2EF7BDE608CE5404E97D5F042F95F89F1C232871
		//return string.Join("", (new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(value))).Select(x => x.ToString("X2")).ToArray());

		#endregion "


	}
}
