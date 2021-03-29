using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int NeighborhoodId { get; set; }
        public string Phone { get; set; }
        public Neighborhood Neighborhood { get; set; } // pulls whole neighborhood object to display the name
                                                        // The conroller needs access to the Neighborhood object (I think... C# go brrrrrrr!)

    }
}
