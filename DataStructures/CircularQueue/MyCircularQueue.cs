//https://leetcode.com/problems/design-circular-queue/

namespace CircularQueue
{
    public class MyCircularQueue
    {
        private readonly int[] _queue;
        private int _first;
        private int _last;
        private int _count;

        private int MaxLength => _queue.Length;

        public MyCircularQueue(int k)
        {
            _queue = new int[k];
            _first = 0;
            _last = 0;
            _count = 0;
        }

        public bool EnQueue(int value)
        {
            if(IsFull())
            {
                return false;
            }

            _queue[_last] = value;
            _last = (_last + 1) % MaxLength;
            _count++;
            return true;
        }

        public bool DeQueue()
        {
            if(IsEmpty())
            {
                return false;
            }

            _first = (_first + 1) % MaxLength;
            _count--;
            return true;
        }

        public int Front()
        {
            if(IsEmpty())
            {
                return -1;
            }

            var returnValue = _queue[_first];
            return returnValue;
        }

        public int Rear()
        {
            if(IsEmpty())
            {
                return -1;
            }

            var returnValue = _queue[_last == 0 ? MaxLength - 1 : _last - 1];
            return returnValue;
        }

        public bool IsEmpty() => _count == 0;

        public bool IsFull() => _count == MaxLength;
    }
}