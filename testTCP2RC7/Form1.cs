using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using Microsoft.VisualBasic;
using System.Drawing.Text;
using System.IO.Pipes;

namespace testTCP2RC7
{
    public partial class Form1 : Form
    {
        // Data From EPson RC7 before parsing data
        string[] DataTemp = new string[10];

        // Data setelah di parsing
        public int posx = 0, posy = 0, posz = 0;

        TcpClient clientsocket = new TcpClient();
        NetworkStream serversteam = default(NetworkStream);
        string readdata = null;

        public readonly static string CrLf = Environment.NewLine;
        public readonly static string Space = " ";
        public readonly static string Comma = ",";
        public readonly static string ZERO = "0";
        public readonly static string NA = "N/A";
        public readonly static string QUOTE = "\"";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_CONNECT_Click(object sender, EventArgs e)
        {
            clientsocket.Connect(TB_IP.Text, Int32.Parse(TB_PORT.Text));
            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
            BTN_CONNECT.Text = "Connected";
            BTN_CONNECT.BackColor  = Color.Green;


        }
        private void getMessage()
        {

            string returndata;
            while (true)
            {
                serversteam = clientsocket.GetStream(); // stringstream format
                var buffsize = clientsocket.ReceiveBufferSize;
                byte[] instream = new byte[buffsize];

                serversteam.Read(instream, 0, buffsize);
                returndata = System.Text.Encoding.ASCII.GetString(instream);
                readdata = returndata;
                //datareceived(readdata);
                Msg(); // call msg function



            }

        }
        private void Msg()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(Msg));
            }
            else
            {
                TB_RECEIVED.Text = readdata;
                TB_DATA1.Text = System.Convert.ToString(posx);
                TB_DATA2.Text = System.Convert.ToString(posy);
                TB_DATA3.Text = System.Convert.ToString(posz);
              

            }
        }


        private void BTN_SEND_Click(object sender, EventArgs e)
        {
            string datasems = TB_SEND.Text;
            //byte[] outstream = Encoding.ASCII.GetBytes(datasems);

            byte[] outstream = Encoding.ASCII.GetBytes(datasems.Insert(datasems.Length, Environment.NewLine));
            serversteam.Write(outstream, 0, outstream.Length);
            serversteam.Flush();


        }

        private void datareceived(string data)
        {
            int i;
            int j = 0;
            data = readdata;

            for (i = 1; i < data.Length; i++)
            {
                if (data[i] == ',' || data[i] == '.')
                {
                    j++;
                    DataTemp[j] = "";

                }
                else
                {
                    DataTemp[j] = DataTemp[j] + data[i];
                }
            }
            try
            {
                posx = Int16.Parse(DataTemp[0]);
                posy = Int16.Parse(DataTemp[1]);
                posz = Int16.Parse(DataTemp[2]);

                /*TB_RECEIVED.Text = DataTemp[0];*/
            }
            catch { }
            Array.Clear(DataTemp, 0, DataTemp.Length);



        }


    }
}