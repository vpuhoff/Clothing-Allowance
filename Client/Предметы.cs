//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client
{
    using System;
    using System.Collections.Generic;
    
    public partial class Предметы
    {
        public Предметы()
        {
            this.Имущество = new ObservableListSource<Имущество>();
            this.Нормативы = new ObservableListSource<Нормативы>();
        }
    
        public int Код { get; set; }
        public string Наименование { get; set; }
        public Nullable<bool> Фурнитура { get; set; }
        public byte[] upsize_ts { get; set; }
    
        public virtual ObservableListSource<Имущество> Имущество { get; set; }
        public virtual ObservableListSource<Нормативы> Нормативы { get; set; }
    }
}
