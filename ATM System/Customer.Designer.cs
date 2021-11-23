
namespace ATM_System
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panlNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustName1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AccNoLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.checkBoxDeposit = new System.Windows.Forms.CheckBox();
            this.checkBoxWithdraw = new System.Windows.Forms.CheckBox();
            this.checkBoxTransfer = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMyBalance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxPin = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panlNav);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMyBalance);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // panlNav
            // 
            this.panlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panlNav.Location = new System.Drawing.Point(0, 148);
            this.panlNav.Name = "panlNav";
            this.panlNav.Size = new System.Drawing.Size(3, 250);
            this.panlNav.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CustName1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // CustName1
            // 
            this.CustName1.AutoSize = true;
            this.CustName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CustName1.Location = new System.Drawing.Point(53, 103);
            this.CustName1.Name = "CustName1";
            this.CustName1.Size = new System.Drawing.Size(79, 16);
            this.CustName1.TabIndex = 1;
            this.CustName1.Text = "CustName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(230, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Customer";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(592, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Search for something....";
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(914, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 25);
            this.Close.TabIndex = 5;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(471, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "My Balance";
            // 
            // AccNoLabel
            // 
            this.AccNoLabel.AutoSize = true;
            this.AccNoLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AccNoLabel.Location = new System.Drawing.Point(263, 225);
            this.AccNoLabel.Name = "AccNoLabel";
            this.AccNoLabel.Size = new System.Drawing.Size(135, 19);
            this.AccNoLabel.TabIndex = 7;
            this.AccNoLabel.Text = "01287193140103";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.customerNameLabel.Location = new System.Drawing.Point(264, 195);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(139, 28);
            this.customerNameLabel.TabIndex = 8;
            this.customerNameLabel.Text = "Abrar Khan";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.moneyLabel.Location = new System.Drawing.Point(497, 311);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(120, 32);
            this.moneyLabel.TabIndex = 9;
            this.moneyLabel.Text = "3303.00";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnRefresh.Location = new System.Drawing.Point(811, 255);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 35);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // checkBoxDeposit
            // 
            this.checkBoxDeposit.AutoSize = true;
            this.checkBoxDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxDeposit.Location = new System.Drawing.Point(818, 300);
            this.checkBoxDeposit.Name = "checkBoxDeposit";
            this.checkBoxDeposit.Size = new System.Drawing.Size(59, 17);
            this.checkBoxDeposit.TabIndex = 22;
            this.checkBoxDeposit.Text = "Deposit";
            this.checkBoxDeposit.UseVisualStyleBackColor = true;
            // 
            // checkBoxWithdraw
            // 
            this.checkBoxWithdraw.AutoSize = true;
            this.checkBoxWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxWithdraw.Location = new System.Drawing.Point(818, 325);
            this.checkBoxWithdraw.Name = "checkBoxWithdraw";
            this.checkBoxWithdraw.Size = new System.Drawing.Size(68, 17);
            this.checkBoxWithdraw.TabIndex = 23;
            this.checkBoxWithdraw.Text = "Withdraw";
            this.checkBoxWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxWithdraw.UseVisualStyleBackColor = true;
            // 
            // checkBoxTransfer
            // 
            this.checkBoxTransfer.AutoSize = true;
            this.checkBoxTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxTransfer.Location = new System.Drawing.Point(818, 350);
            this.checkBoxTransfer.Name = "checkBoxTransfer";
            this.checkBoxTransfer.Size = new System.Drawing.Size(62, 17);
            this.checkBoxTransfer.TabIndex = 24;
            this.checkBoxTransfer.Text = "Transfer";
            this.checkBoxTransfer.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button6.Image = global::ATM_System.Properties.Resources.sign_out1;
            this.button6.Location = new System.Drawing.Point(3, 525);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 40);
            this.button6.TabIndex = 1;
            this.button6.Text = "   Sign Out";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button4.Image = global::ATM_System.Properties.Resources.change;
            this.button4.Location = new System.Drawing.Point(0, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "   Change PIN";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Image = global::ATM_System.Properties.Resources.transfer;
            this.button3.Location = new System.Drawing.Point(0, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "   Transfer";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Image = global::ATM_System.Properties.Resources.withdraw;
            this.button2.Location = new System.Drawing.Point(0, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "   Widthdraw";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = global::ATM_System.Properties.Resources.deposit;
            this.button1.Location = new System.Drawing.Point(0, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "   Deposit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMyBalance
            // 
            this.btnMyBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyBalance.FlatAppearance.BorderSize = 0;
            this.btnMyBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBalance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMyBalance.Image = global::ATM_System.Properties.Resources.money;
            this.btnMyBalance.Location = new System.Drawing.Point(0, 144);
            this.btnMyBalance.Name = "btnMyBalance";
            this.btnMyBalance.Size = new System.Drawing.Size(186, 40);
            this.btnMyBalance.TabIndex = 1;
            this.btnMyBalance.Text = "   My Balance";
            this.btnMyBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyBalance.UseVisualStyleBackColor = true;
            this.btnMyBalance.Click += new System.EventHandler(this.btnMyBalance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM_System.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxPin
            // 
            this.checkBoxPin.AutoSize = true;
            this.checkBoxPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxPin.Location = new System.Drawing.Point(818, 375);
            this.checkBoxPin.Name = "checkBoxPin";
            this.checkBoxPin.Size = new System.Drawing.Size(78, 17);
            this.checkBoxPin.TabIndex = 25;
            this.checkBoxPin.Text = "Change Pin";
            this.checkBoxPin.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.checkBoxPin);
            this.Controls.Add(this.checkBoxTransfer);
            this.Controls.Add(this.checkBoxWithdraw);
            this.Controls.Add(this.checkBoxDeposit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.AccNoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CustName1;
        private System.Windows.Forms.Button btnMyBalance;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panlNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AccNoLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox checkBoxDeposit;
        private System.Windows.Forms.CheckBox checkBoxWithdraw;
        private System.Windows.Forms.CheckBox checkBoxTransfer;
        private System.Windows.Forms.CheckBox checkBoxPin;
    }
}