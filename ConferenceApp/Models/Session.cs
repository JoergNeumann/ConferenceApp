using System.Collections.Generic;

namespace ConferenceApp
{
    public class Session : ModelBase
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _speaker;
        public string Speaker
        {
            get { return _speaker; }
            set { SetProperty(ref _speaker, value); }
        }

        private List<Speaker> _speakers;
        public List<Speaker> Speakers
        {
            get { return _speakers; }
            set { SetProperty(ref _speakers, value); }
        }

        private string _date;
        public string Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        private string _room;
        public string Room
        {
            get { return _room; }
            set { SetProperty(ref _room, value); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private int _day;
        public int Day
        {
            get { return _day; }
            set { SetProperty(ref _day, value); }
        }
    }
}
