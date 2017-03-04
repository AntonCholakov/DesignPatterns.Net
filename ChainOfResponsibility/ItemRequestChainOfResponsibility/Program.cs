using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemRequestChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamMember john = new TeamMember();
            TeamLead jack = new TeamLead();
            ProjectManager katty = new ProjectManager();
            Ceo bill = new Ceo();

            john.SetSuccessor(jack);
            jack.SetSuccessor(katty);
            katty.SetSuccessor(bill);

            Item pen = new Item();
            pen.Name = "Pen";
            pen.Price = 1;

            Item chair = new Item();
            chair.Name = "Chair";
            chair.Price = 198;

            Item smartTv = new Item();
            smartTv.Name = "Smart TV";
            smartTv.Price = 700;

            Item lambo = new Item();
            lambo.Name = "Lambo";
            lambo.Price = 56000;

            john.ProcessItemRequest(new ItemRequest(pen, 8));
            john.ProcessItemRequest(new ItemRequest(chair, 1));
            john.ProcessItemRequest(new ItemRequest(smartTv, 2));
            john.ProcessItemRequest(new ItemRequest(lambo, 1));
        }
    }
}
