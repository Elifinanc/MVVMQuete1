using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using QueteMVVM.Model;

namespace QueteMVVM.ViewModel
{
    public class ShopViewModel 
    {
        private IList<Shop> _ShopsList;

        public ShopViewModel()
        {
            _ShopsList = new List<Shop>
            {
                new Shop{ShopId = 1, ShopName="Shop1", Addres ="1 Avenue des Vosges Strasbourg", Country="France"},
                new Shop{ShopId = 2, ShopName="Shop2", Addres ="2 Avenue des Vosges Strasbourg", Country="France"},
                new Shop{ShopId = 3, ShopName="Shop3", Addres ="3 Avenue des Vosges Strasbourg", Country="France"},
                new Shop{ShopId = 4, ShopName="Shop4", Addres ="4 Avenue des Vosges Strasbourg", Country="France"},
                new Shop{ShopId = 5, ShopName="Shop5", Addres ="5 Avenue des Vosges Strasbourg", Country="France"},
            };
        }

        public IList<Shop> Shops
        {
            get { return _ShopsList; }
            set { _ShopsList = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }
        }
    }
}
