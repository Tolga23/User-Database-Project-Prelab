using System;
using System.Windows.Forms;

namespace Prelab
{
    public partial class MainMenu : Form
    {
        Settings mySettings = Settings.MySettings();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void form2_settings_Click(object sender, EventArgs e)
        {
            Settings yeniform2 = new Settings();          // ayarlar sekmesine gitmek için
            yeniform2.Show();
        }

        private void form2_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();     // Çıkış için
        }

        private void admin_menu_Click(object sender, EventArgs e)
        {
            Admin_paneli a1 = new Admin_paneli();
            a1.Show();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Load last played settings defaults
            mySettings.Easy = 15;
            mySettings.Intermediate = 9;
            mySettings.Hard = 6;
            mySettings.Difficulty = Properties.Settings.Default.Difficulty;
            mySettings.Shape = Properties.Settings.Default.Shape;
            mySettings.Color = Properties.Settings.Default.Color;
            mySettings.Point = Properties.Settings.Default.Point;
            mySettings.CustomCol = Properties.Settings.Default.CusBox2;
            mySettings.CustomRow = Properties.Settings.Default.CusBox;

            if (Properties.Settings.Default.Custom == true)
            {
                if (mySettings.CustomCol != 0 || mySettings.CustomRow != 0)
                {
                    mySettings.Difficulty = mySettings.CustomRow;
                }
            }
       
        }

        private void menu_profil_Click(object sender, EventArgs e)
        {
            Profil_sayfasi p = new Profil_sayfasi();
            p.Show();
        }

        private void main_logout_Click(object sender, EventArgs e)
        {
            Login p = new Login();
            p.Show();
            this.Close();
        }

    }
}