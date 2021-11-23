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

namespace ATM_System
{
    public partial class Admin : Form
    {
        Customer cut;
        string name;
        string pin;
        string accNO;
        double money;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Admin()
        {
            Console.WriteLine("Admin Classs COnstractor");
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = btnAddCust.Height;
            PnlNav.Top = btnAddCust.Top;
            PnlNav.Left = btnAddCust.Left;
            btnAddCust.BackColor = Color.FromArgb(46, 51, 73);
        }
        
        public string getCname()
        {
            return cut.getCName();
        }
        public string getCpass()
        {
            return cut.getCPassword();
        }
        public void CustomerShow()
        {
            cut.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            adNamelabel.Text = "Mike";

        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnAddCust.Height;
            PnlNav.Top = btnAddCust.Top;
            PnlNav.Left = btnAddCust.Left;
            btnAddCust.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnAddCust_Leave(object sender, EventArgs e)
        {
            btnAddCust.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you want to save it.", "Save Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                name = textName.Text;
                pin = textPIN.Text;
                accNO = textAccNO.Text;
                money = double.Parse(textPhNo.Text);
                cut = new Customer(name, pin, accNO, money);
                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
