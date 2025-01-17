using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class NeighboringBitwiseXor
    {
        public bool DoesValidArrayExist(int[] derived)
        {
            if (derived.Length == 1)
            {
                return derived[0] == 1 ? false : true;
            }

            int[] original = this.SetOriginalArray(derived);
            this.FillAllElementsInOriginalArray(original, derived);

            int i = derived.Length - 2;
            int derivedFromOriginal = original[i] ^ original[i + 1];
            if (derived[i] == derivedFromOriginal)
            {
                return true;
            }

            return false;
        }

        private int[] SetOriginalArray(int[] derived)
        {
            int[] original = new int[derived.Length];
            if (derived[derived.Length - 1] == 0)
            {
                original[0] = 0;
                original[derived.Length - 1] = 0;
            }
            else
            {
                original[0] = 0;
                original[derived.Length - 1] = 1;
            }

            return original;
        }

        private void FillAllElementsInOriginalArray(int[] original, int[] derived)
        {
            for (int i = 0; i < derived.Length - 2; i++)
            {
                original[i + 1] = derived[i] ^ original[i];
            }
        }

    }

    public class NeighboringBitwiseXorTests
    {
        [Test]
        public void FirstTest()
        {
            NeighboringBitwiseXor neighboringBitwiseXor = new NeighboringBitwiseXor();
            int[] derived = { 1, 1, 0 };

            bool actual = neighboringBitwiseXor.DoesValidArrayExist(derived);
            bool expected = true;

            ClassicAssert.AreEqual(expected, actual);
        }
    }
}
