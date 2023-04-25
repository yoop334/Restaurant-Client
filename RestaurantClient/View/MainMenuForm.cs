using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RestaurantClient.Controllers;

namespace RestaurantClient.View;

public partial class MainMenuForm : Form
{
    private readonly MainController _controller;
    private readonly List<Button> _buttonList = new();

    public MainMenuForm(MainController controller)
    {
        InitializeComponent();
        _controller = controller;
        
        panelContent.Controls.Add(new HomeForm());
        _buttonList.AddRange(new List<Button> {button2, buttonBookTable, buttonMyBookings, button5, buttonHome, buttonMyAccount});
        SelectButton(buttonHome);
    }

    private void buttonHome_click(object sender, EventArgs e)
    {
        SelectButton(buttonHome);
        panelContent.Controls.Clear();
        panelContent.Controls.Add(new HomeForm());
    }

    private void buttonMyAccount_Click(object sender, EventArgs e)
    {
        SelectButton(buttonMyAccount);
        panelContent.Controls.Clear();
        panelContent.Controls.Add(new ProfileForm(_controller));
    }
    private void buttonBookTable_Click(object sender, EventArgs e)
    {
        SelectButton(buttonBookTable);
        panelContent.Controls.Clear();
        panelContent.Controls.Add(new BookTableForm(_controller));
    }    
    
    private void buttonMyBookings_Click(object sender, EventArgs e)
    {
        SelectButton(buttonMyBookings);
        panelContent.Controls.Clear();
        panelContent.Controls.Add(new MyBookingsForm(_controller));
    }

    private void SelectButton(Control selectedButton)
    {
        _buttonList.ForEach(button => { button.BackColor = Color.FromArgb(41, 39, 40); });
        selectedButton.BackColor = Color.FromArgb(0, 117, 214);
    }
}