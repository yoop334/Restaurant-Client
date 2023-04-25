using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Consul;
using RestaurantClient.Model;
using RestaurantClient.Model.ViewModel.Booking;
using RestaurantClient.Model.ViewModel.User;
using RestaurantClient.View;

namespace RestaurantClient.Controllers;

public class MainController
{
    private readonly RequestService _service;

    private Account _account;

    public MainController(RequestService service)
    {
        _service = service;
    }

    public async Task<bool> Login(string username, string password)
    {
        var result = await _service.AuthenticateUser(
            new AuthenticationRequest { Username = username, Password = password }
        );

        if (result == null)
        {
            return false;
        }

        _account = result;
        return true;
    }
    
    public async Task<bool> Logout()
    {
        if (_account == null)
        {
            return false;
        }
        var result = await _service.LogoutUser();
        return result;
    }

    public async Task<bool> CreateAccountAndLogin(string username, string password, string firstName, string lastName)
    {
        var result = await _service.CreateAccount(
            new UserCreationViewModel { Username = username, Password = password, FirstName = firstName, LastName = lastName }
        );
        
        if (result == false)
        {
            return false;
        }

        return await Login(username, password);
    }

    public async Task<List<int>> GetAvailableNrOfPersonsByDate(long date)
    {
        return await _service.GetAvailableTablesByDate(date);
    }
    
    public async Task<List<int>> GetAvailableHoursByDatePersons(long date, int nrOfPersons)
    {
        return await _service.GetAvailableHoursByDatePersons(date, nrOfPersons);
    }

    public async Task<bool> AddBooking(long date, int nrOfPersons, int hour)
    {
        return await _service.AddBooking(
            new BookingCreationViewModel {Date = date, NrOfPersons = nrOfPersons, Time = hour}
        );
    }

    public async Task<List<Booking>> GetAllBookings()
    {
        return await _service.GetAllBookings();
    }
}