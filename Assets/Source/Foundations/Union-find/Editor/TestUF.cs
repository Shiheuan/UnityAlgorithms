﻿using NUnit.Framework;

namespace Algorithms.Foundations
{
    public class TestUF
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void UF_CreateNewUF_EveryNodeIdIsSelf(int n)
        {
            var uf = new UF(n);

            var res = uf.find(n-1);

            Assert.AreEqual(res, n-1);

        }

        [TestCase(10,0,5)]
        [TestCase(50,1,25)]
        public void union_ConnectTwoNode_GetOneIndex(int n, int p, int q)
        {
            var uf = new UF(n);
            uf.union(p, q);
            var res = uf.connected(p, q);

            Assert.True(res);
        }

        [Test]
        public void union_ConnectTwoSet_AllOneIndex()
        {
            var uf = new UF(3);
            uf.union(0, 1);
            uf.union(1, 2);

            var res = uf.connected(0, 2);

            Assert.True(res);
        }
    }
}

