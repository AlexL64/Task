using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.ComponentModel;

namespace Task.ViewModel
{
    public class TaskListViewModel : INotifyPropertyChanged
    {
        public List<Model.Task>? Tasks { get; set; }
        public TaskListViewModel()
        {
            List<Model.Task>? result = GetTasks().Result;
            Tasks = result;
        }

        private async Task<List<Model.Task>?> GetTasks()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7124/api/");

                var response = client.GetAsync("Tasks").Result;
                response.EnsureSuccessStatusCode();

                HttpContent content = response.Content;
                string result = await content.ReadAsStringAsync();
                List<Model.Task>? tasks = JsonSerializer.Deserialize<List<Model.Task>>(result);

                return tasks;
            }
        }

        public void UpdateTasks()
        {
            List<Model.Task>? result = GetTasks().Result;
            Tasks = result;

            OnPropertyChanged("Tasks");
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler? handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


    }
}

