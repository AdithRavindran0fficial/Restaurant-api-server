using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain.Models.UserModels.ItemModel
{
    public class Item
    {
        public int ItemId { get; set; }
        public string CategoryName { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
