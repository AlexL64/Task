using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using Task.Model;

namespace Task.ViewModel
{
    public class CommentListViewModel
    {
        public List<Comment>? Comments { get; set; }
        public string Task;
        public CommentListViewModel(string taskId)
        {
            List<Comment>? result = GetComments(taskId).Result;
            Comments = result;
            Task = taskId;
        }

        private async Task<List<Comment>?> GetComments(string taskId)
        {
            using (HttpClient client = new())
            {
                client.BaseAddress = new Uri("https://localhost:7124/api/");

                var response = client.GetAsync("Comments/Task/" + taskId).Result;
                response.EnsureSuccessStatusCode();

                HttpContent content = response.Content;
                string result = await content.ReadAsStringAsync();
                List<Comment>? comments = JsonSerializer.Deserialize<List<Comment>>(result);

                return comments;
            }
        }
    }
}
