using System;
using System.Drawing;
using System.Windows.Forms;

namespace GenshinImpactTool
{

    public partial class MainForm : Form
    {

        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);


        }

        private struct RGBColors
        {

            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(45, 200, 27);
            public static Color color8 = Color.FromArgb(120, 150, 240);
        }


        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 38, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            lblTitleChildForm.Text = "Dashboard";
            leftBorderBtn.Visible = false;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color2);
            //OpenChildForm(new frmPersonajes());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color8);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
            
            OpenChildForm(new frmDashboard());

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            OpenChildForm(new frmDashboard());
        }

    }
}
