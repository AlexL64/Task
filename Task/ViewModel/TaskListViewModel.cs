using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Task.ViewModel
{
    public class TaskListViewModel
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

    }
}

