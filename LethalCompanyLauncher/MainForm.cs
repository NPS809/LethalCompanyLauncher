using System;
using System.IO;
using System.Windows.Forms;

namespace LethalCompanyLauncher
{
    public partial class MainForm : Form
    {
        public string path = "";

        public string mods_offset = @"\BepInEx\plugins\";
        public string disabled_mods_offset = @"\BepInEx\disabled_plugins\";
        public string exe_offset = @"\Lethal Company.exe";

        public PlayForm pf;
        public SettingsForm sf;
        public ModsForm mf;

        public MainForm()
        {
            sf = new SettingsForm(this);
            pf = new PlayForm(this);
            mf = new ModsForm(this);

            

            InitializeComponent();
            btn_play_Click(null, null);
            UpdateAll();

            notifyIcon1.BalloonTipTitle = "LCLauncher";
            notifyIcon1.BalloonTipText = "Приложение свёрнуто";
            notifyIcon1.Text = "Lethal Company Launcher";

            notifyIcon1.ContextMenuStrip.Items.Add("Запустить игру");
            notifyIcon1.ContextMenuStrip.Items[0].Click += (sender, e) => pf.btn_play_Click(null, null);
            notifyIcon1.ContextMenuStrip.Items.Add("Открыть папку лаунчера / игры");
            notifyIcon1.ContextMenuStrip.Items[1].Click += (sender, e) => pf.btn_openDIrectory_Click(null, null); 
            notifyIcon1.ContextMenuStrip.Items.Add("Открыть папку с вкл. модами");
            notifyIcon1.ContextMenuStrip.Items[2].Click += (sender, e) => mf.btn_openEnMods_Click(null, null);
            notifyIcon1.ContextMenuStrip.Items.Add("Открыть папку с выкл. модами");
            notifyIcon1.ContextMenuStrip.Items[3].Click += (sender, e) => mf.btn_openDisMods_Click(null, null);
            notifyIcon1.ContextMenuStrip.Items.Add("Выйти");
            notifyIcon1.ContextMenuStrip.Items[4].Click += (sender, e) => Environment.Exit(0);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
            Environment.Exit(0);
        }

        #region Navigation Panel
        private void btn_play_Click(object sender, EventArgs e)
        {
            menupanel.Controls.Clear();
            menupanel.Controls.Add(pf);
            btn_play.Text = "> Играть";
            btn_mods.Text = "Моды";
            btn_settings.Text = "Настройки";
            pf.Show();
            mf.Hide();
            sf.Hide();
        }

        private void btn_mods_Click(object sender, EventArgs e)
        {
            menupanel.Controls.Clear();
            menupanel.Controls.Add(mf);
            btn_play.Text = "Играть";
            btn_mods.Text = "> Моды";
            btn_settings.Text = "Настройки";
            pf.Hide();
            mf.Show();
            sf.Hide();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            menupanel.Controls.Clear();
            menupanel.Controls.Add(sf);
            btn_play.Text = "Играть";
            btn_mods.Text = "Моды";
            btn_settings.Text = "> Настройки";
            pf.Hide();
            mf.Hide();
            sf.Show();
        }
        #endregion

        public void UpdateAll()
        {
            path = Environment.CurrentDirectory;
            if (File.Exists(path + exe_offset))
            {
                pf.btn_play.Visible = true;
                
                if (Directory.Exists(path + mods_offset))
                {
                    
                    if (!Directory.Exists(path + disabled_mods_offset))
                        Directory.CreateDirectory(path + disabled_mods_offset);
                    mf.list_enabledMods.Items.Clear();
                    mf.list_disabledMods.Items.Clear();
                    foreach (string file in Directory.GetFiles(path + mods_offset, "*.dll"))
                        mf.list_enabledMods.Items.Add(Path.GetFileName( file ));
                    foreach (string file in Directory.GetFiles(path + disabled_mods_offset, "*.dll"))
                        mf.list_disabledMods.Items.Add(Path.GetFileName( file ));
                    pf.txt_error.Visible = mf.txt_error.Visible = false;
                } else
                {
                    pf.txt_error.Visible = mf.txt_error.Visible = true;
                    pf.txt_error.Text = mf.txt_error.Text = "[!] Папка с модами не обнаружена";
                }
            } else
            {
                pf.btn_play.Visible = false;
                pf.txt_error.Visible = mf.txt_error.Visible = true;
                pf.txt_error.Text = mf.txt_error.Text = "[!] Файл запуска игры не обнаружен. Проверьте его существование и имя";

            }
            
        }

        public void HideInTaskBar()
        {
            WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
            Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sf.onClose.SelectedIndex == 0) {
                e.Cancel = true;
                HideInTaskBar();
            }
            
        }
    }
}
