//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client
{
    using System;
    using System.Collections.Generic;
    
    public partial class Имущество
    {
        public int Код { get; set; }
        public Nullable<int> Норматив_ID { get; set; }
        public Nullable<int> Предмет_ID { get; set; }
        public Nullable<int> Срок_службы { get; set; }
        public Nullable<System.DateTime> Дата_окончания_срока_службы { get; set; }
        public Nullable<int> Количество_выданных { get; set; }
        public Nullable<int> Количество_по_нормативу { get; set; }
        public Nullable<int> Количество_компенсированных { get; set; }
        public Nullable<int> Цена_за_единицу { get; set; }
        public Nullable<int> Документ_о_выдаче { get; set; }
        public byte[] upsize_ts { get; set; }
    
        public virtual Документы_о_выдаче Документы_о_выдаче { get; set; }
        public virtual Нормативы Нормативы { get; set; }
        public virtual Предметы Предметы { get; set; }
    }
}
