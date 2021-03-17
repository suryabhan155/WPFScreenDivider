using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Drawing;
using System.Windows;

namespace ScreenDivider
{
    public class RemoteVideo : Base
    {
        public string RemoteVideoId { get; set; }
        public string SessionId { get; set; }
        public ImageSource _image;
        public ImageSource Image
        { get { return _image; } set { _image = value; OnPropertyChanged(); } }
        public Bitmap bitmap { get; set; }
        public string TagName { get; set; }
        public string RemoteVideoName { get; set; }
        private double _height;
        public double height { get { return _height; } set { _height = value; OnPropertyChanged(); } }
        private double _width;
        public double width { get { return _width; } set { _width = value; OnPropertyChanged(); } }
        private string _margin;
        public string marging { get { return _margin; } set { _margin = value; OnPropertyChanged(); } }
        private bool _Isopen;
        public bool IsOpen { get { return _Isopen; } set { _Isopen = value; OnPropertyChanged(); } }
        private Visibility _Visibility;
        public Visibility Visibility { get { return _Visibility; } set { _Visibility = value; OnPropertyChanged(); } }

        private int _row;

        public int Rows
        {
            get { return _row; }
            set { _row = value; OnPropertyChanged(); }
        }

        private int _col;

        public int Columns
        {
            get { return _col; }
            set { _col = value; OnPropertyChanged(); }
        }
        private int _rowspan;

        public int RowSpan
        {
            get { return _rowspan; }
            set { _rowspan = value; OnPropertyChanged(); }
        }
        private int _colspan;

        public int ColumnSpan
        {
            get { return _colspan; }
            set { _colspan = value; OnPropertyChanged(); }
        }

        private bool _isscreen;

        public bool IsScreen
        {
            get { return _isscreen; }
            set { _isscreen = value; OnPropertyChanged(); }
        }


    }
}

