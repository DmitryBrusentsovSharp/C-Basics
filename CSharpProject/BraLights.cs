using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class BraLights : ILights, iLightProblems
    {
        public float brightness { get; set; }
        public bool isOn { get; set; }
        public Lights type { get; set; }

        public void ElectricError()
        {
            Console.WriteLine("trouble with electiricity");
        }

        public bool isLightOn()
        {
            string isOnLight = isOn ? "on" : "off";
            Console.WriteLine($"Now is: {isOnLight}");
            return isOn;
        }

        public void turnOnOff(bool isOn)
        {
            this.isOn = isOn;
        }
    }
}
