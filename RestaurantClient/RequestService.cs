using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestaurantClient.Model;
using RestaurantClient.Model.ViewModel.Booking;
using RestaurantClient.Model.ViewModel.User;

namespace RestaurantClient;

public class RequestService
{
    private const string Login = "api/account/login";
    private const string Logout = "api/account/logout";
    private const string CreateUserAccount = "api/users/";
    private const string GetNrOfPersonsForDate = "api/bookings/{0}";
    private const string GetHoursForDatePersons = "api/bookings/{0}/{1}";
    private const string CreateBooking = "api/bookings/";
    private const string GetBookings = "api/bookings/";
    private readonly HttpClient _client;

    public RequestService()
    {
        _client = new HttpClient();

        var serviceHost = System.Configuration.ConfigurationManager.AppSettings.Get("serviceHost");

        if (serviceHost == null) return;

        _client.BaseAddress = new Uri(serviceHost);
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<Account> AuthenticateUser(AuthenticationRequest authenticationRequest)
    {
        var response = await _client.PostAsJsonAsync(Login, authenticationRequest);

        if (!response.IsSuccessStatusCode) return null;

        var content = await response.Content.ReadAsStringAsync();
        var account = JsonConvert.DeserializeObject<Account>(content);

        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", account.AccessToken);
        return account;
    }

    public async Task<bool> LogoutUser()
    {
        var response = await _client.PostAsync(Logout, null);

        if (!response.IsSuccessStatusCode) return false;

        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<bool>(content);
    }

    public async Task<bool> CreateAccount(UserCreationViewModel userCreationViewModel)
    {
        var response = await _client.PostAsJsonAsync(CreateUserAccount, userCreationViewModel);

        if (!response.IsSuccessStatusCode) return false;

        // var content = await response.Content.ReadAsStringAsync();
        // var user = JsonConvert.DeserializeObject<User>(content);
        return true;
    }

    public async Task<List<int>> GetAvailableTablesByDate(long date)
    {
        var response = await _client.GetAsync(string.Format(GetNrOfPersonsForDate, date));

        if (!response.IsSuccessStatusCode) return null;

        var content = response.Content.ReadAsStringAsync().Result;
        var data = JsonConvert.DeserializeObject<List<int>>(content);
        return data;
    }

    public async Task<List<int>> GetAvailableHoursByDatePersons(long date, int nrOfPersons)
    {
        var response = await _client.GetAsync(string.Format(GetHoursForDatePersons, date, nrOfPersons));

        if (!response.IsSuccessStatusCode) return null;

        var content = response.Content.ReadAsStringAsync().Result;
        var data = JsonConvert.DeserializeObject<List<int>>(content);
        return data;
    }

    public async Task<bool> AddBooking(BookingCreationViewModel bookingCreationViewModel)
    {
        var response = await _client.PostAsJsonAsync(CreateBooking, bookingCreationViewModel);

        if (response.IsSuccessStatusCode) return false;
        
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<bool>(content);
    }

    public async Task<List<Booking>> GetAllBookings()
    {
        var response = await _client.GetAsync(GetBookings);

        if (!response.IsSuccessStatusCode) return null;
        
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Booking>>(content);
    }
}