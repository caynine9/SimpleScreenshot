using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Gma.System.MouseKeyHook;

namespace SimpleScreenshot
{
    public partial class Form1 : Form
    {
        private IKeyboardMouseEvents m_GlobalHook;

        public Form1()
        {
            InitializeComponent();

            Subscribe();
        }

        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += GlobalHookKeyDown;
        }

        private void GlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PrintScreen)
            {
                CaptureScreenshot(null, null);
            }
        }

        public void Unsubscribe()
        {
            m_GlobalHook.KeyDown -= GlobalHookKeyDown;

            m_GlobalHook.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private async void CaptureScreenshot(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("CaptureScreenshot called");

                this.Hide();
                await Task.Delay(500);

                using (Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb))
                {
                    using (Graphics graphics = Graphics.FromImage(screenshot))
                    {
                        graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

                        pictureBox1.Image?.Dispose();

                        pictureBox1.Image = (Bitmap)screenshot.Clone();

                        string timestamp = DateTime.Now.ToString("MMddHHmmss");
                        screenshot.Save($"screenshot_{timestamp}.png", ImageFormat.Png);
                    }

                }

                this.Show();

                Debug.WriteLine("CaptureScreenshot finished");

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CaptureScreenshot method failed with error: {ex.Message}");
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Unsubscribe();
        }
    }
}
