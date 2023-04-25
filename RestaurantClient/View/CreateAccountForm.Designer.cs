using System.ComponentModel;

namespace RestaurantClient.View;

partial class CreateAccountForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.label1 = new System.Windows.Forms.Label();
        this.textBoxUsername = new System.Windows.Forms.RichTextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.textBoxPassword = new System.Windows.Forms.RichTextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.textBoxLastName = new System.Windows.Forms.RichTextBox();
        this.textBoxFirstName = new System.Windows.Forms.RichTextBox();
        this.buttonCreateAccount = new System.Windows.Forms.Button();
        this.buttonBackToLogin = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(12, 64);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(145, 19);
        this.label1.TabIndex = 0;
        this.label1.Text = "Nume de utilizator:";
        // 
        // textBoxUsername
        // 
        this.textBoxUsername.Location = new System.Drawing.Point(12, 86);
        this.textBoxUsername.Name = "textBoxUsername";
        this.textBoxUsername.Size = new System.Drawing.Size(307, 47);
        this.textBoxUsername.TabIndex = 1;
        this.textBoxUsername.Text = "";
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(12, 151);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(145, 19);
        this.label2.TabIndex = 2;
        this.label2.Text = "Parola:";
        // 
        // textBoxPassword
        // 
        this.textBoxPassword.Location = new System.Drawing.Point(12, 173);
        this.textBoxPassword.Name = "textBoxPassword";
        this.textBoxPassword.Size = new System.Drawing.Size(307, 47);
        this.textBoxPassword.TabIndex = 3;
        this.textBoxPassword.Text = "";
        // 
        // label3
        // 
        this.label3.Location = new System.Drawing.Point(12, 245);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(145, 19);
        this.label3.TabIndex = 4;
        this.label3.Text = "Nume:";
        // 
        // label4
        // 
        this.label4.Location = new System.Drawing.Point(12, 342);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(145, 19);
        this.label4.TabIndex = 5;
        this.label4.Text = "Prenume:";
        // 
        // textBoxLastName
        // 
        this.textBoxLastName.Location = new System.Drawing.Point(12, 267);
        this.textBoxLastName.Name = "textBoxLastName";
        this.textBoxLastName.Size = new System.Drawing.Size(307, 47);
        this.textBoxLastName.TabIndex = 6;
        this.textBoxLastName.Text = "";
        // 
        // textBoxFirstName
        // 
        this.textBoxFirstName.Location = new System.Drawing.Point(12, 364);
        this.textBoxFirstName.Name = "textBoxFirstName";
        this.textBoxFirstName.Size = new System.Drawing.Size(307, 47);
        this.textBoxFirstName.TabIndex = 7;
        this.textBoxFirstName.Text = "";
        // 
        // buttonCreateAccount
        // 
        this.buttonCreateAccount.Location = new System.Drawing.Point(98, 434);
        this.buttonCreateAccount.Name = "buttonCreateAccount";
        this.buttonCreateAccount.Size = new System.Drawing.Size(134, 38);
        this.buttonCreateAccount.TabIndex = 8;
        this.buttonCreateAccount.Text = "Creeaza cont";
        this.buttonCreateAccount.UseVisualStyleBackColor = true;
        this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
        // 
        // buttonBackToLogin
        // 
        this.buttonBackToLogin.Location = new System.Drawing.Point(98, 478);
        this.buttonBackToLogin.Name = "buttonBackToLogin";
        this.buttonBackToLogin.Size = new System.Drawing.Size(134, 38);
        this.buttonBackToLogin.TabIndex = 9;
        this.buttonBackToLogin.Text = "Inapoi";
        this.buttonBackToLogin.UseVisualStyleBackColor = true;
        this.buttonBackToLogin.Click += new System.EventHandler(this.buttonBackToLogin_Click);
        // 
        // CreateAccountForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(232)))));
        this.ClientSize = new System.Drawing.Size(359, 524);
        this.Controls.Add(this.buttonBackToLogin);
        this.Controls.Add(this.buttonCreateAccount);
        this.Controls.Add(this.textBoxFirstName);
        this.Controls.Add(this.textBoxLastName);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.textBoxPassword);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.textBoxUsername);
        this.Controls.Add(this.label1);
        this.Name = "CreateAccountForm";
        this.Text = "CreateAccountForm";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RichTextBox textBoxPassword;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RichTextBox textBoxLastName;
    private System.Windows.Forms.RichTextBox textBoxFirstName;
    private System.Windows.Forms.Button buttonCreateAccount;
    private System.Windows.Forms.Button buttonBackToLogin;

    private System.Windows.Forms.RichTextBox textBoxUsername;

    private System.Windows.Forms.Label label1;

    #endregion
}