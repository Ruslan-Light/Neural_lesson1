using System;
using System.Collections.Generic;

namespace Neural_Lesson1
{
    public class Neuron
    {
        public List<double> Weights { get; }
        public NeuronType NeuronType { get; }

        // сюда кладем результат, что бы к нему можно было быстро обращатсья
        public double Output { get; private set; }

        public Neuron(int inputCount, NeuronType neuronType = NeuronType.Normal)
        {
            NeuronType = neuronType;
            Weights = new List<double>();

            for(int i = 0; i < inputCount; i++)
            {
                Weights.Add(1);
            }
        }

        public double FeedForward(List<double> inputs)
        {
            // TODO: добавить системы проверок входных корректных данных

            var sum = 0.0;
            for(int i = 0; i < inputs.Count; i++)
            {
                sum = +inputs[i] * Weights[i];
            }

            if(NeuronType != NeuronType.Input)
            {
                Output = Sigmoid(sum);
            }
            else
            {
                Output = sum;
            }
            
            return Output;
        }

        private double Sigmoid(double x)
        {
            var result = 1.0 / (1.0 + Math.Pow(Math.E, -x));
            return result;
        }

        public void SetWeights(params double[] weights)
        {
            // TODO: проверка на количество весов и входных инпутов у нейрона
            // удалить после добавления возможности обучения сети
            for (int i = 0; i < weights.Length; i++)
            {
                Weights[i] = weights[i];
            }
        }

        public override string ToString()
        {
            return Output.ToString();
        }
    }
}
