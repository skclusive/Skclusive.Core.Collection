﻿using System.Collections.Generic;

namespace Skclusive.Core.Collection
{
    public interface IMap<TKey, TValue> : IDictionary<TKey, TValue>
    {
        IMap<TKey, TValue> Replace(IDictionary<TKey, TValue> dictionary);
    }
}
