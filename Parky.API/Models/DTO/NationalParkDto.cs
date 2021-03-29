using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parky.API.Models.DTO
{
    public class NationalParkDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        //public DateTime Created { get; set; }
        public byte[] Picture { get; set; }
        // public DateTime Established { get; set; }
    }
}
