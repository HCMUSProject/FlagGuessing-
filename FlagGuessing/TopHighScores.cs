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
    public partial class TopHighScores : Form
    {
        string XmlFileName = "";

        public TopHighScores()
        {
            InitializeComponent();
        }

        private void TopHighScores_Load(object sender, EventArgs e)
        {
            XmlScoreUser xmlScore = new XmlScoreUser();
            if (System.IO.File.Exists(XmlFileName) == true)
            {
                xmlScore.ReadUserScore();
            }

            dataGridView.DataSource = xmlScore.ListUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getFileName(string s)
        {
            XmlFileName = s;
        }
    }
}
