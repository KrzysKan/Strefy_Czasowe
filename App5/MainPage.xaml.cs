using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnRefreshButtonClicked(object sender, EventArgs e)
        {
            // Pobierz aktualny czas w strefie czasowej UTC
            DateTime utcTime = DateTime.UtcNow;

            // Zdefiniuj trzy własne strefy czasowe  - Niesty mój laptop nie współpracował ze strefami systemowym
            TimeZoneInfo utc11 = TimeZoneInfo.CreateCustomTimeZone("UTC-11", new TimeSpan(-11, 0, 0), "UTC-11", "UTC-11");
            TimeZoneInfo utc1 = TimeZoneInfo.CreateCustomTimeZone("UTC-1", new TimeSpan(-1, 0, 0), "UTC-1", "UTC-1");
            TimeZoneInfo utc6 = TimeZoneInfo.CreateCustomTimeZone("UTC+6", new TimeSpan(6, 0, 0), "UTC+6", "UTC+6");

            // Obliczenie właściwego czasu w danych strefach
            DateTime utc11Time = TimeZoneInfo.ConvertTimeFromUtc(utcTime, utc11);
            DateTime utc1Time = TimeZoneInfo.ConvertTimeFromUtc(utcTime, utc1);
            DateTime utc6Time = TimeZoneInfo.ConvertTimeFromUtc(utcTime, utc6);



            // Wyświetl aktualny czas w trzech wybranych strefach czasowych
            easternLabel.Text = utc11Time.ToString();
            centralLabel.Text = utc1Time.ToString();
            pacificLabel.Text = utc6Time.ToString();
            // Zmień napis na przysisku
            refresh_button.Text = "Odśwież";


        }
    }
}
