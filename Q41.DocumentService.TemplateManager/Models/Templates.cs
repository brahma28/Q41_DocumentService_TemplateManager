//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Q41.DocumentService.TemplateManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Templates
    {
        public Templates()
        {
            this.TemplateDataSources = new HashSet<TemplateDataSources>();
        }
    
        public int TemplateId { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string Path { get; set; }
        public int TemplateGroupId { get; set; }
        public string Paramaters { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
    
        public virtual ICollection<TemplateDataSources> TemplateDataSources { get; set; }
        public virtual TemplateGroups TemplateGroups { get; set; }

        public int ProcedureCallId { get; set; }
    }
}
