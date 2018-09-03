﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace USB_HID
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        List<UsbRelayDeviceInfo> devicesInfos = new List<UsbRelayDeviceInfo>();
        int _deviceHandle = 0;


        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "USB HID Relay Controller,ver.:" + Application.ProductVersion;
            InitUI();

        }



        #region USB

        public static class UsbRelayDevice
        { /// <summary>
            /// Init the USB Relay Libary
            /// </summary>
            /// <returns>This function returns 0 on success and -1 on error.</returns>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_init")]
            public static extern int Init();

            /// <summary>
            /// Finalize the USB Relay Libary.
            /// This function frees all of the static data associated with
            /// USB Relay Libary. It should be called at the end of execution to avoid
            /// memory leaks.
            /// </summary>
            /// <returns>This function returns 0 on success and -1 on error.</returns>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_exit")]
            public static extern int Exit();

            /// <summary>
            /// Enumerate the USB Relay Devices.
            /// </summary>
            /// <returns></returns>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_device_enumerate")]
            public static extern IntPtr usb_relay_device_enumerate();

            public static UsbRelayDeviceInfo Enumerate()
            {
                IntPtr x = UsbRelayDevice.usb_relay_device_enumerate();
                //IntPtr x = usb_relay_device_enumerate();
                UsbRelayDeviceInfo a = (UsbRelayDeviceInfo)Marshal.PtrToStructure(x, typeof(UsbRelayDeviceInfo));
                return a;
            }

            /// <summary>
            /// Free an enumeration Linked List
            /// </summary>
            /// <param name="deviceInfo"></param>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_device_free_enumerate")]
            public static extern void FreeEnumerate(UsbRelayDeviceInfo deviceInfo);

            /// <summary>
            /// Open device that serial number is serialNumber
            /// </summary>
            /// <param name="serialNumber"></param>
            /// <param name="stringLength"></param>
            /// <returns>This funcation returns a valid handle to the device on success or NULL on failure.</returns>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_device_open_with_serial_number", CharSet = CharSet.Ansi)]
            public static extern int OpenWithSerialNumber([MarshalAs(UnmanagedType.LPStr)] string serialNumber, int stringLength);

            /// <summary>
            /// Open a usb relay device
            /// </summary>
            /// <param name="deviceInfo"></param>
            /// <returns>This funcation returns a valid handle to the device on success or NULL on failure.</returns>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_device_open")]
            public static extern int Open(UsbRelayDeviceInfo deviceInfo);

            /// <summary>
            /// Close a usb relay device
            /// </summary>
            /// <param name="hHandle"></param>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_device_close")]
            public static extern void Close(int hHandle);

            /// <summary>
            /// open a relay channel on the USB-Relay-Device
            /// </summary>
            /// <param name="hHandle">Which usb relay device your want to operate</param>
            /// <param name="index">Which channel your want to open</param>
            /// <returns>0 -- success; 1 -- error; 2 -- index is outnumber the number of the usb relay device</returns>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_device_open_one_relay_channel")]
            public static extern int OpenOneRelayChannel(int hHandle, int index);

            /// <summary>
            /// open all relay channel on the USB-Relay-Device
            /// </summary>
            /// <param name="hHandle">which usb relay device your want to operate</param>
            /// <returns>0 -- success; 1 -- error</returns>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_device_open_all_relay_channel")]
            public static extern int OpenAllRelayChannels(int hHandle);

            /// <summary>
            /// close a relay channel on the USB-Relay-Device
            /// </summary>
            /// <param name="hHandle">which usb relay device your want to operate</param>
            /// <param name="index">which channel your want to close</param>
            /// <returns>0 -- success; 1 -- error; 2 -- index is outnumber the number of the usb relay device</returns>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_device_close_one_relay_channel")]
            public static extern int CloseOneRelayChannel(int hHandle, int index);

            /// <summary>
            /// close all relay channel on the USB-Relay-Device
            /// </summary>
            /// <param name="hHandle">hich usb relay device your want to operate</param>
            /// <returns>0 -- success; 1 -- error</returns>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_device_close_all_relay_channel")]
            public static extern int CloseAllRelayChannels(int hHandle);

            /// <summary>
            /// status bit: High --> Low 0000 0000 0000 0000 0000 0000 0000 0000, one bit indicate a relay status.
            /// the lowest bit 0 indicate relay one status, 1 -- means open status, 0 -- means closed status.
            /// bit 0/1/2/3/4/5/6/7/8 indicate relay 1/2/3/4/5/6/7/8 status
            /// </summary>
            /// <param name="hHandle"></param>
            /// <param name="status"></param>
            /// <returns>0 -- success; 1 -- error</returns>
            [DllImport("usb_relay_device.dll", EntryPoint = "usb_relay_device_get_status")]
            public static extern int GetStatus(int hHandle, ref int status);
        }

        /// <summary>  
        /// USB relay board info structure  
        /// </summary>  
        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        public class UsbRelayDeviceInfo
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string SerialNumber;

            public IntPtr DevicePath { get; set; }

            public UsbRelayDeviceType Type { get; set; }

            public IntPtr Next { get; set; }
        }

        public enum UsbRelayDeviceType
        {
            OneChannel = 1,
            TwoChannel = 2,
            FourChannel = 4,
            EightChannel = 8
        }

        #endregion

        private void btnFindDevice_Click(object sender, EventArgs e)
        {

            FindDevices(comboDeviceList);
            
        }







        private void FindDevices(ComboBox combodevicelist)
        {
            combodevicelist.Items.Clear();
            devicesInfos.Clear();

            if (UsbRelayDevice.Init() != 0)
            {
                Console.WriteLine("Couldn't initialize!");
                MessageBox.Show("Couldn't initialize!");
                return;
            }
            else
            {
                Console.WriteLine("Initialized successfully!");
            }

           
            UsbRelayDeviceInfo deviceInfo = UsbRelayDevice.Enumerate();
            devicesInfos.Add(deviceInfo);

            while (deviceInfo.Next.ToInt32() > 0)
            {
                deviceInfo = (UsbRelayDeviceInfo)Marshal.PtrToStructure(deviceInfo.Next, typeof(UsbRelayDeviceInfo));
                devicesInfos.Add(deviceInfo);
            }

            foreach (var device in devicesInfos)
            {
                combodevicelist.Items.Add(device.SerialNumber);
                updateMsg(lstMsg, "FInd device,SN:" + device.SerialNumber + "," + "Type:" + device.Type.ToString());
            }

            if (combodevicelist.Items.Count > 0)
                combodevicelist.SelectedIndex = 0;
            
        }





        private void updateMsg(ListBox listbox,string msg)
        {
            if (listbox.Items.Count > 1000)
                listbox.Items.RemoveAt(0);

            lstMsg.Items.Add(DateTime.Now.ToString("HH:mm:ss") + "->" + msg);


            if (listbox.Items.Count > 0)
                listbox.TopIndex = listbox.Items.Count - 1;
            else
                listbox.TopIndex = 0;
        }





        private void InitUI()
        {
            
            btnOpenDevice.Enabled = false;
            btnOpenRelay1.Enabled = false;
            btnOpenRelay2.Enabled = false;
            btnOpenRelay3.Enabled = false;
            btnOpenRelay4.Enabled = false;
            btnOpenRelay5.Enabled = false;
            btnOpenRelay6.Enabled = false;
            btnOpenRelay7.Enabled = false;
            btnOpenRelay8.Enabled = false;
            btnOpenAll.Enabled = false;

            btnCloseDevice.Enabled = false;
            btnCloseRelay1.Enabled = false;
            btnCloseRelay2.Enabled = false;
            btnCloseRelay3.Enabled = false;
            btnCloseRelay4.Enabled = false;
            btnCloseRelay5.Enabled = false;
            btnCloseRelay6.Enabled = false;
            btnCloseRelay7.Enabled = false;
            btnCloseRelay8.Enabled = false;
            btnCloseAll.Enabled = false;


        }


        private void FindDeviceUI(UsbRelayDeviceType _usbrelaydevicetype)
        {

            switch (_usbrelaydevicetype)
            {
                case UsbRelayDeviceType.OneChannel:
                    btnOpenDevice.Enabled = true;
                    btnCloseDevice.Enabled = true;
                    btnOpenRelay1.Enabled = true;
                    btnCloseRelay1.Enabled = true;
                    btnOpenAll.Enabled = true;
                    btnCloseAll.Enabled = true;
                    lblDeviceStatus.BackColor = Color.White;
                    lblRelayStatus1.BackColor = Color.White;
                    
                    break;
                case UsbRelayDeviceType.TwoChannel:
                    break;
                case UsbRelayDeviceType.FourChannel:
                    break;
                case UsbRelayDeviceType.EightChannel:
                    break;
                default:
                    break;
            }

        }

        private void comboDeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboDeviceList.SelectedIndex;
            if (i != -1)
            {
                FindDeviceUI(devicesInfos[i].Type);
                updateMsg(lstMsg ,"Select device SN:" + devicesInfos[i].SerialNumber + ",Type:" + devicesInfos[i].Type.ToString());

            }
        }



    }
}
