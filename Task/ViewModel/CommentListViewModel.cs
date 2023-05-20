using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Task.Model;

namespace Task.ViewModel
{
    public class CommentListViewModel : INotifyPropertyChanged
    {
        public List<Comment>? Comments { get; set; }

        public string Task;
        public CommentListViewModel(string taskId)
        {
            Task = taskId;

            List<Comment>? result = GetComments().Result;
            Comments = result;
        }

        private async Task<List<Comment>?> GetComments()
        {
            using (HttpClient client = new())
            {
                client.BaseAddress = new Uri("https://localhost:7124/api/");

                var response = client.GetAsync("Comments/Task/" + Task).Result;
                response.EnsureSuccessStatusCode();

                HttpContent content = response.Content;
                string result = await content.ReadAsStringAsync();
                List<Comment>? comments = JsonSerializer.Deserialize<List<Comment>>(result);

                return comments;
            }
        }

        public async void PostComment(string commentText)
        {
            using (HttpClient client = new())
            {
                // Create a new task
                Comment comment = new()
                {
                    task = Task,
                    text = commentText,
                    created = DateTime.Now
                };

                if (client.BaseAddress == null)
                {
                    client.BaseAddress = new Uri("https://localhost:7124/api/");
                }

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync("Comments", comment);
                response.EnsureSuccessStatusCode();

                System.Diagnostics.Debug.WriteLine(response.Headers.Location);
            }

            UpdateComments();
        }

        public void DeleteComment(string id)
        {
            using (HttpClient client = new())
            {
                client.BaseAddress = new Uri("https://localhost:7124/api/");

                var response = client.DeleteAsync("Comments/" + id).Result;
                response.EnsureSuccessStatusCode();
            }

            UpdateComments();
        }


        private void UpdateComments()
        {
            List<Comment>? result = GetComments().Result;
            Comments = result;

            OnPropertyChanged("Comments");
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
