using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;

namespace Mesh
{
    public partial class AuthorisationForm : Form
    {
        static Socket socket;
        public static List<string> ServerResponces = new List<string>();
        System.Windows.Forms.Timer readerTimer;

        public AuthorisationForm()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // socket.Connect("nodejs.ddns.net", 7510);

            ThreadStart start = new ThreadStart(ReadServer);
            Thread receivingThread = new Thread(start);
            receivingThread.Start();
            readerTimer = new System.Windows.Forms.Timer();
            readerTimer.Tick += ReaderTimer_Tick;
            readerTimer.Start();
        }

        private void ReaderTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (string reply in ServerResponces)
                {
                    ServerResponces.Remove(reply);
                    switch (reply)
                    {
                        case "auth-ok":
                            SignIn();
                            readerTimer.Stop();
                            break;
                    }
                }
            }
            catch
            {

            }
        }

        void ReadServer()
        {
            byte[] buffer = new byte[512];

            while (true)
            {
                if (!socket.Connected)
                    continue;
                int length = socket.Receive(buffer);

                if (length == 0)
                    break;

                string response = Encoding.ASCII.GetString(buffer, 0, length);
                Debug.WriteLine("recieved: " + response);

                string[] cleanResponces = response.Split(new char[] { '\r', '\n' });
                //string cleanResponse = response.Substring(0, response.IndexOf(Environment.NewLine));

                foreach (string cleanResponse in cleanResponces)
                {
                    if (cleanResponse != "")
                    {
                        ServerResponces.Add(cleanResponse);
                    }
                }
            }
        }

        private void SendPing(object sender, EventArgs e)
        {
            SendCommand("ping");
        }

        void SignIn()
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        public static void SendCommand(string command)
        {
            if (socket.Connected)
            {
                command += Environment.NewLine;
                Debug.WriteLine("Send: " + command);
                byte[] buffer = Encoding.ASCII.GetBytes(command);
                socket.Send(buffer);
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (!socket.Connected)
                socket.Connect("nodejs.ddns.net", 7510);
            string username = usernameBox.Text, password = passwordBox.Text;
            // username = "g374-bezugli"; password = "Kb9Ez4"; auth g374-bezugli Kb9Ez4
            string cmd = "auth " + username + " " + password;
            SendCommand(cmd);
        }

        private void AuthorisationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (socket.Connected)
                socket.Disconnect(true);
        }
    }
}
