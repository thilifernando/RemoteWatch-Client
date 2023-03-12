using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RemoteWatch
{
    public partial class F1_StartWindow : Form
    {
        public string EmpUsername { get; set; }
        public string EmpPassword { get; set; }

        public F1_StartWindow()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            //this.EmpUsername = text_EmpUsername.Text;
            //this.EmpPassword = "";
            //this.DialogResult = DialogResult.OK;
            //this.Close();

            //moving to next form
            var F2_AfterSignIn = new F2_MainWindow();
            F2_AfterSignIn.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }

        private void F1_MainWindow_Load(object sender, EventArgs e)
        {
            //curve window outline
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 25; 
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(this.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(this.Width - arcSize, this.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, this.Height - arcSize, arcSize, arcSize, 90, 90);
            this.Region = new System.Drawing.Region(path);
        }
    }
}
