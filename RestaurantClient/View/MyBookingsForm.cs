using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using RestaurantClient.Controllers;
using RestaurantClient.Model.ViewModel.Booking;

namespace RestaurantClient.View;

public partial class MyBookingsForm : UserControl
{
    private readonly MainController _controller;
    
    public MyBookingsForm(MainController controller)
    {
        InitializeComponent();
        _controller = controller;
        LoadData();
    }

    private async void LoadData()
    {
        var data = await _controller.GetAllBookings();
        var bookings = data.Select(booking => new BookingViewModel
        {
            Time = DateTimeOffset.FromUnixTimeMilliseconds(booking.Time).LocalDateTime.ToString(CultureInfo.CurrentCulture),
            NrOfPersons = booking.NrOfPersons
        });
        bookingsGridView.DataSource = bookings.ToList();
        bookingsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        
    }

}