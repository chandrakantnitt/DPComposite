using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent<string> plant = new Composite<string>("Plant");
            IComponent<string> pipeline = new Composite<string>("Pipeline");
            pipeline.Add(new Component<string>("Tube1"));
            pipeline.Add(new Component<string>("Tube2"));
            pipeline.Add(new Component<string>("Valve1"));
            pipeline.Add(new Component<string>("Tube3"));
            plant.Add(pipeline);
            plant.Add(new Component<string>("Pipes"));
            plant.Add(new Component<string>("Equipment"));
            plant.Add(new Component<string>("Structures"));

            Console.WriteLine(plant.Display(2));

            var searchComponent = plant.Find("Tube3");
            Console.WriteLine(searchComponent.Display(4));


            Console.ReadKey();
        }
    }
}
