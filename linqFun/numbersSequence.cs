using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace linqFun
{
    class numbersSequence : IEnumerable<int>
    {
        

        public IEnumerator<int> GetEnumerator()
        {
            return new numbersequenceemulater();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
