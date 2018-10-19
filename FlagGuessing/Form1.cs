using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Resources;
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

        List<Flags> listFlags = new List<Flags>();
        private bool isStarted = false;
        int nQuestion = -1, posTrue = -1;
        string strQuestion = "Đâu là lá cờ của ";

        private string GetFlagName(string source)
        {
            string strName = "";

            source = source.ToLower();
            source.Replace(" ","");

            char c = char.ToUpper(source[0]);
            source = source.Remove(0, 1);
            source = source.Insert(0, c.ToString());

            strName = source;

            if (source == "Bodaonha")
                strName = "Bồ Đào Nha";
            if (source == "Congo")
                strName = "Công-gô";
            if (source == "Cuba")
                strName = "Cu Ba";
            if (source == "Finland")
                strName = "Phần Lan";
            if (source == "Thonhiky")
                strName = "Thổ Nhĩ Kỳ";

            return strName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Width = 800;
            this.Height = 500;

            // SET POSITION FOR 2 PANELS
            PanelGamePlay.Left = 0;
            PanelGamePlay.Top = 60;
            PanelGamePlay.Width = System.Convert.ToInt32(System.Math.Floor(this.Width * 0.64));
            PanelControl.Left = PanelGamePlay.Width;
            PanelControl.Top = PanelGamePlay.Top;
            PanelControl.Width = this.Width - PanelGamePlay.Width;
            PanelGamePlay.Height = this.Height - PanelGamePlay.Top;
            PanelControl.Height = PanelGamePlay.Height;

            txtTimes.Text = "0/" + totalRound.ToString();
            txtScore.Text = "0";

            btnChoose1.Enabled = false;
            btnChoose2.Enabled = false;
            btnRestart.Enabled = false;

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;

            ResourceManager rm = Properties.Resources.ResourceManager;

            ResourceSet rs = rm.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);

            Dictionary<object, object> dic;
            var objs =
            (from obj in rs.Cast<DictionaryEntry>()
             select obj).ToList();
            dic = new Dictionary<object, object>();
            foreach (var v in objs)
            {
                Flags a = new Flags();
                a.Name = GetFlagName(v.Key.ToString());
                a.ImageSource = v.Key.ToString();
                listFlags.Add(a);
            }
        }

        public static Bitmap GetImageByName(string imageName)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            return (Bitmap)rm.GetObject(imageName);
        }
        private int RandomQuestion()
        {
            int key = -1;
            Random rd = new Random();
            key = rd.Next(0, listFlags.Count - 1);

            return key;
        }
        private int RandomFlagsToPictureBox(int key)
        {
            Random rd = new Random();
            int index = -1;
            do
            {
                index = rd.Next(0, listFlags.Count);
            }
            while (index == key);
            int posTrue = rd.Next(1, 3);
            if (posTrue == 1)
            {
                pictureBox1.Image = GetImageByName(listFlags[key].ImageSource);
                pictureBox2.Image = GetImageByName(listFlags[index].ImageSource);
            }
            else
            {
                pictureBox1.Image = GetImageByName(listFlags[index].ImageSource);
                pictureBox2.Image = GetImageByName(listFlags[key].ImageSource);
            }
            return posTrue;
        }

        int round = 0, totalRound = 10;

        private void RoundPlaying()
        {
            nQuestion = RandomQuestion();
            posTrue = RandomFlagsToPictureBox(nQuestion);
            lbQuestion.Text = strQuestion + listFlags[nQuestion].Name + " ?";

            round++;
            txtTimes.Text = round.ToString() + "/" + totalRound.ToString();
        }
        
        private void btnChoose1_Click(object sender, EventArgs e)
        {
            if (posTrue == 1)
            {
                // đáp án đúng
                MessageBox.Show("true");
            }
            
            RoundPlaying();
        }
        

        private void btnChoose2_Click(object sender, EventArgs e)
        {
            if (posTrue == 2)
            {
                // đáp án đúng
                MessageBox.Show("true");
            }
            RoundPlaying();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isStarted == false)
            {
                round = 0;
                
                // khơi tạo câu hỏi ban đầu
                RoundPlaying();

                isStarted = true;
                btnChoose1.Enabled = true;
                btnChoose2.Enabled = true;
                btnRestart.Enabled = true;
                btnStart.Enabled = false;
            }
        }
    }

    public class Flags
    {
        private string _sName;
        private string _imgSource;
        public Flags()
        {
            _sName = "";
            _imgSource = "";
        }
        public string Name
        {
            get { return _sName; }
            set { _sName = value; }
        }
        public string ImageSource
        {
            get { return _imgSource; }
            set { _imgSource = value; }
        }
    }

    public class Time
    {
        private int iHour = 0;
        private int iMinute = 0;
        private int iSecond = 0;

        public Time()
        {
            iHour = iMinute = iSecond = 0;
        }
        //public Time(int h, int m, int s)
        //{
        //    iHour = h;
        //    iMinute = m;
        //    iSecond = s;
        //}

        public int Hour
        {
            get { return iHour; }
            set { iHour = value; }
        }
        public int Minute
        {
            get { return iMinute; }
            set {
                if (value >= 60)
                {
                    iHour = value / 60;
                    iMinute = value % 60;
                }
                else
                    iMinute = value;
            }
        }
        public int Second
        {
            get { return iSecond; }
            set
            {
                if (value >= 60)
                {
                    iMinute = value / 60;
                    iSecond = value % 60;
                }
                else
                    iSecond = value;
            }
        }
        public string getStringHour()
        {
            string str = "";
            if (iHour < 10)
            {
                str = str + "0" + iHour.ToString();
            }
            return str;
        }
        public string getStringMinute()
        {
            string str = "";
            if (iMinute < 10)
            {
                str = str + "0" + iMinute.ToString();
            }
            return str;
        }
        public string getStringSecond()
        {
            string str = "";
            if (iSecond < 10)
            {
                str = "0" + iSecond.ToString();
            }
            else
                str = iSecond.ToString();
            return str;
        }

        public int ToSecond()
        {
            int s = iHour * 3600 + iMinute * 60 + iSecond;
            return s;
        }

        public static Time operator -- (Time root)
        {
            if (root.Second - 1 < 0)
            {
                root.Second = 0;
                if (root.Minute - 1 < 0)
                {
                    root.Minute = 0;
                    if (root.Hour < 0)
                        root.Hour = 0;
                }
                else
                {
                    root.Minute -= 1;
                }
            }
            else
            {
                root.Second -= 1;
            }

            return root;
        }
    }
}
