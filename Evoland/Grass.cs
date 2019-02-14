using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoland {
    public class Grass {
        private float _grassValue = 1f;
        float carryCapacity = 1000;
        float growthRate = 0.1f;

        public float GrassValue { get { return _grassValue; } }

        public void Run() {
            float growthModulator = (carryCapacity - _grassValue) / carryCapacity;
            _grassValue = _grassValue * (1f + (growthRate * growthModulator));
        }
    }
}
