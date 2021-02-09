using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign
    {
        public Campaign()
        {

        }
        public string Id { get; set; }
        public string EffectedCategories { get; set; }
        public short DiscountPercent { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
    }
}
