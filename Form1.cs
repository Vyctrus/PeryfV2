using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using EasyModbus;

namespace ParamSieci19
{
    public partial class Form1 : Form
    {

        public void connectAndrzej()
        {
            //ModbusClient modbusClient = new ModbusClient("COM1");
            ModbusClient modbusX = new ModbusClient("127.0.0.1", 502);
            modbusX.ConnectionTimeout = 500;
            modbusX.Connect();
            int[] readHoldingRegisters = modbusX.ReadHoldingRegisters(0, 10);
            foreach (int i in readHoldingRegisters)
            {
                Debug.WriteLine("Value of register " + i + "is" + readHoldingRegisters[i] + "\n");
            }
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectAndrzej();
            textBox1.Text = "ala ma kota";

        }
    }
}
