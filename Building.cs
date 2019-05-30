using System;
using System.Collections.Generic;

namespace Planner {

    class Building {
        public Planner()
        {
            Designer = "";
            dateConstructed = DateTime.Now;
            Address = "";
            Owner = "";
        }

        private string Designer() { get; set; }

        private DateTime dateConstructed() { get; set; }

        private string Address() { get; set; }

        private string Owner() { get; set; }

        public int Stories() { get; set; }

        public double Width() { get; set; }

        public double Depth() { get; set; }

        // public readonly double Volume() {
        //     get {
        //         return (Width*Depth(3*Stories));
        //     }
        // }

        public void AddressConstructor(string address)
        {
            Console.WriteLine("This is the thing right now.");
            // The constructor's logic should set the _address field's value to the argument value
        }

        public void Construct()
        {
            // Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
            DateTime dateConstructed = DateTime.Now;
        }

        public void Purchase()
        {
            // Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building. The method should take that string and assign it to the private _owner field.

        }

    }

    

    
}