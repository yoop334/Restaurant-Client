using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using RestaurantClient.Controllers;
using RestaurantClient.Model;

namespace RestaurantClient.View;

public partial class BookTableForm : UserControl
{
    private readonly MainController _controller;

    public BookTableForm(MainController controller)
    {
        InitializeComponent();
        _controller = controller;
        dateTimePicker.Value = DateTime.Today;
        // InitNrOfPersons();
    }

    private async void buttonBookTable_Click(object sender, EventArgs e)
    {
        var date = new DateTimeOffset(dateTimePicker.Value).ToUniversalTime().ToUnixTimeMilliseconds();
        var nrOfPersons = (int)comboBoxPersons.SelectedValue;
        var hour = (int)comboBoxHour.SelectedValue;

        var result = await _controller.AddBooking(date, nrOfPersons, hour);
        MessageBox.Show(result ?  "Eroare!" : "Rezervarea a fost facuta cu succes!");
    }

    private void dateTimePicker_ValueChanged(object sender, EventArgs e)
    {
        // comboBoxPersons.DataSource = null;
        // comboBoxPersons.DataBindings.Clear();
        // comboBoxPersons.SelectedIndex = -1;
        
        // comboBoxHour.DataSource = null;
        // comboBoxHour.DataBindings.Clear();
        // comboBoxHour.SelectedIndex = -1;
        
        InitNrOfPersons();
    }

    private void comboBoxPersons_SelectedValueChanged(object sender, EventArgs e)
    {
        if ((int) comboBoxPersons.SelectedValue != 0)
        {
            InitHours();
        }
    }
    
    private void comboBoxHour_SelectedValueChanged(object sender, EventArgs e)
    {
    }
    
    private async void InitNrOfPersons()
    {
        var tables = await _controller.GetAvailableNrOfPersonsByDate(new DateTimeOffset(dateTimePicker.Value).ToUnixTimeMilliseconds());

        var availableNrOfPersons = new HashSet<int> { 0 };

        foreach (var table in tables)
        {
            availableNrOfPersons.Add(table);
        }
        comboBoxPersons.DataSource = availableNrOfPersons.ToList();
    }

    private async void InitHours()
    {
        var date = new DateTimeOffset(dateTimePicker.Value).ToUnixTimeMilliseconds();
        var nrOfPersons = (int)comboBoxPersons.SelectedValue;
        var availableHours = await _controller.GetAvailableHoursByDatePersons(date, nrOfPersons);

        comboBoxHour.DataSource = availableHours;
        comboBoxHour.SelectedIndex = -1;
    }
}