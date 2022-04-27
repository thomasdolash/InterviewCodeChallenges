using System.Collections.Generic;
using Xunit;

namespace Submarine {
    public class UnitTest1 {
        private readonly string[] unitTestData = new string[] { "forward 5", "down 5", "forward 8", "up 3", "down 8", "forward 2" };

        [Fact]
        public void Part1_BasicTest() {
            Submarine s = new Submarine(unitTestData);
            Assert.Equal(150, s.CurrentTrajectoryV1);
        }

        [Fact]
        public void Part1_FullTest() {
            Submarine s = new Submarine();
            Assert.Equal(1635930, s.CurrentTrajectoryV1);
        }

        [Fact]
        public void Part2_BasicTest() {
            Submarine s = new Submarine(unitTestData);
            Assert.Equal(900, s.CurrentTrajectoryV2);
        }

        [Fact]
        public void Part2_FullTest() {
            Submarine s = new Submarine();
            Assert.Equal(1781819478, s.CurrentTrajectoryV2);
        }
    }
}