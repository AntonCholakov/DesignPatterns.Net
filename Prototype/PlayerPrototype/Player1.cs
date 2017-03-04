using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerPrototype
{
    public class Player1 : Player
    {
        public override Player Clone()
        {
            return (Player)this.MemberwiseClone();
        }

        public Player1 DeepCopy()
        {
            Player1 cloned = (Player1)this.MemberwiseClone();
            cloned.AdditionalInformation = new AdditionalInformation();
            cloned.AdditionalInformation.Health = this.AdditionalInformation.Health;
            cloned.AdditionalInformation.Money = this.AdditionalInformation.Money;

            return cloned;
        }
    }
}
