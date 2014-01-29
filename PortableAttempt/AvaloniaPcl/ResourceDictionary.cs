// -----------------------------------------------------------------------
// <copyright file="ResourceDictionary.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace Avalonia
{
    // TODO PORT : [Ambient]
    public class ResourceDictionary : IDictionary, ICollection, IEnumerable, INameScope
    {
        private NameScope nameScope = new NameScope();

        private Dictionary<object, object> resources = new Dictionary<object, object>();

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public int Count
        {
            get { return this.resources.Count; }
        }

        public ICollection Keys
        {
            get { return this.resources.Keys; }
        }

        public ICollection Values
        {
            get { return this.resources.Values; }
        }

        public object this[object key]
        {
            get
            {
                object result;
                this.resources.TryGetValue(key, out result);
                return result;
            }

            set
            {
                this.resources[key] = value;
            }
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(object key, object value)
        {
            this.resources.Add(key, value);
        }

        public void Clear()
        {
            this.resources.Clear();
        }

        public bool Contains(object key)
        {
            return this.resources.ContainsKey(key);
        }

        public object FindName(string name)
        {
            return this.nameScope.FindName(name);
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            return this.resources.GetEnumerator();
        }

        public void RegisterName(string name, object scopedElement)
        {
            this.nameScope.RegisterName(name, scopedElement);
        }

        public void Remove(object key)
        {
            this.resources.Remove(key);
        }

        public void UnregisterName(string name)
        {
            this.nameScope.UnregisterName(name);
        }
    }
}
