using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public class HotelInformation
    {
        private int _id;
        private string _name;
        private string _phoneNumber;
        private string _email;
        private int _floors;
        private int _capacity;
        private string _zipcode;
        private string _city;
        private string _street;
        private string country;
        private double _score;
        private double _price;
        private string _description;
        private byte[] _hotelImage;
        public HotelInformation()
        {
        }

        public HotelInformation(int id, string name, string phoneNumber, string email, int floors, int capacity, string zipcode, string city, string street, string country, double score, double price, string description, Byte[] hotelImage)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Floors = floors;
            Capacity = capacity;
            Zipcode = zipcode;
            City = city;
            Street = street;
            this.Country = country;
            Score = score;
            Price = price;
            Description = description;
            HotelImage = hotelImage;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Email { get => _email; set => _email = value; }
        public int Floors { get => _floors; set => _floors = value; }
        public int Capacity { get => _capacity; set => _capacity = value; }
        public string Zipcode { get => _zipcode; set => _zipcode = value; }
        public string City { get => _city; set => _city = value; }
        public string Street { get => _street; set => _street = value; }
        public string Country { get => country; set => country = value; }
        public double Score { get => _score; set => _score = value; }
        public double Price { get => _price; set => _price = value; }
        public string Description { get => _description; set => _description = value; }
        public byte[] HotelImage { get => _hotelImage; set => _hotelImage = value; }
    }
}
