using System.ComponentModel;

namespace RestaurantClient.View;

partial class MyBookingsForm
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.bookingsGridView = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.bookingsGridView)).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(72, 54);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(196, 34);
        this.label1.TabIndex = 0;
        this.label1.Text = "Urmatoarele rezervari:";
        // 
        // bookingsGridView
        // 
        this.bookingsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.bookingsGridView.Location = new System.Drawing.Point(73, 122);
        this.bookingsGridView.Name = "bookingsGridView";
        this.bookingsGridView.RowTemplate.Height = 28;
        this.bookingsGridView.Size = new System.Drawing.Size(1008, 456);
        this.bookingsGridView.TabIndex = 1;
        // 
        // MyBookingsForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(232)))));
        this.Controls.Add(this.bookingsGridView);
        this.Controls.Add(this.label1);
        this.Name = "MyBookingsForm";
        this.Size = new System.Drawing.Size(1166, 652);
        ((System.ComponentModel.ISupportInitialize)(this.bookingsGridView)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView bookingsGridView;

    private System.Windows.Forms.Label label1;

    #endregion
}