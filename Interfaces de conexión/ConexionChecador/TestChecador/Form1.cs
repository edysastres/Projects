using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RecogSys.RdrAccess;
using System.IO;

namespace TestChecador
{
    public partial class Form1 : Form
    {

        private CRsiNetwork Red = new CRsiNetwork();
        private CRsiHandReader Device = new CRsiHandReader();
        private CRsiComWinsock Com = new CRsiComWinsock();
        private bool connectionState = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Conectar()
        {
            try
            {
                Com.SetPortA(3001);
                Com.SetHost(Properties.Resources.IPAddress);
                Red.SetCom(Com);
                if (Com.Connect() == 0)
                {
                    Com.Disconnect();
                    Com.ResetSocket();
                    Com.Connect();
                }
                Red.SetNetworkName("TCP/IP");
                if (Red.IsConnected() == 0)
                {
                    throw new Exception("No existe una conexión con el dispositivo");
                }
                Red.Attach(Device);
                Device.SetAddress(0);
                Device.SetName("HandPunch 2000");
                Device.CmdBeep(100, 3);
                if (Device.IsConnected() == 0)
                {
                    Desconectar();
                    throw new Exception("Dispositivo no conectado");
                } else{
                    btnBeep.Enabled = true;
                    btnRefresh.Enabled = true;
                    lblIPAddr.Text = Properties.Resources.IPAddress;
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Conectado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la conexión", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }

        private void Desconectar()
        {
            Com.Disconnect();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (!connectionState)
            {
                Conectar();
                btnConnect.Text = "Desconectar";
            }
            else
            {
                Desconectar();
                btnBeep.Enabled = false;
                btnRefresh.Enabled = false;
                lblStatus.Text = "Desconectado";
                lblStatus.ForeColor = Color.Red;
                btnConnect.Text = "Conectar";
            }
            connectionState = !connectionState;
            RSI_DATALOG data = new RSI_DATALOG();
            RSI_ID employeeID = new RSI_ID();
            while (Device.CmdGetDatalog(data) > 0)
            {
                    int year = int.Parse(data.pTimestamp.year.ToString()) + 2000;
                    int month = int.Parse(data.pTimestamp.month.ToString());
                    int day = int.Parse(data.pTimestamp.day.ToString());
                    int hour = int.Parse(data.pTimestamp.hour.ToString());
                    int minute = int.Parse(data.pTimestamp.minute.ToString());
                    int seconds = int.Parse(data.pTimestamp.second.ToString());
                    if (year == 2000) break;
                    DateTime date = new DateTime(year, month, day, hour, minute, seconds);
                    if (data.format == RSI_DATALOG_FORMAT.RSI_DLF_IDENTITY_VERIFIED) dgRegistros.Rows.Add(data.pOperand.GetID().Substring(data.pOperand.GetID().Length - 3), date.Date.ToShortDateString(), date.TimeOfDay);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!connectionState)
            {
                Conectar();
                btnConnect.Text = "Desconectar";
            }
            else
            {
                Desconectar();
                btnBeep.Enabled = false;
                btnRefresh.Enabled = false;
                lblStatus.Text = "Desconectado";
                lblStatus.ForeColor = Color.Red;
                btnConnect.Text = "Conectar";
            }
            connectionState = !connectionState;
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            Device.CmdBeep(100, 1);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Environment.Exit(0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RSI_DATALOG data = new RSI_DATALOG();
            RSI_ID employeeID = new RSI_ID();
            while (Device.CmdGetDatalog(data) > 0)
            {
                int year = int.Parse(data.pTimestamp.year.ToString()) + 2000;
                int month = int.Parse(data.pTimestamp.month.ToString());
                int day = int.Parse(data.pTimestamp.day.ToString());
                int hour = int.Parse(data.pTimestamp.hour.ToString());
                int minute = int.Parse(data.pTimestamp.minute.ToString());
                int seconds = int.Parse(data.pTimestamp.second.ToString());
                if (year == 2000) break;
                DateTime date = new DateTime(year, month, day, hour, minute, seconds);
                if (data.format == RSI_DATALOG_FORMAT.RSI_DLF_IDENTITY_VERIFIED) dgRegistros.Rows.Add(data.pOperand.GetID().Substring(data.pOperand.GetID().Length - 3), date.Date.ToShortDateString(), date.TimeOfDay);
                RSI_DISPLAY_MESSAGE Msg = new RSI_DISPLAY_MESSAGE();
                Msg.pMsg.Set("Registros descargados");
                Device.CmdPutDisplayMessage(Msg);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Red != null)
            {
                Red.SetCom(null);
                Red.Dispose();
                Red = null;
            }
            if (Com != null)
            {
                Com.Dispose();
                Com = null;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RSI_DATALOG data = new RSI_DATALOG();
                RSI_ID employeeID = new RSI_ID();
                while (Device.CmdGetDatalog(data) > 0)
                {
                    int year = int.Parse(data.pTimestamp.year.ToString()) + 2000;
                    int month = int.Parse(data.pTimestamp.month.ToString());
                    int day = int.Parse(data.pTimestamp.day.ToString());
                    int hour = int.Parse(data.pTimestamp.hour.ToString());
                    int minute = int.Parse(data.pTimestamp.minute.ToString());
                    int seconds = int.Parse(data.pTimestamp.second.ToString());
                    if (year == 2000) break;
                    DateTime date = new DateTime(year, month, day, hour, minute, seconds);
                    if (data.format == RSI_DATALOG_FORMAT.RSI_DLF_IDENTITY_VERIFIED) dgRegistros.Rows.Add(data.pOperand.GetID().Substring(data.pOperand.GetID().Length - 3), date.Date.ToShortDateString(), date.TimeOfDay);
                    RSI_DISPLAY_MESSAGE Msg = new RSI_DISPLAY_MESSAGE();
                    Msg.pMsg.Set("Registros descargados");
                    Device.CmdPutDisplayMessage(Msg);
                }
            }
        }
    }
}
