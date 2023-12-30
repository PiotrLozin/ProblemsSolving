using ProblemsSolving.TopInterview150.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProblemsSolving.TopInterview150.Medium
{
    public class RandomizedSet
    {
        private List<int> randomizedList;
        Random rnd;

        public RandomizedSet()
        {
            randomizedList = new List<int> { };
            rnd = new Random();
        }

        public bool Insert(int val)
        {
            if(!randomizedList.Contains(val)) 
            {
                randomizedList.Add(val);
                return true;
            }

            return false;
        }

        public bool Remove(int val)
        {
            if (randomizedList.Contains(val))
            {
                randomizedList.Remove(val);
                return true;
            }

            return false;
        }

        public int GetRandom()
        {
            int randomIndex = rnd.Next(0, randomizedList.Count);
            return randomizedList[randomIndex];
        }
    }
}

//public static void Main(string[] args)
//{
//    RandomizedSet randomizedSet = new RandomizedSet();
//    Assert.True(randomizedSet.Insert(1));
//    Assert.True(randomizedSet.Insert(2));
//    Assert.True(!randomizedSet.Insert(2));
//    Assert.True(randomizedSet.Remove(2));
//    Assert.Equal(1, randomizedSet.GetRandom());
//}
