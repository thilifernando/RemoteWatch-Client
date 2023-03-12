using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RemoteWatch
{
    public partial class F2_MainWindow : Form
    {
       //mainwindow button switch
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );


        public F2_MainWindow()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //button click
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            panel3.Left = button1.Left;
            button1.BackColor = Color.Teal;

            //button click changes the windows accordingly
            label3.Text = "MainWindow";
            this.panel4.Controls.Clear();
            F3_MainView F3MainViewObject = new F3_MainView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            F3MainViewObject.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(F3MainViewObject);
            F3MainViewObject.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F2_AfterSignIn_Load(object sender, EventArgs e)
        {
            //curve window outline
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 28; 
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(this.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(this.Width - arcSize, this.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, this.Height - arcSize, arcSize, arcSize, 90, 90);
            this.Region = new System.Drawing.Region(path);

            // show application in system tray
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;

            //curve close button
            /*System.Drawing.Drawing2D.GraphicsPath path1 = new System.Drawing.Drawing2D.GraphicsPath();
            path1.AddEllipse(0, 0, button7.Width, button7.Height);
            button7.Region = new System.Drawing.Region(path);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button click 
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            panel3.Left = button1.Left;
            button1.BackColor = Color.Teal;

            //button click changes the windows accordingly
            label3.Text = "MainWindow";
            this.panel4.Controls.Clear();
            F3_MainView F3MainViewObject = new F3_MainView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};  
            F3MainViewObject.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add( F3MainViewObject );
            F3MainViewObject.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            panel3.Left = button2.Left;
            button2.BackColor = Color.Teal;

            label3.Text = "Dashboard";
            this.panel4.Controls.Clear();
            F4_Dashboard F4Object = new F4_Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            F4Object.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(F4Object);
            F4Object.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            panel3.Left = button3.Left;
            button3.BackColor = Color.Teal;

            label3.Text = "Projects";
            this.panel4.Controls.Clear();
            F5_Projects F5Object = new F5_Projects() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            F5Object.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(F5Object);
            F5Object.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;
            panel3.Left = button4.Left;
            button4.BackColor = Color.Teal;

            label3.Text = "WorkRecords";
            this.panel4.Controls.Clear();
            F6_Workrecords F6Object = new F6_Workrecords() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            F6Object.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(F6Object);
            F6Object.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Height = button5.Height;
            panel3.Top = button5.Top;
            panel3.Left = button5.Left;
            button5.BackColor = Color.Teal;

            label3.Text = "Submit";
            this.panel4.Controls.Clear();
            F7_Submit F7Object = new F7_Submit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            F7Object.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(F7Object);
            F7Object.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;
            panel3.Left = button6.Left;
            button6.BackColor = Color.Teal;


            label3.Text = "Settings";
            this.panel4.Controls.Clear();
            F8_Settings F8Object = new F8_Settings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            F8Object.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(F8Object);
            F8Object.Show();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            //after button click
            button1.BackColor = Color.LightSeaGreen;
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightSeaGreen;
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightSeaGreen;
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightSeaGreen;
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightSeaGreen;
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightSeaGreen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            //application icon shows in system tray
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;
                this.Visible = true;
                notifyIcon1.Visible = false;
            }
            this.WindowState = FormWindowState.Normal;
        }
    }
}
