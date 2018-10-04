using AntoniolaCrawler.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AntoniolaCrawler.ViewModel
{
    class MainWindowViewModel : PropertyChangedNotifier
    {
        private int _searchDepth = 0;
        private string _siteUri = "";

        private ICommand _crawlSiteCommand;

        // public ObservableCollection<Uri> SiteBypassLinks { get; set; }
        // the task mentions that we should have a collection of links, but for now
        // we can leave it to have only one link (solely for testing purpose)

        public int SearchDepth
        {
            get => _searchDepth;
            set
            {
                _searchDepth = value;
                OnPropertyChanged(nameof(SearchDepth));
            }
        }

        public string SiteUri
        {
            get => _siteUri;
            set
            {
                _siteUri = value;
                OnPropertyChanged(nameof(_siteUri));
            }
        }

        public ICommand CrawlSiteCommand => _crawlSiteCommand ?? (_crawlSiteCommand = new RelayCommand(GetMetricsData));

        private void GetMetricsData()
        {
            MessageBox.Show("Man, fuck this shit.");
            SearchDepth = 1;
        }
    }
}
