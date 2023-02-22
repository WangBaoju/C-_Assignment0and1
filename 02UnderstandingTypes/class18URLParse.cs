using System;
namespace _02UnderstandingTypes
{
	public class class18URLParse
	{
		public class18URLParse()
		{
            Console.WriteLine("Please input a URL:");
            string url = Console.ReadLine();

            int protocolIdx = url.IndexOf("://");

            string protocol = "";
            if(protocolIdx != -1)
            {
                protocol = url.Substring(0, protocolIdx);
                url = url.Substring(protocolIdx + 3);
            }

            int serverIdx = url.IndexOf("/");
            string server = "";
            if(serverIdx!= -1)
            {
                server = url.Substring(0, serverIdx);
                url = url.Substring(serverIdx);
            }

            string resource = "";
            if(url.Length > 1)
            {
                resource = url.Substring(1);
            }

            Console.WriteLine($"[protocol] = {protocol}");
            Console.WriteLine($"[server] = {server}");
            Console.WriteLine($"[resource] = {resource}");
        }
    }
}

