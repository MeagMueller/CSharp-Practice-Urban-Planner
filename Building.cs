using System;
using System.Collections.Generic;

namespace Planner {

    public class Building {

        private string _designer = "Meag Mueller";

        private DateTime _dateConstructed { get; set; }

        private string _address { get; set; }

        private string _owner { get; set; }

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume {
            get 
                {
                    return (Width * Depth * (3*Stories));
                }
        }

        public string Designer() {
            return _designer;
        }

        public Building(string address)
        {
            // The constructor's logic should set the _address field's value to the argument value
          _address = address;
        }

        public void Construct()
        {
            // Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string NewOwner)
        {
            // Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building. The method should take that string and assign it to the private _owner field.

            _owner = NewOwner;

        }

    }

    

    
}