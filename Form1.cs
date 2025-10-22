using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PuttyComSelect
{
    public partial class Form1 : Form
    {
        readonly List<Port> ports = new List<Port>();
        readonly Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += AddComPort;
            timer.Start();
            // Load user settings
            portSpeed.Text = Properties.Settings.Default.Speed.ToString();
        }

        private void AddComPort(object sender, EventArgs e)
        {
            var updated = false;
            var currentPorts = new List<string>(System.IO.Ports.SerialPort.GetPortNames());
            // Add new ports that are not already in the list
            foreach (var portName in currentPorts)
            {
                if (!ports.Any(p => p.name == portName))
                {
                    updated = true;
                    ports.Add(new Port(portName));
                }
            }
            // Remove ports that are no longer available
            var portsToRemvoe = ports.Where(p => !currentPorts.Contains(p.name)).ToList();
            if (portsToRemvoe.Count > 0)
            {
                ports.RemoveAll(p => !currentPorts.Contains(p.name));
                updated = true;
            }
            // Update the ComboBox with the current ports
            if (updated)
            {
                RefreshList();
            }
        }

        private void RefreshList()
        {
            portsList.Items.Clear();
            foreach (var port in ports.OrderBy(p => p.since).Reverse())
            {
                portsList.Items.Add(port.PortView);
            }
        }

        private void SetPuttyClick(object sender, EventArgs e)
        {
            var puttyPath = Properties.Settings.Default.PuttyPath;
            var speed = Properties.Settings.Default.Speed;
            if (portsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a port from the list.", "No Port Selected");
                return;
            }
            if (string.IsNullOrEmpty(puttyPath))
            {
                MessageBox.Show("Please set the path to PuTTY in the settings.", "PuTTY Path Not Set");
                return;
            }
            if (speed <= 0)
            {
                MessageBox.Show("Please enter a valid port speed.", "Invalid Port Speed");
                return;
            }
            var selectedPort = portsList.SelectedItems[0].Text;
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = puttyPath,
                Arguments = $"-serial {selectedPort} -sercfg {speed},8,n,1,N",
                UseShellExecute = false
            };

            Process.Start(startInfo);
        }

        private void LaunchPuttyClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\program files";
            openFileDialog1.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.PuttyPath = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void portSpeed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var speed = int.Parse(portSpeed.Text);
                Properties.Settings.Default.Speed = speed;
                Properties.Settings.Default.Save();
            }
            catch {
                portSpeed.Text = Properties.Settings.Default.Speed.ToString();
                MessageBox.Show("Please enter a valid port speed.", "Invalid Input");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void info_Click(object sender, EventArgs e)
        {

        }
    }
}
