using System;
using System.Collections.Generic;
using System.Text;

namespace linqFun
{
    class numbersequenceemulater : IEnumerator<int>
    {
        private int _n;
        
        public bool moveNext()
        {
            
            _n++;
            Console.WriteLine("moving next to " + _n);
            Thread.Sleep(5);
                return _n < 10;
        }
        public int current => _n;
        object? ienumerator.current
            => current;
        public void Dispose() { }
        public void reset()
        {

        }
    }
    
    
}
