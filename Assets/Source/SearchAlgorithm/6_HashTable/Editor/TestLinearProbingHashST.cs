﻿using NUnit.Framework;

namespace Algorithms.Search
{
    public class TestLinearProbingHashST
    {
        //keys: S E A R C H E X A M P  L  E
        //vals: 0 1 2 3 4 5 6 7 8 9 10 11 12
        private LinearProbingHashST<string, int> initST()
        {
            var st = new LinearProbingHashST<string, int>();
            st.put("S", 0);
            st.put("E", 1);
            st.put("A", 2);
            st.put("R", 3);
            st.put("C", 4);
            st.put("H", 5);
            st.put("E", 6);
            st.put("X", 7);
            st.put("A", 8);
            st.put("M", 9);
            st.put("P", 10);
            st.put("L", 11);
            st.put("E", 12);
            return st;
        }

        [Test]
        public void LPHashST_size_sizeIs10()
        {
            var st = initST();
            var res = st.size();
            Assert.AreEqual(res, 10);
        }
    }

}

