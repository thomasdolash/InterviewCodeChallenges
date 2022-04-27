namespace Submarine {
    public class Submarine : ISubmarine {
        
        public Submarine(string InstructionFile = "input.txt") {
        }
        public Submarine(string[] Instructions) {
        }

        public decimal CurrentTrajectoryV1 { get; private set; }

        public decimal CurrentTrajectoryV2 { get; private set; }
    }
}