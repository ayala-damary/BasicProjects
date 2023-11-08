using System;
using System.Collections.Generic;
using System.Text;

namespace Baseline_Exersize
{
   public class Counter
    {

        private Dictionary<int, int> _counts;
        private Dictionary<int, int> _limits;

        public Counter()
        {
            _counts = new Dictionary<int, int>();
            _limits = new Dictionary<int, int>();
        }

        public void AddLimit(int n, int limit)
        {
            if (_counts.ContainsKey(n))
            {
                if (limit < _counts[n])
                {
                    throw new Exception("OverTheLimit");
                }
                _limits[n] = limit;
            }
            else
            {
                _counts[n] = 0;
                _limits[n] = limit;
            }
        }

        public void Count(int n)
        {
            if (_limits.ContainsKey(n))
            {
                if (_counts[n] + 1 > _limits[n])
                {
                    throw new Exception("OverTheLimit");
                }
                _counts[n]++;
            }
            else
            {
                _counts[n]++;
            }
        }

        public int Get(int n)
        {
            if (_counts.ContainsKey(n))
            {
                return _counts[n];
            }
            else
            {
                return 0;
            }
        }

        public int? GetLimit(int n)
        {
            if (_limits.ContainsKey(n))
            {
                return _limits[n];
            }
            else
            {
                return null;
            }
        }
    }

}

