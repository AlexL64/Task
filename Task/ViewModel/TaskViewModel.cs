using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task.ViewModel
{
    public class TaskViewModel
    {
        public Model.Task? Task { get; set; }
        public TaskViewModel(string id)
        {
            Model.Task? result = GetTask(id).Result;
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
    }
}
