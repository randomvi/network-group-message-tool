using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Conector
    {
        public byte[] buffer=new byte[1024];
        public byte[] buffer1 = new byte[1024];

        public string sender(string msg,string name)
        {
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
          
          try
          {
              client.Connect("127.0.0.1", 8000);
             buffer = Encoding.Default.GetBytes(name + " : " + msg);
             client.Send(buffer, 0, buffer.Length, 0);
          }
          catch (Exception)
          {
              global::System.Windows.MessageBox.Show("Something Went Wrong !!! OOps");
          }
          finally
          {
             // client.Receive(buffer1, 0, buffer.Length, 0);
             // ms = Encoding.Default.GetString(buffer1);
          }

          client.Close();
          
          return name+msg;
        }


        public string Refres()
        {
            string ms="";
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //
            client.Connect("127.0.0.1", 8000);
            client.Receive(buffer1, 0, buffer.Length, 0);
            ms = Encoding.Default.GetString(buffer1);
            client.Close();
            return ms;
        }
    }
}
