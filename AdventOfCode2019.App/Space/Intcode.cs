using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2019.App.Space
{
    public class Intcode
    {
        private readonly IReadOnlyList<int> _ops;

        public Intcode(params int[] ops)
        {
            _ops = ops;
        }

        public int Run()
        {
            return Run(_ops[1], _ops[2]);
            var opsCopy = _ops.Select(i => i).ToArray();

        }

        public int Run(int param1, int param2)
        {
            var opsCopy = _ops.Select(i => i).ToArray();
            opsCopy[1] = param1;
            opsCopy[2] = param2;
            for (var pointer = 0; pointer < _ops.Count; pointer += 4)
            {
                if (!Run(opsCopy, pointer)) break;
            }
            return opsCopy[0];
        }

        private bool Run(int[] ops, int pointer)
        {
            var op = ops[pointer];
            switch (op)
            {
                case 99:
                    return false;
                case 1:
                    Add(ops, pointer);
                    break;
                case 2:
                    Multiply(ops, pointer);
                    break;
            }

            return true;
        }

        private void Add(int[] ops, int pointer)
        {
            var input1 = ops[ops[pointer + 1]];
            var input2 = ops[ops[pointer + 2]];
            var storePosition = ops[pointer + 3];
            ops[storePosition] = input1 + input2;
        }
        
        private void Multiply(int[] ops, int pointer)
        {
            var input1 = ops[ops[pointer + 1]];
            var input2 = ops[ops[pointer + 2]];
            var storePosition = ops[pointer + 3];
            ops[storePosition] = input1 * input2;
        }

        public int[] RunFor(int expected)
        {
            var limit = Math.Min(_ops.Count, 100);
            for (var noun = 0; noun < limit; noun++)
            {
                for (var verb = 0; verb < limit; verb++)
                {
                    var actual = Run(noun, verb);
                    if (actual == expected) return new int[] {noun, verb};
                }
            }

            return Array.Empty<int>();
        }
    }
}