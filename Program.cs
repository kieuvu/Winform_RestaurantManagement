using RestaurantManagement.Source.Forms.Login;
using RestaurantManagement.Source.Forms.Reception;
using RestaurantManagement.Source.Forms.Staff;
using RestaurantManagement.Source.Forms.Table;
using RestaurantManagement.Source.Forms.Food;

namespace RestaurantManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}