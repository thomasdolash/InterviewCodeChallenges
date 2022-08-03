namespace Submarine {
    /// <summary>
    /// This is the submarine class.  For this coding challenge, your submarine needs to be able to accept a list of commands.
    /// 
    /// Each command will need to update a variable that is tracking the submarine depth or the horizontal position.  
    /// 
    ///     `forward X` increases the horizontal position by X units.
    ///     `down X` increases the depth by X units.
    ///     `up X` decreases the depth by X units.
    /// 
    /// </summary>
    public class Submarine {

        public Submarine(string InstructionFile = "input.txt") : this(File.ReadAllLines(InstructionFile)) { }

        /// <summary>
        /// Main Application Entry Point 
        /// 
        /// Goals:  Loop through a list of instructions
        /// For each instruction, process the instruction to navigate the submarine.
        /// </summary>
        /// <param name="Instructions"></param>
        public Submarine(string[] Instructions) {
            
        }


        public int Answer_Part1 { get; private set; }

        public int Answer_Part2 { get; private set; }
    }
}