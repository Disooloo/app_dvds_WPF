//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace shop_DVDs.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class DVDsDB
    {
        public int C_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public Nullable<int> rating { get; set; }
        public Nullable<int> seller { get; set; }
        public string price { get; set; }
        public Nullable<int> inStock { get; set; }
    
        public virtual sellersDB sellersDB { get; set; }
    }
}
