using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Windows.Forms;

namespace WindowsFormsMusic
{
    class MusiceMain
    {
        static Menu mainMenu = null;
        static MusicMenu musicMenu = null;
        static clsMCI cm = null;
        [STAThread]
        //static void Main()
        //{
        //    mainMenu = new Menu("主目录");
        //    musicMenu = new MusicMenu("音乐列表", -1);
        //    musicMenu.Ano = "上下箭头选择 Enter键播放/确认";

        //    mainMenu.addItem(new MenuItem(1, "录入音乐", LoadFiles));
        //    mainMenu.addItem(new MenuItem(2, "查看音乐", ShowFiles));
        //    mainMenu.addItem(new MenuItem(3, "删除音乐"));
        //    mainMenu.addItem(new MenuItem(4, "我的主页"));
        //    mainMenu.addItem(new MenuItem(5, "退出登录", Logout));

        //    mainMenu.Show();
        //}
        static void LoadFiles(MenuItem item)
        {
            FolderBrowserDialog df = new FolderBrowserDialog();
            df.ShowDialog();
            string selectPath = df.SelectedPath;
            if ("" == selectPath)
            {
                mainMenu.Show();
                return;
            }
            DirectoryInfo dInfo = new DirectoryInfo(selectPath);
            foreach (FileInfo f in dInfo.GetFiles("*.mp3"))
            {
                MusicFileService.Instance().AddFile(new MusicFile(f.Name, f.FullName, f.Length));
            }
            MusicFileService.Instance().Save();
            mainMenu.Show();
        }
        static void ShowFiles(MenuItem item)
        {
            musicMenu.Clear();

            List<MusicFile> files = MusicFileService.Instance().GetAllFiles();
            for (int i = 0; i < files.Count; i++)
            {
                musicMenu.addItem(new MenuItem(i, files[i].Name, playMusic));
            }
            musicMenu.addItem(new MenuItem(files.Count, "返回主菜单", returnMainMenu));
            musicMenu.addItem(new MenuItem(files.Count + 1, "下一首", nextPlay));
            musicMenu.addItem(new MenuItem(files.Count + 2, "停止播放", stopPlay));
            musicMenu.addItem(new MenuItem(files.Count + 3, "上一首", previousPlay));
            if (musicMenu.playingIndex != -1) musicMenu.CurrentItem = musicMenu.playingIndex;
            musicMenu.Show();
        }
        //播放音乐
        static void playMusic(MenuItem item)
        {
            //歌曲播放选中
            musicMenu.playingIndex = item.Id;
            //MessageBox.Show("播放音乐"+item.Name);
            MusicFile file = MusicFileService.Instance().FindFile(item.Name);
            if (null == file)
            {
                musicMenu.Show();
                return;
            }
            //停止旧的歌曲
            if (null != cm)
                cm.StopT();
            //播放
            cm = new clsMCI();
            cm.FileName = file.Path;
            cm.play();

            musicMenu.Show();
        }

        //返回主页面
        static void returnMainMenu(MenuItem item)
        {
            mainMenu.Show();
        }

        //停止播放
        static void stopPlay(MenuItem item)
        {
            if (null != cm)
                cm.StopT();
            musicMenu.playingIndex = -1;
            musicMenu.Show();
        }

        static void nextPlay(MenuItem item)
        {
            musicMenu.playingIndex = (musicMenu.playingIndex + 1) % (musicMenu.getItemSize() - 4);
            string name = musicMenu.getItemByIndex(musicMenu.playingIndex).Name;
            MusicFile file = MusicFileService.Instance().FindFile(name);
            if (cm != null)
                cm.StopT();
            cm = new clsMCI();
            cm.FileName = file.Path;
            cm.play();
            musicMenu.Show();
        }
        static void previousPlay(MenuItem item)
        {
            int size = musicMenu.getItemSize() - 4;
            musicMenu.playingIndex = (musicMenu.playingIndex + size - 1) % size;
            string name = musicMenu.getItemByIndex(musicMenu.playingIndex).Name;
            MusicFile file = MusicFileService.Instance().FindFile(name);
            if (cm != null)
                cm.StopT();
            cm = new clsMCI();
            cm.FileName = file.Path;
            cm.play();
            musicMenu.Show();
        }
        //退出
        static void Logout(MenuItem item)
        {
        }
    }
}
