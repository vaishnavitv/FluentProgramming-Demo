﻿using System.Collections.Generic;

namespace FluentProgramming_Demo
{
    public class ListBuilder<T>
    {
        readonly List<T> inputList;

        public ListBuilder()
        {
            inputList = new List<T>();
        }
        public ListBuilder(IEnumerable<T> enumerable) : this()
        {
            foreach (T item in enumerable)
            {
                AddItem(item);
            }
        }

        public ListBuilder<T> RemoveItem(T item)
        {
            while (inputList.Remove(item)) ;
            return this;
        }

        public ListBuilder<T> AddItem(T item)
        {
            inputList.Add(item);
            return this;
        }

        //This is the final state of the builder.
        public List<T> ToList()
        {
            return inputList;
        }

    }
}
