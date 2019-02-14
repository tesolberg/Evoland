using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoland {
    abstract class Animal : IFood {
        public static int IdCounter = 0;
        public int Id { get; } = IdCounter++;

        public abstract IFood diet { get; }

        public abstract int nutritionalValue { get; }
    }
}
