namespace Veteran.Data.Models
{
    using System;
    public class Crm: BaseModel
    {
        public bool? vet_crm { get; set; }
        public bool? non_vet_crm { get; set; }
        public bool? va_health_crm { get; set; }

        public DateTime CREATE_TIMESTAMP { get; set; }

    }
}
