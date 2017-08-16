using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace Exercises_using_Sockets_Client {
    class Program {
        static void Main(string[] args) {

            TcpClient client = new TcpClient("127.0.0.1", 1302);
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());

            Console.WriteLine("Type your message below:");
            while (true) {
                string message = Console.ReadLine();
                sw.WriteLine(message);
                sw.Flush();
                string responce = sr.ReadLine();
                if (responce == "Closing connection") {
                    Environment.Exit(1);
                }
                Console.WriteLine(responce); //print server response
            }
        }
    }
}
