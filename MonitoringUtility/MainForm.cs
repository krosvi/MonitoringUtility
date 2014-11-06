using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Collections;
using Microsoft.Win32;
using System.Net;
using System.Net.NetworkInformation;

namespace MonitoringUtility
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// View info about current processes
        /// </summary>
        public void ViewProcesses()
        {
            ManagementClass mcServices = new ManagementClass("Win32_Process");

            processesListView.BeginUpdate();
            foreach (ManagementObject pVal in mcServices.GetInstances())
            {
                ListViewItem item = new ListViewItem();

                try
                {
                    item.Text = pVal.GetPropertyValue("Name").ToString();
                    item.SubItems.Add(pVal.GetPropertyValue("ProcessId").ToString());
                    item.SubItems.Add(pVal.GetPropertyValue("ThreadCount").ToString());
                    item.SubItems.Add(pVal.GetPropertyValue("ExecutablePath").ToString());

                    string[] procOwner = new string[2];
                    pVal.InvokeMethod("GetOwner", (object[])procOwner); //<WMI> GetOwner
                    item.SubItems.Add(procOwner[0]);

                    item.SubItems.Add(Process.GetProcessById(Convert.ToInt32(pVal.GetPropertyValue("ProcessId")))
                        .StartTime.ToString());
                    processesListView.Items.Add(item);
                }
                catch (NullReferenceException)
                {
                    item.SubItems.Add("");
                    processesListView.Items.Add(item);
                }
            }
            processesListView.EndUpdate();
        }

        /// <summary>
        /// View info about services
        /// </summary>
        public void ViewServices()
        {
            ManagementClass mcServices = new ManagementClass("Win32_Service");

            servicesListView.BeginUpdate();
            foreach (ManagementObject sVal in mcServices.GetInstances())
            {
                ListViewItem item = new ListViewItem();

                try
                {
                    item.Text = (sVal.GetPropertyValue("Name").ToString());

                    if (sVal.GetPropertyValue("ProcessId").ToString() == "0")
                        item.SubItems.Add("");
                    else
                        item.SubItems.Add(sVal.GetPropertyValue("ProcessId").ToString());

                    item.SubItems.Add(sVal.GetPropertyValue("State").ToString());
                    item.SubItems.Add(sVal.GetPropertyValue("ServiceType").ToString());
                    item.SubItems.Add(sVal.GetPropertyValue("StartMode").ToString());
                    item.SubItems.Add(sVal.GetPropertyValue("PathName").ToString());
                    item.SubItems.Add(sVal.GetPropertyValue("Description").ToString());

                    servicesListView.Items.Add(item);
                }
                catch (NullReferenceException)
                {
                    item.SubItems.Add("");
                    processesListView.Items.Add(item);
                }
            }
            servicesListView.EndUpdate();
        }

        /// <summary>
        /// View info about autorun
        /// </summary>
        public void ViewAutorun()
        {
            RegistryKey regKeyHKLM = Registry.LocalMachine;
            RegistryKey regKeyHKCU = Registry.CurrentUser;

            regKeyHKLM = regKeyHKLM.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\");
            regKeyHKCU = regKeyHKCU.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\");

            autorunListView.BeginUpdate();
            foreach (String rVal in regKeyHKLM.GetValueNames())     //adding info from HKLM:Run
            {
                ListViewItem item = new ListViewItem();

                item.Text = rVal;
                item.SubItems.Add(regKeyHKLM.GetValue(rVal).ToString());
                item.SubItems.Add("HKLM:Run  (" + regKeyHKLM.Name + ")");

                autorunListView.Items.Add(item);
            }
            foreach (String rVal in regKeyHKCU.GetValueNames())     //adding info from HKCU:Run
            {
                ListViewItem item = new ListViewItem();

                item.Text = rVal;
                item.SubItems.Add(regKeyHKCU.GetValue(rVal).ToString());
                item.SubItems.Add("HKCU:Run  (" + regKeyHKCU.Name + ")");

                autorunListView.Items.Add(item);
            }
            autorunListView.EndUpdate();
        }

        /// <summary>
        /// View info about current connection
        /// </summary>
        public void ViewConnections()
        {
            IPGlobalProperties ipGlProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnections = ipGlProperties.GetActiveTcpConnections();
            IPEndPoint[] tcpLsConnections = ipGlProperties.GetActiveTcpListeners();
            IPEndPoint[] udpConnections = ipGlProperties.GetActiveUdpListeners();

            connectionsListView.BeginUpdate();
            foreach (TcpConnectionInformation tcpValue in tcpConnections)   //TCP connection
            {
                ListViewItem item = new ListViewItem();

                item.Text = ("TCP");
                item.SubItems.Add(tcpValue.LocalEndPoint.ToString());
                item.SubItems.Add(tcpValue.RemoteEndPoint.ToString());
                item.SubItems.Add(tcpValue.State.ToString());

                connectionsListView.Items.Add(item);
            }

            foreach (IPEndPoint tcpLsValue in tcpLsConnections)     //TCP LISTENING connection
            {
                ListViewItem item = new ListViewItem();

                item.Text = ("TCP");
                item.SubItems.Add(tcpLsValue.ToString());
                item.SubItems.Add("0.0.0.0:0");
                item.SubItems.Add("LISTENING");

                connectionsListView.Items.Add(item);
            }

            foreach (IPEndPoint udpValue in udpConnections)     //UDP connection
            {
                ListViewItem item = new ListViewItem();

                item.Text = ("UDP");
                item.SubItems.Add(udpValue.ToString());
                item.SubItems.Add("");
                item.SubItems.Add("");

                connectionsListView.Items.Add(item);
            }
            connectionsListView.EndUpdate();
        }

        //---------------------------------------------------------------------------

        public MainForm()
        {
            InitializeComponent();

            ViewProcesses();
            ViewServices();
            ViewAutorun();
            ViewConnections();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            switch (monUtilTabControl.SelectedIndex)
            {
                case 0:
                    processesListView.Items.Clear();    //refresh processes-list
                    ViewProcesses();
                    break;

                case 1:
                    servicesListView.Items.Clear();     //refresh services-list
                    ViewServices();
                    break;

                case 2:
                    autorunListView.Items.Clear();      //refresh autorun-list
                    ViewAutorun();
                    break;

                case 3:
                    connectionsListView.Items.Clear();  //refresh connection-list
                    ViewConnections();
                    break;
            }
            this.Cursor = Cursors.Default;
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"ReadMe.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred while opening the help file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Monitoring utility v1.0.0\n\n ©Rostislav Kurylo, 2012", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
