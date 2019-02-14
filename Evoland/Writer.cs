using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evoland {
    class Writer {

        public Writer (GameState state) {
            _state = state;
            file = new FileStream("log.txt", FileMode.Open);
            file.Write(Encoding.ASCII.GetBytes("Starting new world..."), 0, Encoding.ASCII.GetByteCount("Starting new world..."));
            file.Close();
        }

        GameState _state;
        FileStream file; 


    }
}
