using System;
using System.Windows.Forms;
using RestaurantClient.Controllers;

namespace RestaurantClient.View;

public partial class LoginForm : Form
{
    private readonly MainController _controller;
    private CreateAccountForm _createAccountForm;

    public LoginForm(MainController controller)
    {
        InitializeComponent();
        _controller = controller;
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        if (textUserName.Text == "" || textPassword.Text == "")
        {
            ShowMessageAndClearTextBox("Completati datele!");
            return;
        }

        var result = await _controller.Login(textUserName.Text, textPassword.Text);
        if (result)
        {
            new MainMenuForm(_controller).Show();
            Hide();
        }
        else
        {
            ShowMessageAndClearTextBox("Numele de utilizator sau parola introduse sunt incorecte!");
        }
    }

    private void ShowMessageAndClearTextBox(string message)
    {
        MessageBox.Show(message);
        textUserName.Clear();
        textPassword.Clear();
        textUserName.Focus();
    }

    private void labelExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void labelClearFields_Click(object sender, EventArgs e)
    {
        textUserName.Clear();
        textPassword.Clear();
        textUserName.Focus();
    }

    private void buttonCreateAccount_Click(object sender, EventArgs e)
    {
        if (_createAccountForm == null)
            new CreateAccountForm(_controller, this).Show();
        else
            _createAccountForm.Show();
        Hide();
    }

    public void SetCreateAccountForm(CreateAccountForm createAccountForm)
    {
        _createAccountForm = createAccountForm;
    }
}