using System.Windows;
using System.Windows.Controls;
using Task.ViewModel;
using Task.View;

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
            AddTask addTask = new();
            addTask.Show();
        }

        private void OpenTask(object sender, RoutedEventArgs e)
        {
            Grid triggeredGrid = (Grid)sender;
            Model.Task taskInfo = (Model.Task)triggeredGrid.DataContext;

            ShowTask showTask = new ShowTask(taskInfo.id);
            showTask.Show();
        }

        private void UpdateTaskList(object sender, RoutedEventArgs e)
        {
            _taskListViewModel.UpdateTasks();
        }
    }
}
