using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfaGadgets_Resizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseBTN(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SmallBTN(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("8GadgetPack");
            key = key.OpenSubKey("8GadgetPack", true);
            //  key.CreateSubKey("AppVersion");
            //  key = key.OpenSubKey("AppVersion", true);
            key.SetValue("GlobalForceDPI", 0x00000040, RegistryValueKind.DWord);
            //Restart SideBar
            String ProcessPath ;
            try
            {
                var process = Process.GetProcessesByName("sidebar")[0];
                ProcessPath = process.MainModule.FileName;
                System.Diagnostics.Debug.WriteLine("ProcessPath:" + ProcessPath );
                process.Kill();
                Process.Start(ProcessPath);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Sidebar is not running");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

 
        }

        private void MediumBTN(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("8GadgetPack");
            key = key.OpenSubKey("8GadgetPack", true);
            //  key.CreateSubKey("AppVersion");
            //  key = key.OpenSubKey("AppVersion", true);
            key.SetValue("GlobalForceDPI", 0x00000060, RegistryValueKind.DWord);
            //Restart SideBar
            String ProcessPath;
            try
            {
                var process = Process.GetProcessesByName("sidebar")[0];
                ProcessPath = process.MainModule.FileName;
                System.Diagnostics.Debug.WriteLine("ProcessPath:" + ProcessPath);
                process.Kill();
                Process.Start(ProcessPath);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Sidebar is not running");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }

        private void LargeBTN(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("8GadgetPack");
            key = key.OpenSubKey("8GadgetPack", true);
            //  key.CreateSubKey("AppVersion");
            //  key = key.OpenSubKey("AppVersion", true);
            key.SetValue("GlobalForceDPI", 0x00000070, RegistryValueKind.DWord);
            //Restart SideBar
            String ProcessPath;
            try
            {
                var process = Process.GetProcessesByName("sidebar")[0];
                ProcessPath = process.MainModule.FileName;
                System.Diagnostics.Debug.WriteLine("ProcessPath:" + ProcessPath);
                process.Kill();
                Process.Start(ProcessPath);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Sidebar is not running");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void XlargeBTN(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("8GadgetPack");
            key = key.OpenSubKey("8GadgetPack", true);
            //  key.CreateSubKey("AppVersion");
            //  key = key.OpenSubKey("AppVersion", true);
            key.SetValue("GlobalForceDPI", 0x00000080, RegistryValueKind.DWord);
            //Restart SideBar
            String ProcessPath;
            try
            {
                var process = Process.GetProcessesByName("sidebar")[0];
                ProcessPath = process.MainModule.FileName;
                System.Diagnostics.Debug.WriteLine("ProcessPath:" + ProcessPath);
                process.Kill();
                Process.Start(ProcessPath);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Sidebar is not running");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void XXlargeBTN(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("8GadgetPack");
            key = key.OpenSubKey("8GadgetPack", true);
            //  key.CreateSubKey("AppVersion");
            //  key = key.OpenSubKey("AppVersion", true);
            key.SetValue("GlobalForceDPI", 0x00000090, RegistryValueKind.DWord);
            //Restart SideBar
            String ProcessPath;
            try
            {
                var process = Process.GetProcessesByName("sidebar")[0];
                ProcessPath = process.MainModule.FileName;
                System.Diagnostics.Debug.WriteLine("ProcessPath:" + ProcessPath);
                process.Kill();
                Process.Start(ProcessPath);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Sidebar is not running");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

 

        private void NormalBTN(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("8GadgetPack");
            key = key.OpenSubKey("8GadgetPack", true);
            //  key.CreateSubKey("AppVersion");
            //  key = key.OpenSubKey("AppVersion", true);
            key.SetValue("GlobalForceDPI", "-");
            //Restart SideBar
            String ProcessPath;
            try
            {
                var process = Process.GetProcessesByName("sidebar")[0];
                ProcessPath = process.MainModule.FileName;
                System.Diagnostics.Debug.WriteLine("ProcessPath:" + ProcessPath);
                process.Kill();
                Process.Start(ProcessPath);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Sidebar is not running");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void AboutBTN(object sender, EventArgs e)
        {


            string target = "https://github.com/fahdd95/AlfaGadgets";
            try
            {
                Process.Start("explorer.exe", target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }

        }
    }
}
