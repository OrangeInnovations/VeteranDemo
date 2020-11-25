namespace Veteran.Data.Models
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    public class Crm: BaseModel, IEquatable<Crm>
    {
        public bool? vet_crm { get; set; }
        public bool? non_vet_crm { get; set; }
        public bool? va_health_crm { get; set; }

        public DateTime CREATE_TIMESTAMP { get; set; }

        public bool Equals([AllowNull] Crm other)
        {
            if(!SameKey(other))
            {
                return false;
            }

            if(vet_crm==other.vet_crm && non_vet_crm==other.non_vet_crm && va_health_crm == other.va_health_crm)
            {
                return true;
            }
            return false;
            
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Crm crmObj = obj as Crm;
            if (crmObj == null)
                return false;
            else
                return Equals(crmObj);
        }

        public override int GetHashCode()
        {
            return MbrPersGenKey.GetHashCode() ^ SdrPeronsId.GetHashCode()
                ^ vet_crm.GetHashCode() ^ non_vet_crm.GetHashCode() ^ va_health_crm.GetHashCode();
        }
    }
}
