//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiblioteqSofiya931.DBConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public book()
        {
            this.HistoryReadTicket = new HashSet<HistoryReadTicket>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdAvtor { get; set; }
        public Nullable<System.DateTime> YearMade { get; set; }
        public Nullable<int> IdIzdanie { get; set; }
        public Nullable<int> IdJanr { get; set; }
        public Nullable<int> CountPage { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<int> IdHall { get; set; }
        public Nullable<int> Shelf { get; set; }
    
        public virtual Avtor Avtor { get; set; }
        public virtual Hall Hall { get; set; }
        public virtual Izdanie Izdanie { get; set; }
        public virtual Janr Janr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryReadTicket> HistoryReadTicket { get; set; }
    }
}
