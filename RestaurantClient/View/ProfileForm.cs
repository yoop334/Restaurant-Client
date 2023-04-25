using System;
using System.Windows.Forms;
using RestaurantClient.Controllers;

namespace RestaurantClient.View;

public partial class ProfileForm : UserControl
{
    private readonly MainController _controller;
    public ProfileForm(MainController controller)
    {
        InitializeComponent();
        _controller = controller;
    }

    private async void buttonLogout_Click(object sender, EventArgs e)
    {
        var result = await _controller.Logout();

        if (result)
        {
            // var panel = (Panel)Parent;
            // var mainMenuForm = (MainMenuForm)panel.Parent;
            // mainMenuForm.Close();
            Application.Exit();
        }
        else
        {
            MessageBox.Show("Error logout!");
        }
    }
}