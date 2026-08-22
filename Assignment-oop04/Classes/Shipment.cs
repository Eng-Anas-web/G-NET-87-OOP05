using Assignment_oop04.Struct;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop04.Classes
{
    public abstract class Shipment
    {
        #region Feilds
        private string _trackingCode;
        private string _description;
        private double _weight;
        private decimal _deliveryFee;
        private DeliveryAddress _destination;


        #endregion

        #region Prop
        public string TrackingCode
        {
            get
            {
                return _trackingCode;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return _deliveryFee;
            }
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }
        public DeliveryAddress Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
            }
        }

        public abstract decimal EstimatedCost { get; }

        #endregion

        #region Constructor
        public Shipment(string trackingCode)
        {
            _trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                _trackingCode = trackingCode;
            }
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;

        }

        #endregion

        #region Methodes
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
                {
                }
            }
        }

        public void UpdateWeight(double newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(double newWeight, double extraWeight)
        {
            Weight = newWeight + extraWeight;
        }
        public abstract void PrintShipment();

        #endregion

    }
}
