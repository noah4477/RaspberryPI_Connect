using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using HardwareMixerObj;
using SerializeData;
using Microsoft.VisualBasic;
namespace RPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Temporary (to be used for testing on computer)
            string ip =  Microsoft.VisualBasic.Interaction.InputBox("Enter Local IP Address:", "RPI", "");

            InitializeComponent();
            Thread startserver = new Thread(() => StartServer(ip));
            startserver.Start();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void ProcessData(PCData pcdata)
        {
            SetText(this, this.DefaultDevice, pcdata.defaultDevice.Name);
            SetVolumeLevel(this, this.DefaultDeviceVolume, pcdata.defaultDevice.Volume);
            pcdata = SetMuteMaster(pcdata);
            
            for (int i = 0; i < pcdata.Programs.Count; i++)
           {
                SetProgramImage(i, pcdata);
                SetProgramMute(i, pcdata);
                SetProgramVolume(i, pcdata);
                SetProgramName(i, pcdata);
           }

        }

        private void SetProgramName(int i, PCData pcdata)
        {
            if (i == 0)
            {
                SetText(this, this.Program1, pcdata.Programs[i].Name);
            }
            else if (i == 1)
            {
                SetText(this, this.Program2, pcdata.Programs[i].Name);
            }
            else if (i == 2)
            {
                SetText(this, this.Program3, pcdata.Programs[i].Name);
            }
        }

        private PCData SetMuteMaster(PCData pcdata)
        {
            if (pcdata.defaultDevice.IsMute == true)
            {
                for (int i = 0; i < pcdata.Programs.Count; i++)
                {
                    pcdata.Programs[i].IsMute = true;
                }
            }
            SetMute("DefaultDevice", pcdata.defaultDevice.IsMute);
            return pcdata;
        }

        private void SetProgramMute(int i, PCData pcdata)
        {
            if (i == 0)
            {
                SetMute("Program1",pcdata.Programs[i].IsMute);
            }
            else if (i == 1)
            {
                SetMute("Program2", pcdata.Programs[i].IsMute);
            }
            else if (i == 2)
            {
                SetMute("Program3", pcdata.Programs[i].IsMute);
            }
        }

        private void SetProgramVolume(int i, PCData pcdata)
        {
            if (i == 0)
            {
                SetVolumeLevel(this, this.Program1Volume, pcdata.Programs[i].Volume);
            }
            else if (i == 1)
            {
                SetVolumeLevel(this, this.Program2Volume, pcdata.Programs[i].Volume);
            }
            else  if (i == 2)
            {
                SetVolumeLevel(this, this.Program3Volume, pcdata.Programs[i].Volume);
            }
        }

        private void SetProgramImage(int i, PCData pcdata)
        {
            if (pcdata.Programs[i].Name == null)
            {
                //Display blank audio device
            }
            if (pcdata.Programs[i].Name == "System Sounds")
            {
                pcdata.Programs[i].Icon = Properties.Resources.SystemSoundsIcon;
            }
            if (i == 0)
            {
                Program1Icon.Image = pcdata.Programs[i].Icon;
            }
            else if (i == 1)
            {
                Program2Icon.Image = pcdata.Programs[i].Icon;
            }
            else if (i == 2)
            {
                Program3Icon.Image = pcdata.Programs[i].Icon;
            }
        }
        private void SetMute(string Device, bool ismute)
        {
            if (Device == "DefaultDevice")
            {
                SetMuteIcon(this, this.MainMuteEnabled, this.MainMuteDisabled, ismute);
            }
            else if(Device == "Program1")
                SetMuteIcon(this, this.Program1MuteEnabled, this.Program1MuteDisabled, ismute);
            else if(Device == "Program2")
                SetMuteIcon(this, this.Program2MuteEnabled, this.Program2MuteDisabled, ismute);
            else if(Device == "Program3")
                SetMuteIcon(this, this.Program3MuteEnabled, this.Program3MuteDisabled, ismute);
            
        }
        delegate void SetMuteIconCallback(Form f, Button b1,Button b2, bool ismute);

        private void SetMuteIcon(Form f, Button b1,Button b2,  bool ismute)
        {
            if (b1.InvokeRequired || b2.InvokeRequired)
            {
                SetMuteIconCallback d = new SetMuteIconCallback(SetMuteIcon);
                f.Invoke(d, new object[] { f, b1,b2, ismute });
            }
            else
            {
                if(ismute == true)
                {
                    b1.Enabled = false;
                    b1.Visible = false;
                    b2.Visible = true;
                    b2.Enabled = true;
                    return;
                }
                if (ismute == false)
                {
                    b1.Enabled = true;
                    b1.Visible = true;
                    b2.Visible = false;
                    b2.Enabled = false;
                }
            }
        }
            
        delegate void SetVolumeLevelCallback(Form f, TrackBar tb, int volume);

        private void SetVolumeLevel(Form form, TrackBar tb, int volume)
        {
            if (tb.InvokeRequired)
            {
                SetVolumeLevelCallback d = new SetVolumeLevelCallback(SetVolumeLevel);
                form.Invoke(d, new object[] { form, tb, volume });
            }
            else
            {
                tb.Value = volume;
            }
        }

        delegate void SetTextCallback(Form f, Control ctrl, string text);

        private void SetText(Form form, Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] {form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }
        
        public void StartServer(string ip)
        {
            TcpClient client = new TcpClient();

            int port = 8000;
            Console.WriteLine("IP: " + ip);

            Console.WriteLine("Port: " + port);

            Console.WriteLine("Connecting...");

            Connect(client, ip, port);

            Console.WriteLine("Connected!");
            
            try
            {

                NetworkStream Networkstream = client.GetStream();
                Networkstream.Flush();
                // StreamReader sr = new StreamReader(client.GetStream());
                readSocket(Networkstream, ip);
             //   Thread readThread = new Thread(() => this.readSocket(Networkstream));
             //   readThread.Start(); //Run readSocket() at the same time
              //  while (true) { Thread.Sleep(1000); }
            }
            catch (Exception e) 
            {
                StartServer(ip);
            }
        }
    private void readSocket(NetworkStream Networkstream, string ip)
        {

            while (true)
            {
                byte[] readMsgData = { 0 };
                try
                {
                    byte[] readMsgLen = new byte[4];
                    Networkstream.Read(readMsgLen, 0, 4);

                    int dataLen = BitConverter.ToInt32(readMsgLen, 0);
                    readMsgData = new byte[dataLen];
                    if (dataLen > 0)
                    {
                        try
                        {
                            if (Networkstream.CanRead)
                            {
                                byte[] myReadBuffer = new byte[1024];
                                MemoryStream ms = new MemoryStream();
                                int numberOfBytesRead = 0;
                                do
                                {
                                    numberOfBytesRead = Networkstream.Read(myReadBuffer, 0, myReadBuffer.Length);
                                    ms.Write(myReadBuffer, 0, myReadBuffer.Length);
                                }
                                while (Networkstream.DataAvailable && ms.Length < dataLen);

                                PCData data = Serialize.DeserializeFromByteArray<PCData>(ms.GetBuffer());
                                ProcessData(data);
                            }
                            else
                            {
                                Console.WriteLine("Sorry.  You cannot read from this NetworkStream.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }

                }
                catch (System.IO.IOException) 
                {
                    StartServer(ip);  //Catch Exception and restart the server
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
        }

        

    public static void Connect(TcpClient Client, string Ipadress, int port)
    {
        while (Client.Connected == false)
        {
            try
            {
                Client.Connect(Ipadress, port);
            }
            catch (Exception e)
            { }
        }
    }
    
    }
}

