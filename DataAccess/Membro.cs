//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Membro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Membro()
        {
            this.listaCongregacoes = new HashSet<Congregacao>();
        }
    
        public double CODIRM07 { get; set; }
        public string NOMIRM07 { get; set; }
        public Nullable<double> CODFIL07 { get; set; }
        public Nullable<System.DateTime> ADMCON07 { get; set; }
        public string NOMPAI07 { get; set; }
        public string NOMMAE07 { get; set; }
        public Nullable<System.DateTime> DATNAS07 { get; set; }
        public string ESTCIV07 { get; set; }
        public string CONJUG07 { get; set; }
        public string CPFIRM07 { get; set; }
        public string RG_IRM07 { get; set; }
        public string EXPERG07 { get; set; }
        public Nullable<System.DateTime> DATEXP07 { get; set; }
        public string OUTDOC07 { get; set; }
        public Nullable<double> CODNAT07 { get; set; }
        public string NACION07 { get; set; }
        public string CODCEP07 { get; set; }
        public Nullable<double> CODLOG07 { get; set; }
        public string NUMERO07 { get; set; }
        public Nullable<double> CODBAI07 { get; set; }
        public string COMPLE07 { get; set; }
        public Nullable<double> CODCID07 { get; set; }
        public string TELRES07 { get; set; }
        public string TELCEL07 { get; set; }
        public string PROFIS07 { get; set; }
        public string LOCTRA07 { get; set; }
        public string CEPTRA07 { get; set; }
        public Nullable<double> LOGTRA07 { get; set; }
        public string NUMTRA07 { get; set; }
        public Nullable<double> BAITRA07 { get; set; }
        public string COMTRA07 { get; set; }
        public Nullable<double> CIDTRA07 { get; set; }
        public string TELTRA07 { get; set; }
        public string FAXTRA07 { get; set; }
        public Nullable<System.DateTime> BATESP07 { get; set; }
        public Nullable<System.DateTime> DATBAT07 { get; set; }
        public string IGREBA07 { get; set; }
        public Nullable<double> CIDBAT07 { get; set; }
        public Nullable<System.DateTime> ADMMEM07 { get; set; }
        public string ADMPOR07 { get; set; }
        public Nullable<double> CODFUN07 { get; set; }
        public Nullable<double> ESPORT07 { get; set; }
        public Nullable<double> FILBAT07 { get; set; }
        public Nullable<System.DateTime> DATCAD07 { get; set; }
        public string SITMEM07 { get; set; }
        public Nullable<double> VALAUX07 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Congregacao> listaCongregacoes { get; set; }
    }
}
