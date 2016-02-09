﻿using PeopleViewer.Presentation;
using PersonRepository.Caching;
using PersonRepository.CSV;
using PersonRepository.Service;
using System.Windows;

namespace PeopleViewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var repository = new ServiceRepository();
            var viewModel = new MainWindowViewModel(repository);
            Application.Current.MainWindow = new MainWindow(viewModel);
            Application.Current.MainWindow.Show();
        }
    }
}
