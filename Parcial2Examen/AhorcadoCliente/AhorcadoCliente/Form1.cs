using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace AhorcadoCliente
{
    public partial class Form1 : Form
    {
        string Solicitud = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ahorcado.getInstancia().Iniciar();
            lblResultado.Text = "";
        }
        private void BtnEnviarPalabra_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Ahorcado.getInstancia().BuscarPalabra(txtLetra.Text);
            String Respuesta = EnviarMensaje(Solicitud);
           
            
        }

        private void btnEnviarLetra_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Ahorcado.getInstancia().Buscar(txtLetra.Text[0]);
            switch (Ahorcado.getInstancia().Estado)
            {
                case 0:
                    pbahorcado.Image = null;
                    break;
                case 1:
                    pbahorcado.Image = Image.FromFile("D:\\LaTorre\\ahorcado\\1.png");
                    break;
                case 2:
                    pbahorcado.Image = Image.FromFile("D:\\LaTorre\\ahorcado\\2.png");
                    break;
                case 3:
                    pbahorcado.Image = Image.FromFile("D:\\LaTorre\\ahorcado\\3.png");
                    break;
                case 4:
                    pbahorcado.Image = Image.FromFile("D:\\LaTorre\\ahorcado\\4.png");
                    break;
                case 5:
                    pbahorcado.Image = Image.FromFile("D:\\LaTorre\\ahorcado\\5.png");
                    break;
                case 6:
                    pbahorcado.Image = Image.FromFile("D:\\LaTorre\\ahorcado\\6.png");
                    break;
                case 7:
                    pbahorcado.Image = Image.FromFile("D:\\LaTorre\\ahorcado\\7.png");
                    break;
                case 8:
                    pbahorcado.Image = Image.FromFile("D:\\LaTorre\\ahorcado\\8.png");
                    MessageBox.Show("Ha perdiod");

                    break;
            }

            
        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {
            txtPalabra.Text = "";
            
        }

        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {
            txtLetra.Text = "";
            
        }
        private String EnviarMensaje(String Mensaje)
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
                  
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    
                    sender.Connect(remoteEP);
                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(Mensaje);
                    // aqui se manda el mensaje
                    int bytesSent = sender.Send(msg);
                     

                    int bytesRec = sender.Receive(bytes);


                    String Respuesta = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                    return Respuesta;
                     
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error no manejado  : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return null;

        }
    }
}
