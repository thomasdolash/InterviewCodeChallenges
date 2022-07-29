namespace Submarine {
    public class Submarine : ISubmarine {

        public Submarine(string InstructionFile = "input.txt") : this(File.ReadAllLines(InstructionFile)) { }

        public Submarine(string[] Instructions) {
            
        }


        public decimal Answer_Part1 { get; private set; }

        public decimal Answer_Part2 { get; private set; }
    }
}