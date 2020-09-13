using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMartDesktopUI.ViewModels
{
    class SalesViewModel : Screen
    {
        private BindingList<string> _products;
        private BindingList<string> _cart;

        private int _itemQuantity;

        public BindingList<string> Products
        {
            get { return _products; }
            set 
            { 
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        public BindingList<string> Cart
        {
            get { return _cart; }
            set 
            { 
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public string SubTotal 
        {
            get 
            { 
                // TODO - Replace with calculation
                return "$0.00"; 
            } 
        }

        public string Tax
        {
            get
            {
                // TODO - Replace with calculation
                return "$0.00";
            }
        }

        public string Total
        {
            get
            {
                // TODO - Replace with calculation
                return "$0.00";
            }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;

                // Make sure something is selected
                // Make sure there is an item quantity
                

                return output;
            }
        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                // Make sure something is selected
                // Make sure there is an item quantity


                return output;
            }
        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;

                // Make sure something in the cart

                return output;
            }
        }

        public void AddToCart()
        {

        }

        public void RemoveFromCart()
        {

        }

        public void CheckOut()
        {

        }
    }
}
