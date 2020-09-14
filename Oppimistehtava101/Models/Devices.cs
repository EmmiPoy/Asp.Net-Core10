using System;
using System.Collections.Generic;

namespace Oppimistehtava101.Models
{
    public partial class Devices
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
