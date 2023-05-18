﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task.View
{
    /// <summary>
    /// Logique d'interaction pour AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {

        static readonly HttpClient client = new();

        public AddTask()
        {
            InitializeComponent();
        }


        static async Task<Uri> CreateTaskAsync(Model.Task task)
        {

            HttpResponseMessage response = await client.PostAsJsonAsync("api/Tasks", task);
            response.EnsureSuccessStatusCode();

            System.Diagnostics.Debug.WriteLine(response.Headers.Location);
            // return URI of the created resource.
            return response.Headers.Location;

        }

        private async void Save(object sender, RoutedEventArgs e)
        {
            client.BaseAddress = new Uri("https://localhost:7124/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Create a new task
            Model.Task task = new()
            {
                Title = Title.Text,
                Description = Description.Text,
                Created = DateTime.Now,
                Status = "Pending"
            };

            var url = await CreateTaskAsync(task);
            Close();

        }
    }
}
