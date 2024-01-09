using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Exo1
{
    internal class PlacesData
    {
        private IList<Place> placesList;
        public IList<Place> PlacesList {  get { return placesList; } }

        public PlacesData()
        {
            string pathProject = Environment.CurrentDirectory;
            Place p1 = new Place(pathProject + "/photos/bruxelles.jpg", "Bruxelles");
            Place p2 = new Place(pathProject + "/photos/paris.jpg", "Paris");
            Place p3 = new Place(pathProject + "/photos/moscou.jpg", "Moscou");
            Place p4 = new Place(pathProject + "/photos/amsterdam.jpg", "Amsterdam");
            Place p5 = new Place(pathProject + "/photos/newyork.jpg", "New York");

            placesList = new List<Place>();
            placesList.Add(p1);
            placesList.Add(p2);
            placesList.Add(p3);
            placesList.Add(p4);
            placesList.Add(p5);
        }
    }
}
