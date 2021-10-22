using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM.Model
{
    class AddressModel : INotifyPropertyChanged
    {
        #region properties
        private string name = string.Empty;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                RaisePropertyChanged(); //Refresh View
            }
        }
        private string street = string.Empty;
        public string Street
        {
            get => street;
            set
            {
                street = value;
                RaisePropertyChanged();
            }
        }
        private int cipCode;
        public int CipCode
        {
            get => cipCode;
            set
            {
                cipCode = value;
                RaisePropertyChanged();
            }
        }
        private string city = string.Empty;
        public string City
        {
            get => city;
            set
            {
                city = value;
                RaisePropertyChanged();
            }
        }
        private string address = string.Empty;
        public string Address
        {
            get => address;
            set
            {
                address = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region INotify
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region methods
        public void Reset()
        {
            Name = Street = City = Address = String.Empty;
            CipCode = 0;
        }

        public void BuildAddress()
        {
            Address = $"{Name}{Environment.NewLine}{Street}{Environment.NewLine}{CipCode} {Street}";
        }
        #endregion
    }
}