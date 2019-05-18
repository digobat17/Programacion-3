using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace socketsParcial2
{
    class Program
    {
        //servidor
        private static int Sumatoria(int n)
        {
           
            int suma=0;
            for (int i = 0; i <= n; i++)
            {
                suma = suma + i;
            }
            return suma;
            

        }
          
        public static string data = null;

        public static void StartListening()
        {
             
            byte[] bytes = new Byte[1024];

            
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

              
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Console.WriteLine("Esperando por conexiones ...");
                    Socket handler = listener.Accept();
                    data = null;
                    int bytesRec = handler.Receive(bytes);
                    int n = BitConverter.ToInt32(bytes, 0);
                    Console.WriteLine("Texto recibido: {0}", n);
                    int sum = Sumatoria(n);
                   
                    byte[] msg = Encoding.ASCII.GetBytes(sum.ToString());

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPresione ENTER para continuar...");
            Console.Read();

        }

        public static int Main(String[] args)
        {
            StartListening();
            return 0;
        }
    }
}
