using System;
using System.Collections.Generic;
using System.Text;

namespace Baseline_Exersize
{
    public class MyMinMax
    {
        private int[] _array;
        private int _min;
        private int _max;

        public MyMinMax()
        {

        }
        public MyMinMax(int[] array)
        {
            _array[0] = array[0];
            _min = array[0];
            _max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                _array[i] = array[i];
                if (array[i] > _max)
                    _max = array[i];
                else if (array[i] < _min)
                    _min = array[i];
            }
        }

        public int getMin()
        {
            return _min;
        }

        public int[] getMinRange(int n)
        {
            int[] minRange = new int[n];
            for (int i = 0; i < n; i++)
            {
                minRange[i] = _array[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (minRange[i] > _array[j])
                    {
                        int temp = minRange[i];
                        minRange[i] = _array[j];
                        _array[j] = temp;
                    }
                }
            }
            return minRange;
        }

        public int getMax(int n)
        {
            return _max;
        }
        public int[] getMaxRange(int n)
        {
            int[] maxRange = new int[n];
            for (int i = 0; i < n; i++)
            {
                maxRange[i] = _array[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (maxRange[i] < _array[j])
                    {
                        int temp = maxRange[i];
                        maxRange[i] = _array[j];
                        _array[j] = temp;
                    }
                }
            }
            return maxRange;
        }
        public int[] all()
        {
            return _array;
        }
    }
       
}
