using System.Windows;
using System.Windows.Controls;
using Task.ViewModel;
using Task.Model;

namespace Task.View
{
    /// <summary>
    /// Interaction logic for ShowTask.xaml
    /// </summary>
    public partial class ShowTask : Window
    {

        public TaskViewModel _taskViewModel;
        public TaskViewModel TaskViewModel
        {
            get { return _taskViewModel; }
        }

        public CommentListViewModel _commentListViewModel;
        public CommentListViewModel CommentListViewModel
        {
            get { return _commentListViewModel; }
        }

        public ShowTask(string id)
        {
            InitializeComponent();

            DataContext = this;
            _taskViewModel = new TaskViewModel(id);
            _commentListViewModel = new CommentListViewModel(id);
        }

        private void AddComment(object sender, RoutedEventArgs e)
        {
            _commentListViewModel.PostComment(NewComment.Text);

            NewComment.Text = null;
        }

        private void RemoveComment(object sender, RoutedEventArgs e)
        {
            Button triggeredButton = (Button)sender;
            Comment commentInfo = (Comment)triggeredButton.DataContext;

            _commentListViewModel.DeleteComment(commentInfo.id);
        }

        private void Updatetask(object sender, RoutedEventArgs e)
        {
            Button triggeredButton = (Button)sender;
            Model.Task taskInfo = (Model.Task)triggeredButton.DataContext;

            Model.Task task = new() { id = taskInfo.id, title = Title.Text, description = Description.Text, created = taskInfo.created, status = Status.Text };
            _taskViewModel.PutTask(task);
        }

        private void RemoveTask(object sender, RoutedEventArgs e)
        {
            _taskViewModel.DeleteTask();
            Close();
        }
    }
}
