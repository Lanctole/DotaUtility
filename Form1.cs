using DotaUtility.HotKeys;
using DotaUtility.ScreenWorkers;
using System.Runtime.InteropServices;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DotaUtility
{
    public partial class Form1 : Form
    {
        KeyboardHook hook1 = new  KeyboardHook();
        KeyboardHook hook2 = new KeyboardHook();
        private int HotKeyLinePositionX = 10;
        private int HotKeyLinePositionY = 10;

        public Form1()
        {
            InitializeComponent();
            HotKeyWorker.InitializeKeys(this);
            HotKeyWorker.AddToView();

            hook1.KeyPressed += new EventHandler<KeyPressedEventArgs>(Hooks.Screenshot);
            hook1.RegisterHotKey(
                (ModifierKeys)1,
                Keys.P);

            hook2.KeyPressed += new EventHandler<KeyPressedEventArgs>(Hooks.Timer);
            hook2.RegisterHotKey(
                (ModifierKeys)1,
                Keys.R);
   
        }

        public  void CreateHotKeyLine(Options option)
        {
            TextBox newDescriptionTextBox = new TextBox();
            ComboBox newModifierKeysComboBox = new ComboBox();
            TextBox newKeyTextBox = new TextBox();
            TextBox newTimerTextBox = new TextBox();
            Label newSpacingLabel = new Label();

            newDescriptionTextBox.Text = option.Description;
            //newModifierKeysComboBox.SelectedItem = option.ModifierKeys;
            newModifierKeysComboBox.DataSource =  Enum.GetValues(typeof(ModifierKeys));;
            newKeyTextBox.Text = option.Key.ToString();
            newTimerTextBox.Text = option.Timer.Interval.ToString();

            
            newDescriptionTextBox.Location = new Point(HotKeyLinePositionX, HotKeyLinePositionY);
            newModifierKeysComboBox.Location = new Point(newDescriptionTextBox.Right + 10, HotKeyLinePositionY);
            newKeyTextBox.Location = new Point(newModifierKeysComboBox.Right + 10, HotKeyLinePositionY);
            newTimerTextBox.Location = new Point(newKeyTextBox.Right + 10, HotKeyLinePositionY);
            newSpacingLabel.Location = new Point(newTimerTextBox.Right + 10, HotKeyLinePositionY);
            Controls.Add(newDescriptionTextBox);
            Controls.Add(newModifierKeysComboBox);
            Controls.Add(newKeyTextBox);
            Controls.Add(newTimerTextBox);
            Controls.Add(newSpacingLabel);

            HotKeyLinePositionY += newDescriptionTextBox.Height + 10;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void dotaUtilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MakeScreen_Click(object sender, EventArgs e)
        {
           // RoshanTimer.Start();
        }
    }
}