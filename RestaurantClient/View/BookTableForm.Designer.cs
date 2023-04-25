using System.ComponentModel;

namespace RestaurantClient.View;

partial class BookTableForm
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
        this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
        this.label2 = new System.Windows.Forms.Label();
        this.buttonBookTable = new System.Windows.Forms.Button();
        this.label3 = new System.Windows.Forms.Label();
        this.comboBoxHour = new System.Windows.Forms.ComboBox();
        this.comboBoxPersons = new System.Windows.Forms.ComboBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(449, 191);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(49, 29);
        this.label1.TabIndex = 0;
        this.label1.Text = "Ziua";
        // 
        // dateTimePicker
        // 
        this.dateTimePicker.CustomFormat = "";
        this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateTimePicker.Location = new System.Drawing.Point(504, 186);
        this.dateTimePicker.Name = "dateTimePicker";
        this.dateTimePicker.Size = new System.Drawing.Size(142, 26);
        this.dateTimePicker.TabIndex = 1;
        this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(449, 252);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(134, 29);
        this.label2.TabIndex = 3;
        this.label2.Text = "Numar persoane";
        // 
        // buttonBookTable
        // 
        this.buttonBookTable.Location = new System.Drawing.Point(449, 374);
        this.buttonBookTable.Name = "buttonBookTable";
        this.buttonBookTable.Size = new System.Drawing.Size(186, 49);
        this.buttonBookTable.TabIndex = 6;
        this.buttonBookTable.Text = "Rezerva masa";
        this.buttonBookTable.UseVisualStyleBackColor = true;
        this.buttonBookTable.Click += new System.EventHandler(this.buttonBookTable_Click);
        // 
        // label3
        // 
        this.label3.Location = new System.Drawing.Point(449, 310);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(49, 29);
        this.label3.TabIndex = 7;
        this.label3.Text = "Ora";
        // 
        // comboBoxHour
        // 
        this.comboBoxHour.FormattingEnabled = true;
        this.comboBoxHour.Location = new System.Drawing.Point(504, 307);
        this.comboBoxHour.Name = "comboBoxHour";
        this.comboBoxHour.Size = new System.Drawing.Size(142, 28);
        this.comboBoxHour.TabIndex = 8;
        this.comboBoxHour.SelectedValueChanged += new System.EventHandler(this.comboBoxHour_SelectedValueChanged);
        // 
        // comboBoxPersons
        // 
        this.comboBoxPersons.FormattingEnabled = true;
        this.comboBoxPersons.Location = new System.Drawing.Point(589, 249);
        this.comboBoxPersons.Name = "comboBoxPersons";
        this.comboBoxPersons.Size = new System.Drawing.Size(57, 28);
        this.comboBoxPersons.TabIndex = 9;
        this.comboBoxPersons.SelectedValueChanged += new System.EventHandler(this.comboBoxPersons_SelectedValueChanged);
        // 
        // BookTableForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(232)))));
        this.Controls.Add(this.comboBoxPersons);
        this.Controls.Add(this.comboBoxHour);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.buttonBookTable);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.dateTimePicker);
        this.Controls.Add(this.label1);
        this.Name = "BookTableForm";
        this.Size = new System.Drawing.Size(1166, 652);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox comboBoxHour;
    private System.Windows.Forms.ComboBox comboBoxPersons;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Button buttonBookTable;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dateTimePicker;
    private System.Windows.Forms.Label label2;

    #endregion
}