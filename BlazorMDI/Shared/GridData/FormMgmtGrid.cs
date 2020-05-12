using System;

namespace BlazorMDI.Shared.GridData
{
    public class FormMgmtGrid
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ObjectName { get; set; }
        public string DomainObjectName { get; set; }
        public int UsageCounter { get; set; }
        public DateTime LastModified { get; set; }
    }
}
