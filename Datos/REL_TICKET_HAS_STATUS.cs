//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class REL_TICKET_HAS_STATUS
    {
        public long id_ticket { get; set; }
        public long id_status { get; set; }
        public System.DateTime date { get; set; }
        public long id { get; set; }
    
        public virtual STATUS STATUS { get; set; }
        public virtual TICKET TICKET { get; set; }
    }
}
