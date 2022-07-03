namespace InterWorldCSharp.Models
{
    public class BudgetsDestinationModel
    {
        private string country;
        private string city;
        private string img;

        public BudgetsDestinationModel(string country, string city, string img)
        {
            this.country = country;
            this.city = city;
            this.img = img;
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
