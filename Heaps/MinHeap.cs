using System;
using System.Collections.Generic;
namespace Heaps
{
    public class MinHeap
    {
        private readonly int [] heapArray;
        private readonly int _capacity;
        private int _heap_size;

        public MinHeap(int capacity)
        {
            _capacity = capacity;
            _heap_size = 0;
            heapArray = new int[capacity]; 
        }

        public int parent(int index)
        {
            return (index - 1) / 2;
        }

        public int left(int index)
        {
            return 2 * index + 1; 
        }

        public int right(int index)
        {
            return 2 * index + 2;
        }

        public void insertKey(int data)
        {
            if(_heap_size == _capacity)
            {
                throw new Exception("OverFlow: Could not insertKey");
            }
            
            _heap_size++;
            var index = _heap_size-1; 
            heapArray[index] = data;

            while (index != 0 && heapArray[parent(index)] > heapArray[index])
            {
                swap(index, parent(index));
                index = parent(index);
            }
        }

        public void decreaseKey(int index,int newValue)
        {
            heapArray[index] = newValue;
            while(index!=0 && heapArray[parent(index)] > heapArray[index])
            {
                swap(index, parent(index));
                index = parent(index);
            }
        }

        public int extractMin()
        {
            if (_heap_size <= 0)
                return Int32.MaxValue;
            if (_heap_size == 1)
            {
                _heap_size--;
                return heapArray[0];
            }

            int root = heapArray[0];
            heapArray[0] = heapArray[_heap_size - 1];
            _heap_size--;
            MinHeapify(0);
            return root;
        }

        public void deleteKey(int index)
        {
            decreaseKey(index, Int32.MinValue);
            extractMin();
        }

        public void MinHeapify(int index)
        {
            var _left = left(index);
            var _right = right(index);
            var smallest = index;

            if ( _left < _heap_size && heapArray[_left] < heapArray[_right])
            {
                smallest = _left;
            }

            if ( _right < _heap_size && heapArray[_right] < heapArray[smallest])
            {
                smallest = _right;
            }

            if (smallest != index)
            {
                swap(index, smallest);
                MinHeapify(smallest);
            }
        }

        private void swap(int index, int swapWithIndex)
        {
            var temp = heapArray[index];
            heapArray[index] = heapArray[swapWithIndex];
            heapArray[swapWithIndex] = temp;
        }
    }
}
