using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace server
{
    class Program
    {
       static Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            Console.WriteLine("Server starting....");
           
            Console.WriteLine("Waiting for connection");
            bool conNumber;
            conNumber = server.Connected;
            Console.WriteLine(conNumber);
            Console.WriteLine("-----------------------------------------------------------------");
            do{
            Program.Listen();
            }while(server.Accept()!=server.Accept());
            

        }

       static  byte[] buffer = new byte[1024];
       static byte[] buffer1 = new byte[1024];
       static public void Listen()
        {
            
            server.Bind(new IPEndPoint(0, 8000));
            server.Listen(10);
           
            Socket axxept = server.Accept();
            try
            {
                axxept.Receive(buffer,0,buffer.Length,0);
                Console.WriteLine(Encoding.Default.GetString(buffer));
                axxept.Send(buffer1, 0, buffer.Length, 0);
                Console.WriteLine(Encoding.Default.GetString(buffer1));
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            server.Close();
            axxept.Close();
        }
    }
}
