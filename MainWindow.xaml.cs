using Microsoft.Win32;
using ScreenDivider;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            VideoHeight = double.NaN;
            VideoWidth = double.NaN;
            
            p = 1;
        }
        static int p;
        static double remoteWidth;
        static double remoteHeigth;
        double WrpWidth;
        double WrpHeight;
        private void ScreenDivided(string id, Uri uri)
        {
            var H = Math.Sqrt(p);
            var W = Math.Sqrt(p);
            
            if (WrpWidth > WrpHeight)
            {
                W = Math.Ceiling(W);
                H = Math.Round(H);
            }
            else
            {
                W = Math.Floor(W);
            } 
            W = 100 / Math.Max(1, W);
            remoteWidth = Math.Floor(W * WrpWidth / 100);
            remoteHeigth = Math.Floor(WrpHeight / H);

            foreach (var re in RemoteVideoes)
            {
                var remote = RemoteVideoes.FirstOrDefault(x => x.RemoteVideoId == re.RemoteVideoId);
                remote.height = remoteHeigth;
                remote.width = remoteWidth;
            } 
            p++;
        }

        private void xyz_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                
                Uri fileUri = new Uri(openFileDialog.FileName);
                
                RemoteVideoes.Add(new RemoteVideo
                {
                    RemoteVideoId = "user" + p,
                    Image = new BitmapImage(fileUri),
                    RemoteVideoName = openFileDialog.FileName
                });
                ScreenDivided("user"+p, fileUri);
            }
            
        }
        public ObservableCollection<RemoteVideo> _rvideos = new ObservableCollection<RemoteVideo>();
        public ObservableCollection<RemoteVideo> RemoteVideoes
        {
            get {
                return _rvideos;
            }
            set
            {
                _rvideos = value;
                OnPropertyChanged();
            }
        }
        private double _videowidth;

        public double VideoWidth
        {
            get { return _videowidth; }
            set { _videowidth = value; OnPropertyChanged(); }
        }

        private double _videoheight;

        public double VideoHeight
        {
            get { return _videoheight; }
            set { _videoheight = value; OnPropertyChanged(); }
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            var tag = Convert.ToString((sender as Border).Tag);
            var remote = RemoteVideoes.FirstOrDefault(x => x.RemoteVideoId == tag);
            remote.IsOpen = true;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            var tag = Convert.ToString((sender as Border).Tag);
            var remote = RemoteVideoes.FirstOrDefault(x => x.RemoteVideoId == tag);
            remote.IsOpen = false;
        }
        #region Inotify properties changes
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName()] string name = null)
        {
            if (name != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WrpWidth = RVideoListView.ActualWidth;
            WrpHeight = RVideoListView.ActualHeight;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            int q = p - 1;
            var remote = RemoteVideoes.FirstOrDefault(p => p.RemoteVideoId == "user"+q);
            RemoteVideoes.Remove(remote);
            ScreenDividedAfterDelete(q-1);
        }
        private void ScreenDividedAfterDelete(int p)
        {
            var H = Math.Sqrt(p);
            var W = Math.Sqrt(p);

            if (WrpWidth > WrpHeight)
            {
                W = Math.Ceiling(W);
                H = Math.Round(H);
            }
            else
            {
                W = Math.Floor(W);
            }
            W = 100 / Math.Max(1, W);
            remoteWidth = Math.Floor(W * WrpWidth / 100);
            remoteHeigth = Math.Floor(WrpHeight / H);

            foreach (var re in RemoteVideoes)
            {
                var remote = RemoteVideoes.FirstOrDefault(x => x.RemoteVideoId == re.RemoteVideoId);
                remote.height = remoteHeigth;
                remote.width = remoteWidth;
            }
        }
    }
}
