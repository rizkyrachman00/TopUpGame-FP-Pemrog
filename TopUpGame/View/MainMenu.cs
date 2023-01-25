using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace TopUpGame
{
    public partial class MainMenu : Form
    {

        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //constructor
        public MainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //form
            this.Text=string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered= true;
            this.MaximizedBounds=Screen.FromHandle(this.Handle).WorkingArea;
        }

        //structs
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(112, 224, 0);
            public static Color color2 = Color.FromArgb(255, 143, 163);
            public static Color color3 = Color.FromArgb(243, 222, 44);
        }

        //methods
        private void ActivateButton(object senderBtn,Color color)
        {
            if(senderBtn!= null)
            {
                DisableButton();
                //button
                currentBtn=(IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(90, 24, 154);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor= color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor= color;
                leftBorderBtn.Location= new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon current child form
                iconCurrentChildForm.IconChar= currentBtn.IconChar;
                iconCurrentChildForm.IconColor= color;
            }
        }

        private void DisableButton()
        { 
            if(currentBtn!=null)
            {

                currentBtn.BackColor = Color.FromArgb(36, 0, 70);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm=childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag=childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }

        private void btnGameList_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            OpenChildForm(new ListGame());
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
            OpenChildForm(new Pembelian());

        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            OpenChildForm(new RiwayatPembelian());

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible= false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(255, 225, 168); 
            lblTitleChildForm.Text= "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
            {
                WindowState= FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin(); 
            login.ShowDialog(); 
            
        }
    }
}