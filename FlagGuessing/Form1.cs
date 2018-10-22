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
using System.Xml;


namespace FlagGuessing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region global Variable

        string xmlHighScoreFileName = "highScore.xml";

        List<Flags> listFlags = new List<Flags>();
        private bool isStarted = false;
        int nQuestion = -1, posTrue = -1;
        string strQuestion = "Đâu là lá cờ của ";

        Time totalTime = new Time(0, 0, 5);

        const int markPerSecond = 10;

        int currentRound = 1, totalRound = 10;

        User currentUser = new User();

        #endregion

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
            this.Height = 550;

            lbTitle.Top = 50;

            // SET POSITION FOR 2 PANELS
            PanelGamePlay.Left = 0;
            PanelGamePlay.Top = 100;
            PanelGamePlay.Width = System.Convert.ToInt32(System.Math.Floor(this.Width * 0.64));
            PanelControl.Left = PanelGamePlay.Width;
            PanelControl.Top = PanelGamePlay.Top;
            PanelControl.Width = this.Width - PanelGamePlay.Width;
            PanelGamePlay.Height = this.Height - PanelGamePlay.Top;
            PanelControl.Height = PanelGamePlay.Height;

            txtTimes.Text = currentRound.ToString() + "/" + totalRound.ToString();
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

        

        private void RoundPlaying()
        {
            nQuestion = RandomQuestion();
            posTrue = RandomFlagsToPictureBox(nQuestion);
            lbQuestion.Text = strQuestion + listFlags[nQuestion].Name + " ?";

            txtTimes.Text = currentRound.ToString() + "/" + totalRound.ToString();
        }

        Time timeLeft = new Time();
        private void Clock_Tick(object sender, EventArgs e)
        {
            if (timeLeft.ToSecond() > 0)
            {
                timeLeft--;
                lbMinutes.Text = timeLeft.getStringMinute();
                lbSeconds.Text = timeLeft.getStringSecond();
            }
            else
            {
                if (currentRound < totalRound)
                {
                    currentRound++;
                    RoundPlaying();
                    timeLeft.assign(totalTime);
                    lbMinutes.Text = timeLeft.getStringMinute();
                    lbSeconds.Text = timeLeft.getStringSecond();
                    Clock.Start();
                }
                else
                {
                    // end match
                    isStarted = false;

                    btnChoose1.Enabled = false;
                    btnChoose2.Enabled = false;
                    lb_notification.Text = "Ván chơi kết thúc !";
                }
            }
        }

        private void btnChoose1_Click(object sender, EventArgs e)
        {
            Clock.Stop();
            if (posTrue == 1)
            {
                double percent = Convert.ToDouble(timeLeft.ToSecond()) / totalTime.ToSecond();
                int mark = Convert.ToInt32(System.Math.Floor(markPerSecond * percent));
                int oldMark = Convert.ToInt32(txtScore.Text);
                txtScore.Text = (oldMark + mark).ToString();
            }
            if (currentRound < totalRound)
            {
                currentRound++;
                RoundPlaying();
                timeLeft.assign(totalTime);
                lbMinutes.Text = timeLeft.getStringMinute();
                lbSeconds.Text = timeLeft.getStringSecond();
                Clock.Start();
            }
            else
            {
                // end match
                isStarted = false;

                btnChoose1.Enabled = false;
                btnChoose2.Enabled = false;
                lb_notification.Text = "Ván chơi kết thúc !";
            }
        }

        private void btnChoose2_Click(object sender, EventArgs e)
        {
            Clock.Stop();
            if (posTrue == 2)
            {
                double percent = Convert.ToDouble(timeLeft.ToSecond()) / totalTime.ToSecond();
                int mark = Convert.ToInt32(System.Math.Floor(markPerSecond * percent));
                int oldMark = Convert.ToInt32(txtScore.Text);
                txtScore.Text = (oldMark + mark).ToString();
            }
            if (currentRound < totalRound)
            {
                currentRound++;
                RoundPlaying();
                timeLeft.assign(totalTime);
                lbMinutes.Text = timeLeft.getStringMinute();
                lbSeconds.Text = timeLeft.getStringSecond();
                Clock.Start();
            }
            else
            {
                // end match
                isStarted = false;

                btnChoose1.Enabled = false;
                btnChoose2.Enabled = false;
                lb_notification.Text = "Ván chơi kết thúc !";
            }
        }

        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //txtPlayer.Text = "Hiếu";
            //MessageBox.Show("aaaa");

            using (FormChangeName changeName = new FormChangeName())
            {
                if (changeName.ShowDialog() == DialogResult.OK)
                {
                    txtPlayer.Text = changeName.getInputName();
                }
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtPlayer.Text.Length == 0)
            {
                using (FormChangeName changeName = new FormChangeName())
                {
                    if (changeName.ShowDialog() == DialogResult.OK)
                    {
                        txtPlayer.Text = changeName.getInputName();
                    }
                }
            }
            else
            {
                if (isStarted == false)
                {
                    currentRound = 1;

                    // khơi tạo câu hỏi ban đầu
                    RoundPlaying();
                    timeLeft.assign(totalTime);
                    lbMinutes.Text = timeLeft.getStringMinute();
                    lbSeconds.Text = timeLeft.getStringSecond();
                    Clock.Start();

                    isStarted = true;
                    btnChoose1.Enabled = true;
                    btnChoose2.Enabled = true;
                    btnRestart.Enabled = true;
                    btnStart.Enabled = false;
                }
            }
                
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // dừng countdown, xoá time
            Clock.Stop();
            lbMinutes.Text = "00";
            lbSeconds.Text = "00";
            // lưu điểm
            DialogResult saveScore = MessageBox.Show("Bạn có muốn lưu điểm?","Thông báo",
                MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (saveScore == DialogResult.Yes)  // nếu lưu
            {
                currentUser.Name = txtPlayer.Text;
                currentUser.Score = Convert.ToInt32(txtScore.Text);

                XmlScoreUser XmlsaveScore = new XmlScoreUser();

                // check file có tồn tại hay không?
                // Nếu không tồn tại thì trực tiếp ghi ra file
                // ngược lại thì đọc file trước

                if (System.IO.File.Exists(xmlHighScoreFileName) == true)
                {
                    XmlsaveScore.ReadUserScore();
                }

                XmlsaveScore.addUser(currentUser);

                XmlsaveScore.WriteUserScore();
            }

            // xoá lượt chơi, xoá notify, xoá điểm số, xoá pictureBox, xoá câu hỏi
            currentRound = 1;
            txtTimes.Text = currentRound.ToString() + "/" + totalRound.ToString();
            lb_notification.Text = "";
            txtScore.Text = "0";

            pictureBox1.Image = null;
            pictureBox2.Image = null;

            lbQuestion.Text = "";


            // enable button start và disable button restart
            isStarted = false;
            btnStart.Enabled = true;
            btnRestart.Enabled = false;
            btnChoose1.Enabled = false;
            btnChoose2.Enabled = false;
        }
    }

    public class XmlScoreUser
    {
        private List<User> _listUser;

        public List<User> ListUser { get => _listUser; set => _listUser = value; }

        private const string xmlHighScoreFileName = "highScore.xml";

        public XmlScoreUser()
        {
            _listUser = new List<User>();
        }

        // tối đa 5 user

        private void SortDecreaseScore()
        {
            for (int i = 0; i < _listUser.Count - 1; i++)
            {
                for (int j = i; j < _listUser.Count; j++)
                {
                    if (_listUser[i].Score < _listUser[j].Score)
                    {
                        User tmp = new User();
                        tmp = _listUser[i];
                        _listUser[i] = _listUser[j];
                        _listUser[j] = tmp;
                    }
                }
            }
        }

        public void addUser(User usr)
        {
            bool isChanged = false;
            if (_listUser.Count > 0)
            {
                for (int i = 0; i < _listUser.Count; i++)
                {
                    if (_listUser[i].Name == usr.Name)
                    {
                        if (_listUser[i].Score < usr.Score)
                        {
                            _listUser[i].Score = usr.Score;
                            isChanged = true;
                        }
                    }
                }
                if (isChanged == false)
                {
                    _listUser.Add(usr);
                }
            }
            else
            {
                _listUser.Add(usr);
            }

            this.SortDecreaseScore();
        }

        public void ReadUserScore()
        {
            XmlReader xmlReader = XmlReader.Create(xmlHighScoreFileName);

            while (!xmlReader.EOF)
            {
                if (xmlReader.MoveToContent() == XmlNodeType.Element && xmlReader.Name == "User")
                {
                    User usr = new User();

                    usr.Score = Convert.ToInt32(xmlReader.GetAttribute("Score"));

                    usr.Name = xmlReader.ReadElementContentAsString();
                    
                    _listUser.Add(usr);
                }
                else
                {
                    xmlReader.Read();
                }
            }


            this.SortDecreaseScore();

            xmlReader.Close();
        }

        public void WriteUserScore()
        {
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;

            XmlWriter xmlWriter = XmlWriter.Create(xmlHighScoreFileName, xmlWriterSettings);

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("HighScore");

            int count = 0;
            foreach (var user in _listUser)
            {
                if (count == 5)  // ghi tối đa 5 thằng thôi
                {
                    break;
                }

                xmlWriter.WriteStartElement("User");
                xmlWriter.WriteAttributeString("Score", user.Score.ToString());
                xmlWriter.WriteString(user.Name);
                xmlWriter.WriteEndElement();

                count++;
            }

            xmlWriter.Close();
        }
    }

    public class User
    {
        private string _name;
        private int _score;
        
        public User()
        {
            _name = "";
            _score = 0;
        }

        public string Name { get => _name; set => _name = value; }
        public int Score { get => _score; set => _score = value; }
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
        public Time(int h, int m, int s)
        {
            iHour = h;
            iMinute = m;
            iSecond = s;
        }

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
            if (root.ToSecond() % 60 == 0)
            {
                root.Second = 59;

                if (root.Hour >= 1)
                {
                    if (root.Minute == 0)
                    {
                        root.Minute = 59;
                        root.Hour -= 1;
                    }
                    else
                    {
                        root.Minute -= 1;
                    }
                }
                else
                {
                    if (root.Minute > 0)
                    {
                        root.Minute -= 1;
                    }
                }
            }
            else
                root.Second -= 1;

            return root;
        }

        public void assign(Time t1)
        {
            this.Hour = t1.Hour;
            this.Minute = t1.Minute;
            this.Second = t1.Second;
        }
    }
}
