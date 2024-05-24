using System.Windows.Forms;

namespace LethalCompanyLauncher
{
    public partial class SettingsForm : Form
    {
        MainForm mf;

        public SettingsForm(MainForm mf)
        {
            this.mf = mf;
            TopLevel = false;
            Dock = DockStyle.Fill;
            InitializeComponent();
            onClose.SelectedIndex = 1;
            onStart.SelectedIndex = 1;
        }

        private void trackBar1_Scroll(object sender, System.EventArgs e) => mf.Opacity = (float)tb_opacity.Value / 100f;
    }
}
