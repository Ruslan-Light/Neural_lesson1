﻿using System.Collections.Generic;

namespace Neural_Lesson1
{
    public class Layer
    {
        public List<Neuron> Neurons { get; }
        public int Count => Neurons?.Count ?? 0;

        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            // TODO: проверить все входные нейроны на соответсвие типу

            Neurons = neurons;
        }

        public List<double> GetSignals()
        {
            var result = new List<double>();
            foreach(var neuron in Neurons)
            {
                result.Add(neuron.Output);
            }
            return result;
        }
    }
}
