// -----------------------------------------------------------------------
// <copyright file="DependencyObjectType.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Avalonia
{
    public class DependencyObjectType
    {
        private static Dictionary<Type, DependencyObjectType> typeMap = new Dictionary<Type, DependencyObjectType>();
        private static int currentId;

        private DependencyObjectType(int id, Type systemType)
        {
            this.Id = id;
            this.SystemType = systemType;
        }

        public DependencyObjectType BaseType
        {
            get { return DependencyObjectType.FromSystemType(this.SystemType.GetTypeInfo().BaseType); }
        }

        public int Id
        {
            get;
            private set;
        }

        public string Name
        {
            get { return this.SystemType.Name; }
        }

        public Type SystemType
        {
            get;
            private set;
        }

        public static DependencyObjectType FromSystemType(Type systemType)
        {
            if (typeMap.ContainsKey(systemType))
            {
                return typeMap[systemType];
            }

            DependencyObjectType dot = new DependencyObjectType(currentId++, systemType);
            typeMap[systemType] = dot;
            return dot;
        }

        public bool IsInstanceOfType(DependencyObject dependencyObject)
        {
            // TODO PORT: 
            // return this.SystemType.IsInstanceOfType(dependencyObject);
            return true;
        }

        public bool IsSubclassOf(DependencyObjectType dependencyObjectType)
        {
            return this.SystemType.GetTypeInfo().IsSubclassOf(dependencyObjectType.SystemType);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}