using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Avalonia.Resources
{
    /// <summary>
    /// Stores all the resources localized for one particular culture, ignoring all other cultures, including any fallback rules.
    /// </summary>
    [ComVisible(true)]

    public class ResourceSet : IDisposable, IEnumerable
    {
        /// <summary>
        /// Indicates the <see cref="T:System.Resources.IResourceReader"/> used to read the resources.
        /// </summary>

        protected IResourceReader Reader;
        /// <summary>
        /// The <see cref="T:System.Collections.Hashtable"/> in which the resources are stored.
        /// </summary>
        protected Dictionary<object, object> Table;
        private Dictionary<object, object> _caseInsensitiveTable;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Resources.ResourceSet"/> class with default properties.
        /// </summary>
        protected ResourceSet()
        {
            this.CommonInit();
        }

        internal ResourceSet(bool junk)
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:System.Resources.ResourceSet"/> class using the system default <see cref="T:System.Resources.ResourceReader"/> that opens and reads resources from the given file.
        /// </summary>
        /// <param name="fileName">Resource file to read. </param><exception cref="T:System.ArgumentNullException">The <paramref name="fileName"/> parameter is null. </exception>
        public ResourceSet(string fileName)
        {
            this.Reader = ResourceReaderFactory.CreateResourceReader(fileName);
            this.CommonInit();
            this.ReadResources();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:System.Resources.ResourceSet"/> class using the system default <see cref="T:System.Resources.ResourceReader"/> that reads resources from the given stream.
        /// </summary>
        /// <param name="stream">The <see cref="T:System.IO.Stream"/> of resources to be read. The stream should refer to an existing resources file. </param><exception cref="T:System.ArgumentException">The <paramref name="stream"/> is not readable. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="stream"/> parameter is null. </exception>
        [SecurityCritical]
        public ResourceSet(Stream stream)
        {
            this.Reader = ResourceReaderFactory.CreateResourceReader(stream);
            this.CommonInit();
            this.ReadResources();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:System.Resources.ResourceSet"/> class using the specified resource reader.
        /// </summary>
        /// <param name="reader">The reader that will be used. </param><exception cref="T:System.ArgumentNullException">The <paramref name="reader"/> parameter is null. </exception>
        public ResourceSet(IResourceReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException("reader");
            this.Reader = reader;
            this.CommonInit();
            this.ReadResources();
        }

        /// <summary>
        /// Closes and releases any resources used by this <see cref="T:System.Resources.ResourceSet"/>.
        /// </summary>

        public virtual void Close()
        {
            this.Dispose(true);
        }

        /// <summary>
        /// Releases resources (other than memory) associated with the current instance, closing internal managed objects if requested.
        /// </summary>
        /// <param name="disposing">Indicates whether the objects contained in the current instance should be explicitly closed. </param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                IResourceReader resourceReader = this.Reader;
                this.Reader = (IResourceReader)null;
                if (resourceReader != null)
                    resourceReader.Close();
            }
            this.Reader = null;
            this._caseInsensitiveTable = null;
            this.Table = null;
        }

        /// <summary>
        /// Disposes of the resources (other than memory) used by the current instance of <see cref="T:System.Resources.ResourceSet"/>.
        /// </summary>

        public void Dispose()
        {
            this.Dispose(true);
        }

        /// <summary>
        /// Returns an <see cref="T:System.Collections.IDictionaryEnumerator"/> that can iterate through the <see cref="T:System.Resources.ResourceSet"/>.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Collections.IDictionaryEnumerator"/> for this <see cref="T:System.Resources.ResourceSet"/>.
        /// </returns>
        /// <exception cref="T:System.ObjectDisposedException">The resource set has been closed or disposed. </exception>
        [ComVisible(false)]

        public virtual Dictionary<object, object>.Enumerator GetEnumerator()
        {
            return this.GetEnumeratorHelper();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this.GetEnumeratorHelper();
        }

        private Dictionary<object, object>.Enumerator GetEnumeratorHelper()
        {
            var hashtable = this.Table;
            if (hashtable == null)
                throw new ObjectDisposedException(null, "ObjectDisposed_ResourceSet");
            else
                return hashtable.GetEnumerator();
        }

        /// <summary>
        /// Searches for a <see cref="T:System.String"/> resource with the specified name.
        /// </summary>
        /// 
        /// <returns>
        /// The value of a resource, if the value is a <see cref="T:System.String"/>.
        /// </returns>
        /// <param name="name">Name of the resource to search for. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name"/> parameter is null. </exception><exception cref="T:System.InvalidOperationException">The resource specified by <paramref name="name"/> is not a <see cref="T:System.String"/>. </exception><exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
        public virtual string GetString(string name)
        {
            object objectInternal = this.GetObjectInternal(name);
            try
            {
                return (string)objectInternal;
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidOperationException("InvalidOperation_ResourceNotString_Name");
            }
        }

        /// <summary>
        /// Searches for a <see cref="T:System.String"/> resource with the specified name in a case-insensitive manner, if requested.
        /// </summary>
        /// 
        /// <returns>
        /// The value of a resource, if the value is a <see cref="T:System.String"/>.
        /// </returns>
        /// <param name="name">Name of the resource to search for. </param><param name="ignoreCase">Indicates whether the case of the case of the specified name should be ignored. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name"/> parameter is null. </exception><exception cref="T:System.InvalidOperationException">The resource specified by <paramref name="name"/> is not a <see cref="T:System.String"/>.</exception><exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
        public virtual string GetString(string name, bool ignoreCase)
        {
            object objectInternal = this.GetObjectInternal(name);
            string str;
            try
            {
                str = (string)objectInternal;
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidOperationException("InvalidOperation_ResourceNotString_Name");
            }
            if (str != null || !ignoreCase)
                return str;
            object insensitiveObjectInternal = this.GetCaseInsensitiveObjectInternal(name);
            try
            {
                return (string)insensitiveObjectInternal;
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidOperationException("InvalidOperation_ResourceNotString_Name");
            }
        }

        /// <summary>
        /// Searches for a resource object with the specified name.
        /// </summary>
        /// 
        /// <returns>
        /// The requested resource.
        /// </returns>
        /// <param name="name">Case-sensitive name of the resource to search for. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name"/> parameter is null. </exception><exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>

        public virtual object GetObject(string name)
        {
            return this.GetObjectInternal(name);
        }

        /// <summary>
        /// Searches for a resource object with the specified name in a case-insensitive manner, if requested.
        /// </summary>
        /// 
        /// <returns>
        /// The requested resource.
        /// </returns>
        /// <param name="name">Name of the resource to search for. </param><param name="ignoreCase">Indicates whether the case of the specified name should be ignored. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name"/> parameter is null. </exception><exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
        public virtual object GetObject(string name, bool ignoreCase)
        {
            object objectInternal = this.GetObjectInternal(name);
            if (objectInternal != null || !ignoreCase)
                return objectInternal;
            else
                return this.GetCaseInsensitiveObjectInternal(name);
        }

        /// <summary>
        /// Reads all the resources and stores them in a <see cref="T:System.Collections.Hashtable"/> indicated in the <see cref="F:System.Resources.ResourceSet.Table"/> property.
        /// </summary>
        protected virtual void ReadResources()
        {
            var enumerator = this.Reader.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var dictionaryEnumerator = ((IDictionaryEnumerator) enumerator);

                object obj = dictionaryEnumerator.Value;
                this.Table.Add(dictionaryEnumerator.Key, obj);
            }
        }

        private object GetObjectInternal(string name)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            var hashtable = this.Table;
            if (hashtable == null)
                throw new ObjectDisposedException((string)null, "ObjectDisposed_ResourceSet");
            else
                return hashtable[(object)name];
        }

        private void CommonInit()
        {
            this.Table = new Dictionary<object, object>();
        }

        private object GetCaseInsensitiveObjectInternal(string name)
        {
            var hashtable1 = this.Table;
            if (hashtable1 == null)
                throw new ObjectDisposedException((string)null, "ObjectDisposed_ResourceSet");
            var hashtable2 = this._caseInsensitiveTable;
            if (hashtable2 == null)
            {
                hashtable2 = new Dictionary<object, object>((IEqualityComparer<object>)StringComparer.OrdinalIgnoreCase);
                IDictionaryEnumerator enumerator = hashtable1.GetEnumerator();
                while (enumerator.MoveNext())
                    hashtable2.Add(enumerator.Key, enumerator.Value);
                this._caseInsensitiveTable = hashtable2;
            }
            return hashtable2[(object)name];
        }
    }
}