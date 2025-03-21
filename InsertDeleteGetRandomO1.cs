using System;
using System.Collections.Generic;

public class RandomizedSet
{
   private Dictionary<int, int> valToIndex;
   private List<int> values;
   private Random random;

   public RandomizedSet()
   {
      valToIndex = new Dictionary<int, int>();
      values = new List<int>();
      random = new Random();
   }

   public bool Insert(int val)
   {
      if (valToIndex.ContainsKey(val))
      {
         return false;
      }

      valToIndex[val] = values.Count;
      values.Add(val);
      return true;
   }

   public bool Remove(int val)
   {
      if (!valToIndex.ContainsKey(val))
      {
         return false;
      }

      int index = valToIndex[val];
      int lastElement = values[values.Count - 1];

      values[index] = lastElement;
      valToIndex[lastElement] = index;

      values.RemoveAt(values.Count - 1);
      valToIndex.Remove(val);

      return true;
   }

   public int GetRandom()
   {
      return values[random.Next(values.Count)];
   }
}
