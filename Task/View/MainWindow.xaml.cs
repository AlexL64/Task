using System.Windows;
using Task.ViewModel;

namespace Task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TaskListViewModel _taskListViewModel;
        public TaskListViewModel TaskListViewModel
        {
            get { return _taskListViewModel; }
        }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            _taskListViewModel = new TaskListViewModel();
        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            View.AddTask addTask = new();
            addTask.Show();
        }
    }
}
