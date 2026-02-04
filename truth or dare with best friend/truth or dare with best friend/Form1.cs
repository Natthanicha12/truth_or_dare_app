using System;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace truth_or_dare_with_best_friend
{
    public partial class Form1 : Form
    {
        Panel pnlNav;
        Bitmap bg_truth = new Bitmap("D:\\Learn_C#\\Background_truth.png");
        Bitmap bg_dare = new Bitmap("D:\\Learn_C#\\Background_dare.png");

        Bitmap Bg_bt_truth = new Bitmap("D:\\Learn_C#\\Bg_bt_truth.png");
        Bitmap Bg_bt_dare = new Bitmap("D:\\Learn_C#\\Bg_bt_dare.png");

        string textFile_truth = @"D:\Learn_C#\truth.txt";
        string textFile_dare = @"D:\Learn_C#\dare.txt";

        int truth_dare;

       [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(

    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse

);
        Random rnd = new Random();
        List<int> randomPool = new List<int>();
        int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav = new Panel();
            pnlNav.Size = new Size(10, 50);
            pnlNav.BackColor = Color.Red;
            this.Controls.Add(pnlNav);

            pnlNav.Height = Truth.Height;
            pnlNav.Top = Truth.Top;
            Truth.BackColor = Color.FromArgb(255, 228, 181);

            Truth.FlatStyle = FlatStyle.Flat;
            Truth.FlatAppearance.BorderColor = Color.FromArgb(255, 228, 181);

            this.BackgroundImage = bg_truth;  // Form
            this.BackgroundImageLayout = ImageLayout.Stretch;

            button_t_d.Image = Bg_bt_truth;    // PictureBox

            panel2.BackColor = Color.LavenderBlush;
            panel3.BackColor = Color.LavenderBlush;

            Text_Eng1.Text = File.ReadAllLines(textFile_truth)[0];
            Text_Eng2.Text = File.ReadAllLines(textFile_truth)[1];
            Text_Eng3.Text = File.ReadAllLines(textFile_truth)[2];
            Text_Eng4.Text = File.ReadAllLines(textFile_truth)[3];
            Text_Eng5.Text = File.ReadAllLines(textFile_truth)[4];

            Text_thai1.Text = File.ReadAllLines(textFile_truth)[5];
            Text_thai2.Text = File.ReadAllLines(textFile_truth)[6];
            Text_thai3.Text = File.ReadAllLines(textFile_truth)[7];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetRandomPool();
        }

        private void Truth_Click(object sender, EventArgs e) // Truth
        {
            dare.BackColor = Color.Thistle;

            pnlNav.Height = Truth.Height;
            pnlNav.Top = Truth.Top;
            pnlNav.Left = Truth.Left;
            Truth.BackColor = Color.FromArgb(255, 228, 181);

            Truth.FlatStyle = FlatStyle.Flat;
            Truth.FlatAppearance.BorderColor = Color.FromArgb(255, 228, 181);

            this.BackgroundImage = bg_truth;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            button_t_d.Image = Bg_bt_truth;

            panel2.BackColor = Color.LavenderBlush;
            panel3.BackColor = Color.LavenderBlush;

            Text_Eng1.Text = File.ReadAllLines(textFile_truth)[0];
            Text_Eng2.Text = File.ReadAllLines(textFile_truth)[1];
            Text_Eng3.Text = File.ReadAllLines(textFile_truth)[2];
            Text_Eng4.Text = File.ReadAllLines(textFile_truth)[3];
            Text_Eng5.Text = File.ReadAllLines(textFile_truth)[4];

            Text_thai1.Text = File.ReadAllLines(textFile_truth)[5];
            Text_thai2.Text = File.ReadAllLines(textFile_truth)[6];
            Text_thai3.Text = File.ReadAllLines(textFile_truth)[7];

            Text_Eng1.BackColor = Color.LavenderBlush;
            Text_Eng2.BackColor = Color.LavenderBlush;
            Text_Eng3.BackColor = Color.LavenderBlush;
            Text_Eng4.BackColor = Color.LavenderBlush;
            Text_Eng5.BackColor = Color.LavenderBlush;
            Text_thai1.BackColor = Color.LavenderBlush;
            Text_thai2.BackColor = Color.LavenderBlush;
            Text_thai3.BackColor = Color.LavenderBlush;

            truth_dare = 0;
            ResetRandomPool();

        }
        private void dare_Click(object sender, EventArgs e)
        {
            Truth.BackColor = Color.LightPink;
            
            pnlNav.Height = dare.Height;
            pnlNav.Top = dare.Top;
            dare.BackColor = Color.FromArgb(255, 228, 181);

            dare.FlatStyle = FlatStyle.Flat;
            dare.FlatAppearance.BorderColor = Color.FromArgb(255, 228, 181);

            this.BackgroundImage = bg_dare;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            button_t_d.Image = Bg_bt_dare;

            panel2.BackColor = Color.MistyRose;
            panel3.BackColor = Color.MistyRose;

            Text_Eng1.Text = File.ReadAllLines(textFile_dare)[0];
            Text_Eng2.Text = File.ReadAllLines(textFile_dare)[1];
            Text_Eng3.Text = File.ReadAllLines(textFile_dare)[2];
            Text_Eng4.Text = File.ReadAllLines(textFile_dare)[3];
            Text_Eng5.Text = File.ReadAllLines(textFile_dare)[4];

            Text_thai1.Text = File.ReadAllLines(textFile_dare)[5];
            Text_thai2.Text = File.ReadAllLines(textFile_dare)[6];
            Text_thai3.Text = File.ReadAllLines(textFile_dare)[7];

            Text_Eng1.BackColor = Color.MistyRose;
            Text_Eng2.BackColor = Color.MistyRose;
            Text_Eng3.BackColor = Color.MistyRose;
            Text_Eng4.BackColor = Color.MistyRose;
            Text_Eng5.BackColor = Color.MistyRose;
            Text_thai1.BackColor = Color.MistyRose;
            Text_thai2.BackColor = Color.MistyRose;
            Text_thai3.BackColor = Color.MistyRose;

            truth_dare = 1;
            ResetRandomPool();
        }

        private void Truth_Leave(object sender, EventArgs e) // Truth
        {
           
        }

        private void dare_Leave(object sender, EventArgs e)
        {
          
        }


        private void button_t_d_Click(object sender, EventArgs e)
        {
            if (currentIndex >= randomPool.Count)
            {
                ResetRandomPool(); // ครบ 48 → เริ่มรอบใหม่
            }

            int randomNumber = randomPool[currentIndex];
            currentIndex++;

            int index2 = randomNumber * 8;
            int index1 = randomNumber * 8;

            if (truth_dare == 0)
            {
                Truth.BackColor = Color.Moccasin;
                dare.BackColor = Color.Thistle;

                Text_Eng1.Text = File.ReadAllLines(textFile_truth)[index1];
                Text_Eng2.Text = File.ReadAllLines(textFile_truth)[index1 + 1];
                Text_Eng3.Text = File.ReadAllLines(textFile_truth)[index1 + 2];
                Text_Eng4.Text = File.ReadAllLines(textFile_truth)[index1 + 3];
                Text_Eng5.Text = File.ReadAllLines(textFile_truth)[index1 + 4];

                Text_thai1.Text = File.ReadAllLines(textFile_truth)[index1 + 5];
                Text_thai2.Text = File.ReadAllLines(textFile_truth)[index1 + 6];
                Text_thai3.Text = File.ReadAllLines(textFile_truth)[index1 + 7];

            }
            else
            {
                dare.BackColor = Color.Moccasin;
                Truth.BackColor = Color.LightPink;

                Text_Eng1.Text = File.ReadAllLines(textFile_dare)[index2];
                Text_Eng2.Text = File.ReadAllLines(textFile_dare)[index2 + 1];
                Text_Eng3.Text = File.ReadAllLines(textFile_dare)[index2 + 2];
                Text_Eng4.Text = File.ReadAllLines(textFile_dare)[index2 + 3];
                Text_Eng5.Text = File.ReadAllLines(textFile_dare)[index2 + 4];

                Text_thai1.Text = File.ReadAllLines(textFile_dare)[index2 + 5];
                Text_thai2.Text = File.ReadAllLines(textFile_dare)[index2 + 6];
                Text_thai3.Text = File.ReadAllLines(textFile_dare)[index2 + 7];

            }


        }

        private void button_t_d_Leave(object sender, EventArgs e)
        {

        }

        private void closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Text_Eng_Click(object sender, EventArgs e)
        {

        }

        private void Text_thai_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void ResetRandomPool()
        {
            randomPool.Clear();

            for (int i = 0; i < 76; i++)
                randomPool.Add(i);

            // Shuffle
            for (int i = randomPool.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                int temp = randomPool[i];
                randomPool[i] = randomPool[j];
                randomPool[j] = temp;
            }

            currentIndex = 0;
        }
    }
}
