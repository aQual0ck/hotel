//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hotel.AuxClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoomsClients
    {
        public int RoomId { get; set; }
        public int ClientId { get; set; }
        public Nullable<System.DateTime> MoveInDate { get; set; }
        public Nullable<System.DateTime> MoveOutDate { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Rooms Rooms { get; set; }
    }
}
