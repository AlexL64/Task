using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Task.Model;

namespace Task.ViewModel
{
    public class TaskViewModel
    {
        public Model.Task? Task { get; set; }

        private string taskId;
        public TaskViewModel(string id)
        {
            taskId = id;

            Model.Task? result = GetTask(taskId).Result;
            Task = result;
        }

        private async Task<Model.Task?> GetTask(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7124/api/");


                var response = client.GetAsync("Tasks/" + id).Result;
                response.EnsureSuccessStatusCode();

                HttpContent content = response.Content;
                string result = await content.ReadAsStringAsync();
                Model.Task? task = JsonSerializer.Deserialize<Model.Task>(result);

                return task;
            }
        }

        public void DeleteTask()
        {
            using (HttpClient client = new())
            {
                client.BaseAddress = new Uri("https://localhost:7124/api/");

                var response = client.DeleteAsync("Tasks/" + taskId).Result;
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
