﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class SettingForm : Form
    {
        public WeatherSettings Settings { get; set; }
        
       public SettingForm()
        {
            InitializeComponent();
            Form_Size();
            Settings = new WeatherSettings();
        }
           private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateCitySelection())
            {
                MessageBox.Show(MyStrings.ValidationMessage);
                return;
            }

           GetSettings();
           ShowWeatherForm();
           this.Close();
        }
        public void GetSettings()
        {
            Settings.Cities = new List<string>();
            foreach (var item in checkedListBoxCities.CheckedItems)
            {
                Settings.Cities.Add(item.ToString());
            }
            Settings.RefreshTime = numericUpDownTime.Value.ToString();
        }
        public bool ValidateCitySelection()
        {
            return checkedListBoxCities.CheckedItems.Count > 0;
        }
        public void ShowWeatherForm()
        {
           
            WeatherData weatherDataForm = Application.OpenForms.OfType<WeatherData>().FirstOrDefault();

            if (weatherDataForm != null)
            {
               weatherDataForm.Show();
              
            }
               else
            {
                WeatherData weather = new WeatherData(Settings);
                weather.Show();

            }
        }
        public void InitializeCities()
        {
            checkedListBoxCities.Items.Add(MyStrings.City1);
            checkedListBoxCities.Items.Add(MyStrings.City2);
            checkedListBoxCities.Items.Add(MyStrings.City3);
            checkedListBoxCities.Items.Add(MyStrings.City4);
            checkedListBoxCities.Items.Add(MyStrings.City5);
            checkedListBoxCities.CheckOnClick = true;
        }

        public void InitializeRefreshTime()
        {
            numericUpDownTime.Minimum = 5;
            numericUpDownTime.Maximum = 15;
            numericUpDownTime.Value = 5;
            numericUpDownTime.Increment = 5;
        }
        private void SettingForm_Load_1(object sender, EventArgs e)
        {
            InitializeCities();
            InitializeRefreshTime();
        }
        private void Form_Size()
        {
            this.Width = 460;
            this.Height = 400;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
        }
    }

}

