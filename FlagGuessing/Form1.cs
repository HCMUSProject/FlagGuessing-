using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagGuessing
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Width = 800;
            //this.Height = 500;

            // SET POSITION FOR 2 PANELS
            PanelGamePlay.Left = 0;
            PanelGamePlay.Top = 70;
            PanelGamePlay.Width = System.Convert.ToInt32(System.Math.Floor(this.Width * 0.64));
            PanelControl.Left = PanelGamePlay.Width;
            PanelControl.Top = PanelGamePlay.Top;
            PanelControl.Width = this.Width - PanelGamePlay.Width;
            PanelGamePlay.Height = this.Height - PanelGamePlay.Top;
            PanelControl.Height = PanelGamePlay.Height;


        }
    }
}
