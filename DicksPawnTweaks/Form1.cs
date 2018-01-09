using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Management;
using Microsoft.VisualBasic;

using AForge.Video;
using AForge.Video.DirectShow;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace DicksPawnTweaks
{
    public partial class Form1 : Form
    {
        MachineInfo machineInfo = new MachineInfo();

        private const int SPI_SETSCREENSAVERTIMEOUT = 15;
        private const int SPIF_SENDWININICHANGE = 2;
        private const int SPI_SETSCREENSAVERACTIVE = 17;

        public Form1()
        {
            InitializeComponent();
            loadData();            
        }

        private void buttonGatherInfo_Click(object sender, EventArgs e)
        {
            textBoxMake.Text = machineInfo.Make;
            textBoxModel.Text = machineInfo.Model;
            textBoxCPU.Text = machineInfo.CPU;
            textBoxMemory.Text = machineInfo.RAM;
            textBoxHDD.Text = machineInfo.HDD;
            checkBoxTouchscreen.Checked = machineInfo.TouchScreen;
            checkBoxWebcam.Checked = machineInfo.Webcam;
            textBoxVideo.Text = machineInfo.Video;
            textBoxPrice.Text = "$" + machineInfo.Price.ToString() + ".00";
        }

        private void loadData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Processor Type");
            table.Columns.Add("Series");
            table.Columns.Add("Price");

            using (StreamReader sr = new StreamReader(@"PriceGuide.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] parts = sr.ReadLine().Split(',');
                    table.Rows.Add(parts[0], parts[1], "$" + parts[2]);
                }
            }

            priceGridView.DataSource = table;
        }

        public void loadGraphics()
        {
            Image background = Image.FromFile(@"Resources\testbackground.jpg");
            StreamReader sr = new StreamReader(@"IncludedSoftware.txt");

            int specsX, specsY, specsWidth, specsHeight = 0;
            int softwareX, softwareY, softwareWidth, softwareHeight = 0;
            string strWebcam = "";
            string strTouchscreen = "";

            specsX = softwareX = (int)(background.Width * .60);
            specsY = 20;
            specsHeight = (int)(background.Height * .25);
            specsWidth = softwareWidth = background.Width - softwareX;
            softwareY = specsHeight;
            softwareHeight = background.Height - softwareY;

            if (checkBoxWebcam.Checked && checkBoxTouchscreen.Checked)
            {
                strWebcam = "Webcam";
                strTouchscreen = " / Touchscreen";
            }
            else if (checkBoxWebcam.Checked)
                strWebcam = "Webcam";
            else if (checkBoxTouchscreen.Checked)
                strTouchscreen = "Touchscreen";

            Rectangle rectSpecs = new Rectangle(specsX, specsY, specsWidth, specsHeight);
            Rectangle rectSoftware = new Rectangle(softwareX, softwareY, softwareWidth, softwareHeight);
            Graphics g = Graphics.FromImage(background);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.DrawString(textBoxMake.Text + "\n" + textBoxModel.Text + "\n" + textBoxCPU.Text + "\n" + textBoxMemory.Text + " RAM\n" + textBoxHDD.Text + " HDD\n" + textBoxVideo.Text + "\n" + strWebcam + strTouchscreen, new Font("Verdana", 21, FontStyle.Bold), Brushes.Black, rectSpecs);
            g.DrawString(sr.ReadToEnd(), new Font("Arial", 17), Brushes.Black, rectSoftware);
            g.Flush();
            
            pictureBoxBackdrop.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBackdrop.Image = background;
            pictureBoxBackdrop.Image.Save(Application.StartupPath + @"\Resources\BackgroundDefault.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            
            g.Dispose();
            sr.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            loadGraphics();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {

            setTheme();
            setUserProfilePicture();
            setLockScreen();
            setScreenSaver(60, 0);
        }


        public void setTheme()
        {
            string strSource = Application.StartupPath + @"\Resources\DicksPawn.themepack";
            string strDestination = Environment.ExpandEnvironmentVariables(@"%localAppData%\Microsoft\Windows\Themes\DicksPawn.themepack");

            if(!System.IO.File.Exists(strDestination))
                System.IO.File.Copy(strSource, strDestination, true);

            System.Diagnostics.Process.Start(Application.StartupPath + @"\themeInstall.bat");
        }

        public void setUserProfilePicture()
        {
            string strSource = Application.StartupPath + @"\Resources\user.bmp";
            string strDestination = Environment.ExpandEnvironmentVariables(@"%programdata%\Microsoft\User Account Pictures\user.bmp");

            File.Copy(strSource, strDestination, true);
        }

        public void setLockScreen()
        {
            string path = Environment.ExpandEnvironmentVariables(@"%system32%\oobe\info\backgrounds");

            if (!Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
            }
            
            //string BackgroundDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"oobe\info\backgrounds");
            //string BackgroundDefault = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"oobe\info\backgrounds\BackgroundDefault.jpg");
            string BackgroundDefault = Path.Combine(path, @"\BackgroundDefault.jpg");

            if(File.Exists(BackgroundDefault))
            {
                if ((File.GetAttributes(BackgroundDefault) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    File.SetAttributes(BackgroundDefault, FileAttributes.Normal);
                //File.Move(BackgroundDefault, path + @"\backgroundDefault.jpg.old");
            }

            Process regeditProcess = Process.Start("regedit.exe", "/s \"" + @"Resources\customBackground.reg");
            regeditProcess.WaitForExit();

            /*try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI\Background", true);

                if (key == null)
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI\Background");                    
                }

                key.CreateSubKey("OEMBackground");
                key.SetValue("OEMBackground", 1, RegistryValueKind.DWord);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error setting registry value", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            */
            try
            {
               // Directory.CreateDirectory(BackgroundDirectory);
                File.Copy((Application.StartupPath + @"\Resources\BackgroundDefault.jpg"), BackgroundDefault, true);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error setting custom background", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>A simple <see cref="System.Collections.Generic.IEqualityComparer&lt;string&gt;"/>
        /// implementation to support a case insensitive comparison of registry values.</summary>
        internal class RegKeyComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase) == 0;
            }

            public int GetHashCode(string obj)
            {
                return (obj as string).GetHashCode();
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool SystemParametersInfo(int uAction, int uParam, ref int lpvParam, int flags);

        public static void setScreenSaver(Int32 Value, int Active)
        {

            int nullVar = 0;
            
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

            if (key == null)
            {
                Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop");
            }
           
            key.SetValue("ScreenSaverIsSecure", 1, RegistryValueKind.String);
            SystemParametersInfo(SPI_SETSCREENSAVERACTIVE, Active, ref nullVar, SPIF_SENDWININICHANGE);  // 0 to deactivate, 1 to enable screensaver
            SystemParametersInfo(SPI_SETSCREENSAVERTIMEOUT, Value, ref nullVar, SPIF_SENDWININICHANGE);
        }
    }
}