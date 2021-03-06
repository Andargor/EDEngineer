﻿using System;
using System.Collections.Generic;
using EDEngineer.Utils;
using EDEngineer.Utils.Collections;

namespace EDEngineer.Models
{
    public class State
    {
        private static readonly Func<KeyValuePair<string, Entry>, KeyValuePair<string, Entry>, int> comparer =
            (a, b) => string.Compare(a.Key, b.Key, StringComparison.Ordinal);

        private readonly object stateLock = new object();

        public State()
        {
            LoadBaseData();
        }

        public SortedObservableCounter Cargo { get; set; } = new SortedObservableCounter(comparer);

        public void LoadBaseData()
        {
            foreach (var name in ItemNameConverter.Names)
            {
                IncrementCargo(name, 0);
            }
        }

        public void IncrementCargo(string name, int change)
        {
            lock (stateLock)
            {
                Cargo.Increment(name, change);
            }
        }
    }
}