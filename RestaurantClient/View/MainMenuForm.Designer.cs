using System.Windows.Forms;

namespace RestaurantClient.View
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMyAccount = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonMyBookings = new System.Windows.Forms.Button();
            this.buttonBookTable = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.buttonMyAccount);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.buttonMyBookings);
            this.panel1.Controls.Add(this.buttonBookTable);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 825);
            this.panel1.TabIndex = 0;
            // 
            // buttonMyAccount
            // 
            this.buttonMyAccount.FlatAppearance.BorderSize = 0;
            this.buttonMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyAccount.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonMyAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMyAccount.Location = new System.Drawing.Point(0, 600);
            this.buttonMyAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMyAccount.Name = "buttonMyAccount";
            this.buttonMyAccount.Size = new System.Drawing.Size(277, 77);
            this.buttonMyAccount.TabIndex = 0;
            this.buttonMyAccount.Text = "Contul meu";
            this.buttonMyAccount.UseVisualStyleBackColor = true;
            this.buttonMyAccount.Click += new System.EventHandler(this.buttonMyAccount_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(0, 515);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(277, 77);
            this.button5.TabIndex = 0;
            this.button5.Text = "Despre noi";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonMyBookings
            // 
            this.buttonMyBookings.FlatAppearance.BorderSize = 0;
            this.buttonMyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyBookings.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonMyBookings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMyBookings.Location = new System.Drawing.Point(0, 429);
            this.buttonMyBookings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMyBookings.Name = "buttonMyBookings";
            this.buttonMyBookings.Size = new System.Drawing.Size(277, 77);
            this.buttonMyBookings.TabIndex = 0;
            this.buttonMyBookings.Text = "Rezervarile mele";
            this.buttonMyBookings.UseVisualStyleBackColor = true;
            this.buttonMyBookings.Click += new System.EventHandler(this.buttonMyBookings_Click);
            // 
            // buttonBookTable
            // 
            this.buttonBookTable.FlatAppearance.BorderSize = 0;
            this.buttonBookTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookTable.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonBookTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBookTable.Location = new System.Drawing.Point(0, 344);
            this.buttonBookTable.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBookTable.Name = "buttonBookTable";
            this.buttonBookTable.Size = new System.Drawing.Size(277, 77);
            this.buttonBookTable.TabIndex = 0;
            this.buttonBookTable.Text = "Rezervați o masă";
            this.buttonBookTable.UseVisualStyleBackColor = true;
            this.buttonBookTable.Click += new System.EventHandler(this.buttonBookTable_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 259);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 77);
            this.button2.TabIndex = 0;
            this.button2.Text = "Meniu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHome.Location = new System.Drawing.Point(0, 173);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(277, 77);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Acasă";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(280, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 15);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(395, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 155);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(3, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buon Appetito!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(669, 52);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(728, 52);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(787, 52);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContent.Location = new System.Drawing.Point(280, 173);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1166, 652);
            this.panelContent.TabIndex = 4;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1446, 825);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principală";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHome;
        private Label label1;
        private System.Windows.Forms.Button buttonMyAccount;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonMyBookings;
        private System.Windows.Forms.Button buttonBookTable;
        private System.Windows.Forms.Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;

        #endregion

    }
}