using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public class Room
    {
           private int id;
           private string name;
           private string type;
           private string bed;
           private int clients;
           private double size;
           private double price;
             private string status;
           private List<String> room_facilities;
           private List<String> bathroom_facilities;
           private Byte[] image;
        public Room()
        {
        }

        public Room(int id, string name, string type, string bed, int clients, double size, double price, List<string> room_facilities, List<string> bathroom_facilities, byte[] image, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Bed = bed;
            this.Clients = clients;
            this.Size = size;
            this.Price = price;
            this.Room_facilities = room_facilities;
            this.Bathroom_facilities = bathroom_facilities;
            this.Image = image;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Bed { get => bed; set => bed = value; }
        public int Clients { get => clients; set => clients = value; }
        public double Size { get => size; set => size = value; }
        public double Price { get => price; set => price = value; }
        public List<string> Room_facilities { get => room_facilities; set => room_facilities = value; }
        public List<string> Bathroom_facilities { get => bathroom_facilities; set => bathroom_facilities = value; }
        public byte[] Image { get => image; set => image = value; }
        public string Status { get => status; set => status = value; }
    }
}
