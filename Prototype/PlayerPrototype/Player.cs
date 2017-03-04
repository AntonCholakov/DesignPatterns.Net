using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerPrototype
{
    public abstract class Player
    {
        public Player()
        {
            this.AdditionalInformation = new AdditionalInformation();
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }

        public AdditionalInformation AdditionalInformation { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Name: " + this.Name);
            sb.AppendLine("Age: " + this.Age);
            sb.AppendLine("Level: " + this.Level);

            sb.AppendLine("Money: " + this.AdditionalInformation.Money);
            sb.AppendLine("Health: " + this.AdditionalInformation.Health);

            return sb.ToString();
        }

        public abstract Player Clone();
    }
}
