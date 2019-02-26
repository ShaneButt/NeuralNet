using System;

namespace ConsoleNetwork
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("what would u like to do");
            if (Console.ReadLine().ToLower().Equals("network"))
            {
                Console.WriteLine("input neuron amount");
                int count = Convert.ToInt32(Console.ReadLine());

                NeuralNetwork neuralNetwork = new NeuralNetwork();
                neuralNetwork.GenerateNeurons(count);
                Dendrite[] dendrites = neuralNetwork.Dendrites;

                foreach (Dendrite n in dendrites)
                {
                    Console.WriteLine(n.Name);
                }
                Console.ReadLine();
             }
        }
    }
}
