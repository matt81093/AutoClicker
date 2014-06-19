using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClicker
{

    public partial class Form1 : Form
    {
        bool clickatcursor = true;
        int clickamount = 0;
        int currentclick = 1;
        Point clickLocation = new Point(0, 0);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int START_HOTKEY = 1;
        const int STOP_HOTKEY = 2;
        const int SELECT_HOTKEY = 3;

        public Form1()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, START_HOTKEY, 0, (int)Keys.F1);
            RegisterHotKey(this.Handle, STOP_HOTKEY, 0, (int)Keys.F2);
            RegisterHotKey(this.Handle, SELECT_HOTKEY, 0, (int)Keys.F3);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == START_HOTKEY)
            {
                start();
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == STOP_HOTKEY)
            {
                stop();
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == SELECT_HOTKEY)
            {
                clickLocation = Cursor.Position;
                string locationstring = clickLocation.ToString();
                coordlabel.Text = (locationstring.Remove(locationstring.Length - 1)).Remove(0, 1);
            }
            base.WndProc(ref m);
        }

        public void start()
        {
            if (clicktimer.Enabled == true)
            {
                MessageBox.Show("Autoclicker already running", "Already running");
            }
            else
            {
                bool intervalerror = false;
                bool amounterror = false;
                int timerinterv = 1000;
                currentclick = 0;
                try
                {
                    timerinterv = Convert.ToInt32(clickintervaltext.Text);
                }
                catch
                {
                    intervalerror = true;
                }
                try
                {
                    clickamount = Convert.ToInt32(amounttext.Text);
                }
                catch
                {
                    amounterror = true;
                }
                if (intervalerror == false)
                {
                    if (amounterror == false)
                    {
                        if (cursorrbut.Checked == true)
                        {
                            clickatcursor = true;
                        }
                        else
                        {
                            clickatcursor = false;
                        }
                        statuslabel.Text = "Clicking ... ";
                        //disable buttons
                        cursorrbut.Enabled = false;
                        fixedrbut.Enabled = false;
                        amounttext.Enabled = false;
                        clickintervaltext.Enabled = false;
                        clicktimer.Interval = timerinterv;
                        clicktimer.Start();
                    }
                    else
                    {
                        MessageBox.Show("Invalid click amount enetered", "Invalid click amount");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid time interval enetered", "Invalid interval");
                }
            }
        }

        public void stop()
        {
            if (clicktimer.Enabled == true)
            {
                //reenable buttons
                cursorrbut.Enabled = true;
                fixedrbut.Enabled = true;
                amounttext.Enabled = true;
                clickintervaltext.Enabled = true;
                clicktimer.Stop();
                statuslabel.Text = "Not Clicking";
            }
            else
            {
                MessageBox.Show("AutoClicker is not running", "Not running");
            }
        }

        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        //input type constant
        const int INPUT_MOUSE = 0;

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };

        private void clicktimer_Tick(object sender, EventArgs e)
        {
            if (clickamount == 0)
            {
                if (clickatcursor == true)
                {
                    clickatcur();
                }
                else
                {
                    Cursor.Position = clickLocation;
                    clickatcur();
                }
            }
            else
            {
                if (clickatcursor == true)
                {
                    clickatcur();
                }
                else
                {
                    Cursor.Position = clickLocation;
                    clickatcur();
                }
                currentclick++;
                if (currentclick == clickamount)
                {
                    stop();
                }
            }
        }

        public void clickatcur()
        {
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            start();
        }

        private void stopbut_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Orphamiel\n\nContact Email : orphamiel@yahoo.com", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clickintervaltext_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if input is number or remove
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void amounttext_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if input is number or remove
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

    }
}
