using System.Collections.Generic;

namespace Neural_Lesson1
{
    public class Topology
    {
        public int InputCount { get; }
        public int OutputCount { get; }
        public List<int> HiddenLayers { get; }

        public Topology(int inputCout, int outputCount, params int[] layers)
        {
            InputCount = inputCout;
            OutputCount = outputCount;
            HiddenLayers = new List<int>();
            HiddenLayers.AddRange(layers);
        }
    }
}
