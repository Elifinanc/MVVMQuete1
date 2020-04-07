using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace QueteMVVM.Model
{
    public class Shop : INotifyPropertyChanged
    {
        private int shopId;
        private string shopName;
        private string addres;
        private string country;

        public int ShopId
        {
            get
            {
                return shopId;
            }
            set
            {
                shopId = value;
                OnPropertyChanged("ShopId");
            }
        }

        public string ShopName
        {
            get
            {
                return shopName;
            }
            set
            {
                shopName = value;
                OnPropertyChanged("ShopName");
            }
        }

        public string Addres
        {
            get
            {
                return addres;
            }
            set
            {
                addres = value;
                OnPropertyChanged("Addres");
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
