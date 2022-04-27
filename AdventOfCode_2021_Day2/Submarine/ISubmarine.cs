using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submarine {
    public interface ISubmarine {
        public decimal CurrentTrajectoryV1 { get; }

        public decimal CurrentTrajectoryV2 { get; }
    }
}
