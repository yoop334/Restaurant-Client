using System.ComponentModel;

namespace RestaurantClient.View;

partial class ProfileForm
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
        this.buttonLogout = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // buttonLogout
        // 
        this.buttonLogout.Location = new System.Drawing.Point(489, 473);
        this.buttonLogout.Name = "buttonLogout";
        this.buttonLogout.Size = new System.Drawing.Size(238, 67);
        this.buttonLogout.TabIndex = 0;
        this.buttonLogout.Text = "Logout";
        this.buttonLogout.UseVisualStyleBackColor = true;
        this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
        // 
        // ProfileForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.buttonLogout);
        this.Name = "ProfileForm";
        this.Size = new System.Drawing.Size(1166, 652);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonLogout;

    #endregion
}