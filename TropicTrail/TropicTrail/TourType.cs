//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TropicTrail
{
    using System;
    using System.Collections.Generic;
    
    public partial class TourType
    {
        public TourType()
        {
            this.Offers = new HashSet<Offers>();
        }
    
        public int tourId { get; set; }
        public string tourName { get; set; }
        public string userId { get; set; }
    
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
