using System;
using System.Windows.Forms;
using RestaurantClient.Controllers;

namespace RestaurantClient.View;

public partial class CreateAccountForm : Form
{
    private readonly MainController _controller;
    private readonly LoginForm _loginForm;
    
    public CreateAccountForm(MainController controller, LoginForm loginForm)
    {
        InitializeComponent();
        _controller = controller;
        _loginForm = loginForm;
    }

    private async void buttonCreateAccount_Click(object sender, EventArgs e)
    {
        if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "")
        {
            MessageBox.Show("Completati datele!");
            return;
        }

        var result = await _controller.CreateAccountAndLogin(textBoxUsername.Text, textBoxPassword.Text,
            textBoxFirstName.Text, textBoxLastName.Text);
        if (result)
        {
            new MainMenuForm(_controller).Show();
            Hide();
        }
        else
        {
            MessageBox.Show("Numele de utilizator exista deja!");
        }
    }

    private void buttonBackToLogin_Click(object sender, EventArgs e)
    {
        Hide();
        _loginForm.SetCreateAccountForm(this);
        _loginForm.Show();
    }
}