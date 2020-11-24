using System;
using System.Collections.Generic;
using System.Text;

namespace Veteran.Data.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public string SdrPeronsId { get; set; }
        public string MedicareId { get; set; }
        public string MbrPersGenKey { get; set; }
    }
}
