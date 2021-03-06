﻿namespace ePubReader.Models
{
    public class ManifestItem : BaseNotify
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; RaisePropertyChanged("Id"); }
        }

        private string _href;
        public string Href
        {
            get { return _href; }
            set { _href = value; RaisePropertyChanged("Href"); }
        }

        private string _mediaType;
        public string MediaType
        {
            get { return _mediaType; }
            set { _mediaType = value; RaisePropertyChanged("MediaType"); }
        }
    }
}
