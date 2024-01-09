using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Exo1
{
    internal class Place
    {
        private string _description;

        public string Description { get { return _description; } set { _description = value; } }

        private string _pathImageFile;
        public string PathImageFile { get { return _pathImageFile; }  set { _pathImageFile = value; } }

        private int _nbVotes;
        public int NbVotes { get { return _nbVotes; } set { _nbVotes = value; } }

        private Uri _uri;
        public Uri Uri { get { return _uri; } set { _uri = value; } }

        private BitmapFrame _image;
        public BitmapFrame Image { get { return _image; } set { _image = value; } }

        public Place(string path, string description)
        {
            _description = description;
            _pathImageFile = path;
            _nbVotes = 0;
            _uri = new Uri(_pathImageFile);
            _image = BitmapFrame.Create(_uri);
        }
    }
}
