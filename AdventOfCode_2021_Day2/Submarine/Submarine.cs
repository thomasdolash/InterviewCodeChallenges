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

        
        // Direction 
        private int aim = 0;

        /// <summary>
        /// Main Application Entry Point 
        /// 
        /// Goals:  Loop through a list of instructions
        /// For each instruction, process the instruction to navigate the submarine.
        /// </summary>
        /// <param name="Instructions"></param>
        public Submarine(string[] Instructions) {
            // Iterate upon the instruction set

            ProcessInstructions_Simple(Instructions);
            ProcessInstructions_Complex(Instructions);

        }

        private void ProcessInstructions_Simple(string[] Instructions)
        {
            // Submarine depth
            int depth = 0;
            // Distance traveled in the horizontal plane
            int horizontalDistance = 0;

            foreach (string Instruction in Instructions)
            {
                // Initialize our components with the input
                string[] components = Instruction.Split(" ");

                // get our command from our components
                string command = components[0];
                // get our magnitude from the components
                int magnitude = int.Parse(components[1]);

                switch (command)
                {
                    case "up":
                        depth -= magnitude; // Go deeper
                        aim -= magnitude;
                        break;
                    case "down":
                        depth += magnitude; // Go more shallow
                        aim += magnitude;
                        break;
                    case "forward":
                        horizontalDistance += magnitude; // Go further forward/backwards
                        break;
                }
            }

            this.Answer_Part1 += depth * horizontalDistance;
        }

        private void ProcessInstructions_Complex(string[] Instructions)
        {
            int depth = 0;
            int aim = 0;
            int horizontalDistance = 0;

            foreach (string Instruction in Instructions)
            {
                // Initialize our components with the input
                string[] components = Instruction.Split(" ");

                // get our command from our components
                string command = components[0];
                // get our magnitude from the components
                int magnitude = int.Parse(components[1]);

                switch (command)
                {
                    case "up":
                        //depth -= magnitude; // Go deeper
                        aim -= magnitude;
                        break;
                    case "down":
                        //depth += magnitude; // Go more shallow
                        aim += magnitude;
                        break;
                    case "forward":
                        horizontalDistance += magnitude; // Go further forward/backwards
                        // Increase depth by aim * instruction magnitude
                        depth += aim * magnitude;
                        break;
                }
            }

            this.Answer_Part2 = depth * horizontalDistance;
        }


        /// <summary>
        /// Process our inbound instruction in order to calculate our new depth and distance
        /// </summary>
        /// <param name="Instruction"></param>
        private void ProcessInstruction(string Instruction)
        {
            

        }


        public int Answer_Part1 { get; private set; }

        public int Answer_Part2 { get; private set; }
    }
}