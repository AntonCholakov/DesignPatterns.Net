using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemRequestChainOfResponsibility
{
    class Ceo : Approver
    {
        public override void ProcessItemRequest(ItemRequest request)
        {
            double total = request.Item.Price * request.Quantity;
            if (total < 25000)
            {
                Console.WriteLine("{0} approved request for {1} for {2}", this.GetType().Name, request.Item.Name, total);
            }
            else if (base.Successor != null)
            {
                base.Successor.ProcessItemRequest(request);
            }
            else
            {
                Console.WriteLine("Request cannot be approved by anyone.");
            }
        }
    }
}
