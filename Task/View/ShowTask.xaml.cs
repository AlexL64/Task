﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Task.ViewModel;

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
        }
    }
}
