using System;

namespace ConsoleNetwork
{
    public class NeuralNetwork
    {
        public static double learningRate;
        private Soma[] somas; // somas
        private Dendrite[] dendrites; // dendrites
        private Axon[] axons; // axons

        public Axon[] Axons { get => axons; set => axons = value; }
        public Dendrite[] Dendrites { get => dendrites; set => dendrites = value; }
        public Soma[] Somas { get => somas; set => somas = value; }
        public static double LearningRate { get => learningRate; set => learningRate = value; }

        private void Init(string t) => Console.WriteLine(t);

        public NeuralNetwork()
        {
            Init("Network initialised");
        }

        public NeuralNetwork(int neuronCount)
        {
            Dendrites = new Dendrite[neuronCount];
            Init("Network initialised");
        }

        public NeuralNetwork(int neuronCount, double learningFactor)
        {
            Dendrites = new Dendrite[neuronCount];
            LearningRate = learningFactor;
            Init("Network initialised");
        }

        public void GenerateNeurons(int numberNeurons)
        {
            Dendrite[] neurons = new Dendrite[numberNeurons];
            for (int i = 0; i < numberNeurons; i++)
            {
                Dendrite n = new Dendrite("Dendrite" + i);
                neurons[i] = n;

            }
            Console.WriteLine("{0} neurons generated", numberNeurons);
            Dendrites = neurons;
        }
    }
}
