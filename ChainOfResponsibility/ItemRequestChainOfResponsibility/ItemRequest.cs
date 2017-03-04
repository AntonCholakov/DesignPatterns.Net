using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemRequestChainOfResponsibility
{
    class ItemRequest
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }

        public ItemRequest(Item item, int quantity)
        {
            this.Item = item;
            this.Quantity = quantity;
        }
    }
}
