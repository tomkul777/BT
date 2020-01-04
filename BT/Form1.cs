using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using InTheHand.Net;

namespace BT
{
    public partial class Form1 : Form
    {
        BluetoothClient client;
        BluetoothDeviceInfo[] devices;
        BluetoothDeviceInfo connectedDevice;

        public Form1()
        {
            InitializeComponent();

            InitBTComboBox();
        }

        private void InitBTComboBox()
        {
            foreach(var radio in BluetoothRadio.AllRadios)
            {
                btComboBox.Items.Add(radio.Name);
            }
            btComboBox.SelectedIndex = 0;
        }

        private void btScan_onClick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            BluetoothRadio.AllRadios[btComboBox.SelectedIndex].Mode = RadioMode.Discoverable;

            client = new BluetoothClient();

            devices = client.DiscoverDevices();
            String deviceAddress;
            String deviceName;

            //dla kazdego znalezionego urzadzenia dodaj je do naszego wyswietlajacego komponentu
            foreach (BluetoothDeviceInfo device in devices)
            {
                deviceAddress = device.DeviceAddress.ToString();
                deviceName = device.DeviceName.ToString();
                string[] row = new string[] { deviceName, deviceAddress };
                dataGridView1.Rows.Add(row);
            }
        }

        private void SendFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            try
            {
                Uri uri = new Uri("obex://" + connectedDevice.DeviceAddress + "/" + openFileDialog.FileName);
                ObexWebRequest obexWebRequest = new ObexWebRequest(uri);
                obexWebRequest.ReadFile(openFileDialog.FileName);
                obexWebRequest.GetResponse().Close();
            } catch(Exception ex)
            {
                return;
            }
        }

        private void Connect(object sender, EventArgs e)
        {
            connectedDevice = devices[dataGridView1.CurrentRow.Index];
            BluetoothSecurity.PairRequest(connectedDevice.DeviceAddress, "1234");
        }

        private void Unpair(object sender, EventArgs e)
        {
            foreach(var device in devices)
            {
                if (device.Remembered) BluetoothSecurity.RemoveDevice(device.DeviceAddress);
            }
        }

        private void Disconnect(object sender, EventArgs e)
        {
            BluetoothSecurity.RemoveDevice(connectedDevice.DeviceAddress);
        }
    }
}
