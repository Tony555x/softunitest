using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Namespace
{
    public class AnimalDetails
    {
        public int Id { get; set; }
        public string Name{ get; set; } = String.Empty;
        public string Owner{ get; set; } = String.Empty;
        public int Age{ get; set; } = 0;
        public string Type{ get; set; } = String.Empty;
        public bool Sick{ get; set; } = false;
        public string Notes{ get; set; } = String.Empty;
    }
}