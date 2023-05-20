using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Windows;

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

        private async void Save(object sender, RoutedEventArgs e)
        {
            // Create a new task
            Model.Task task = new()
            {
                title = Title.Text,
                description = Description.Text,
                created = DateTime.Now,
                status = "Pending"
            };

            if (client.BaseAddress == null )
            {
                client.BaseAddress = new Uri("https://localhost:7124/api/");
            }
            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsJsonAsync("Tasks", task);
            response.EnsureSuccessStatusCode();

            System.Diagnostics.Debug.WriteLine(response.Headers.Location);
            ((MainWindow)Owner).UpdateTaskList();
            Close();
        }
    }
}
