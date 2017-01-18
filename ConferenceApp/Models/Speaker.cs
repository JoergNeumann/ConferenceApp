namespace ConferenceApp
{
    public class Speaker : ModelBase
    {
        private int _id;
        private string _name;
        private string _company;
        private string _bio;
        private string _imageUri;

        public int Id
        {
            get { return _id; }
            set { _id = value; this.OnPropertyChanged(); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; this.OnPropertyChanged(); }
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; this.OnPropertyChanged(); }
        }

        public string Bio
        {
            get { return _bio; }
            set { _bio = value; this.OnPropertyChanged(); }
        }

        public string ImageUri
        {
            get { return _imageUri; }
            set { _imageUri = value; this.OnPropertyChanged(); }
        }

    }
}
