using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Veteran.Data.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public string SdrPeronsId { get; set; }
        public string MedicareId { get; set; }
        public string MbrPersGenKey { get; set; }

        public bool SameKey([AllowNull] BaseModel other)
        {
            if(other==null)
            {
                return false;
            }

            return MbrPersGenKey.Equals(other.MbrPersGenKey, StringComparison.OrdinalIgnoreCase)
                 || SdrPeronsId.Equals(other.SdrPeronsId, StringComparison.OrdinalIgnoreCase)
                 || MedicareId.Equals(other.MedicareId, StringComparison.OrdinalIgnoreCase)
                 || Id.Equals(other.Id);
        }

        
    }
}
