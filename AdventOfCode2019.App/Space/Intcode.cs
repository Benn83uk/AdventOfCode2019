using System.Net.Sockets;

namespace AdventOfCode2019.App.Space
{
    public class Intcode
    {
        private int[] _ops;

        public Intcode(params int[] ops)
        {
            _ops = ops;
        }

        public int Run()
        {
            for (var pointer = 0; pointer < _ops.Length; pointer += 4)
            {
                if (!Run(pointer)) break;
            }
            return _ops[0];
        }

        public int Run(int param1, int param2)
        {
            _ops[1] = param1;
            _ops[2] = param2;
            return Run();
        }

        private bool Run(int pointer)
        {
            var op = _ops[pointer];
            switch (op)
            {
                case 99:
                    return false;
                case 1:
                    Add(pointer);
                    break;
                case 2:
                    Multiply(pointer);
                    break;
            }

            return true;
        }

        private void Add(int pointer)
        {
            var input1 = _ops[_ops[pointer + 1]];
            var input2 = _ops[_ops[pointer + 2]];
            var storePosition = _ops[pointer + 3];
            _ops[storePosition] = input1 + input2;
        }
        
        private void Multiply(int pointer)
        {
            var input1 = _ops[_ops[pointer + 1]];
            var input2 = _ops[_ops[pointer + 2]];
            var storePosition = _ops[pointer + 3];
            _ops[storePosition] = input1 * input2;
        }
    }
}