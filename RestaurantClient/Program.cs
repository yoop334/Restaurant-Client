using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantClient.Controllers;
using RestaurantClient.View;

namespace RestaurantClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var service = new RequestService();
            var controller = new MainController(service);
            var loginForm = new LoginForm(controller);
            Application.Run(loginForm);
        }
    }
}