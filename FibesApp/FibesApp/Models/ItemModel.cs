using System;
using System.Collections.Generic;
using System.Text;

namespace FibesApp.Models
{
    public class ItemModel
    {
        public int Id { get; set; } 
        public string ItemImage { get; set; } 
        public bool IsLike { get; set; }
        public bool IsNotLike { get; set; }
        public double ItemHeight { get; set; }

    }
}
