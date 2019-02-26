using System;

namespace ConsoleNetwork
{
    public class Dendrite
    {
        public string name = "";
        public double weight = 0.0;
        public double learningFactor;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public double LearningFactor { get => learningFactor; set => learningFactor = value; }

        public Dendrite()
        {
            Weight = new Random().NextDouble();
            Name = "Dendrite";
        }

        public Dendrite(string name)
        {
            Name = name;
            Weight = new Random().NextDouble();
        }

        public Dendrite(double weight)
        {
            Weight = weight;
        }

        public Dendrite(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
