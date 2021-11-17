using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoMediacion.Models
{
    public class Guitar
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string FilePath { get; set; }

        public string Description { get; set; }
         
        public int Year { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<GuitarHistory> GuitarHistories { get; set; }
    }
}
