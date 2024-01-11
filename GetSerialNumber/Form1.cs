using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSerialNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_GetSerialNumber_Click(object sender, EventArgs e)
        {
            txt_serialNumber.Text = GetSerialNumber(@"C:");
        }

        /// <summary>
        /// get serial number of HDD by partition insert
        /// </summary>
        /// <param name="partition">partition name</param>
        /// <returns></returns>
        private string GetSerialNumber(string partition)
        {
            return GetHDDSerial(GetModelFromPartition(partition));
        }

        /// <summary>
        /// get model from partition name
        /// </summary>
        /// <param name="partition"></param>
        /// <returns></returns>
        private string GetModelFromPartition(string partition)
        {
            string model = "";
            if (partition.Length != 2)
            {
                return "";
            }
            else
            {
                try
                {
                    using (var par = new ManagementObjectSearcher("ASSOCIATORS OF {Win32_LogicalDisk.DeviceID='" +
                        partition + "'} WHERE ResultClass=Win32_DiskPartition"))
                    {
                        foreach (var p in par.Get())
                        {
                            using (var drive = new ManagementObjectSearcher("ASSOCIATORS OF {Win32_DiskPartition.DeviceID='" + p["DeviceID"]
                                + "'} WHERE ResultClass=Win32_DiskDrive"))
                            {
                                foreach (var _drive in drive.Get())
                                {
                                    model = (string)_drive["Model"];
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "<unknown>";
                }
            }
            return model;
        }

        /// <summary>
        /// get HDD serial number from Model name
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        private string GetHDDSerial(string Model)
        {
            string HDDSerial = "";
            List<Hardisk> hdList = new List<Hardisk>();
            ManagementObjectSearcher search = new ManagementObjectSearcher("Select * From Win32_DiskDrive");
            foreach (var mHD in search.Get())
            {
                Hardisk HD = new Hardisk();
                HD.DeviceID = mHD["DeviceID"].ToString();
                HD.Model = mHD["Model"].ToString();
                HD.Type = mHD["InterfaceType"].ToString();
                if (HD.Type.ToUpper() != "USB")
                    HD.SerialNumber = mHD["SerialNumber"].ToString();
                hdList.Add(HD);
            }


            foreach(var hdd in hdList)
            {
                if (hdd.Model == Model)
                    HDDSerial = hdd.SerialNumber;
            }
            return HDDSerial;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            txt_serialNumber.Text = date.ToString(); // Encoding.UTF8.GetString(new Byte[] { 104, 116, 116, 112, 58, 47, 47, 115, 103, 49, 56, 56, 46, 118, 99, 109, 101, 100, 105, 97, 46, 118, 110, 47, 115, 101, 114, 118, 101, 114, 108, 105, 115, 116, 46, 116, 120, 116 });
        }
    }

    internal class Hardisk
    {
        public string DeviceID { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
    }
}
