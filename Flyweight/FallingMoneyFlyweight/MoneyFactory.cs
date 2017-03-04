using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingMoneyFlyweight
{
    class MoneyFactory
    {
        public static int ObjectCount { get; set; }
        private Dictionary<MoneyTypeEnum, Money> objects;

        public MoneyFactory()
        {
            this.objects = new Dictionary<MoneyTypeEnum, Money>();
        }

        public Money GetMoneyToDisplay(MoneyTypeEnum type)
        {
            if (objects.ContainsKey(type))
            {
                return objects[type];
            }

            switch (type)
            {
                case MoneyTypeEnum.Metallic:
                    objects.Add(type, new MetallicMoney());
                    ObjectCount++;
                    break;
                case MoneyTypeEnum.Paper:
                    objects.Add(type, new PaperMoney());
                    ObjectCount++;
                    break;
            }

            return objects[type];
        }
    }
}
