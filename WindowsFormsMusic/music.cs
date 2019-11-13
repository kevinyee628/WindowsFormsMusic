using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMusic
{
    public partial class Music : MetroFramework.Forms.MetroForm
    {
        private PictureBox pictureBox1;
        private Button Play;
        private Button Stop;
        private Button LoadMusic;
        private Button CheckMusic;
        private Button MyPage;
        private ListView listView1;
        public Music()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.LoadMusic = new System.Windows.Forms.Button();
            this.CheckMusic = new System.Windows.Forms.Button();
            this.MyPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(245, 206);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.White;
            this.Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play.BackgroundImage")));
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Location = new System.Drawing.Point(75, 308);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(46, 49);
            this.Play.TabIndex = 4;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.White;
            this.Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop.BackgroundImage")));
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Location = new System.Drawing.Point(185, 308);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(46, 49);
            this.Stop.TabIndex = 5;
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // LoadMusic
            // 
            this.LoadMusic.BackColor = System.Drawing.Color.White;
            this.LoadMusic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoadMusic.FlatAppearance.BorderSize = 0;
            this.LoadMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadMusic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoadMusic.Location = new System.Drawing.Point(339, 79);
            this.LoadMusic.Name = "LoadMusic";
            this.LoadMusic.Size = new System.Drawing.Size(97, 29);
            this.LoadMusic.TabIndex = 8;
            this.LoadMusic.Text = "录入音乐";
            this.LoadMusic.UseVisualStyleBackColor = false;
            this.LoadMusic.Click += new System.EventHandler(this.LoadMusic_Click_1);
            // 
            // CheckMusic
            // 
            this.CheckMusic.BackColor = System.Drawing.Color.White;
            this.CheckMusic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CheckMusic.FlatAppearance.BorderSize = 0;
            this.CheckMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckMusic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CheckMusic.Location = new System.Drawing.Point(339, 144);
            this.CheckMusic.Name = "CheckMusic";
            this.CheckMusic.Size = new System.Drawing.Size(97, 29);
            this.CheckMusic.TabIndex = 9;
            this.CheckMusic.Text = "查看音乐";
            this.CheckMusic.UseVisualStyleBackColor = false;
            this.CheckMusic.Click += new System.EventHandler(this.CheckMusic_Click_1);
            // 
            // MyPage
            // 
            this.MyPage.BackColor = System.Drawing.Color.White;
            this.MyPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MyPage.FlatAppearance.BorderSize = 0;
            this.MyPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MyPage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MyPage.Location = new System.Drawing.Point(339, 210);
            this.MyPage.Name = "MyPage";
            this.MyPage.Size = new System.Drawing.Size(97, 29);
            this.MyPage.TabIndex = 10;
            this.MyPage.Text = "我的主页";
            this.MyPage.UseVisualStyleBackColor = false;
            this.MyPage.Click += new System.EventHandler(this.MyPage_Click_1);
            // 
            // Music
            // 
            this.ClientSize = new System.Drawing.Size(478, 416);
            this.Controls.Add(this.MyPage);
            this.Controls.Add(this.CheckMusic);
            this.Controls.Add(this.LoadMusic);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Music";
            this.Text = "BoseMusic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //TODO:播放音乐
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            //TODO:暂停音乐
        }
        private void LoadMusic_Click_1(object sender, EventArgs e)
        {
            //TODO:列出音乐
        }

        private void CheckMusic_Click_1(object sender, EventArgs e)
        {
            //TODO:录入音乐
        }

        private void MyPage_Click_1(object sender, EventArgs e)
        {
            //TODO:我的主页
        }
    }
}
