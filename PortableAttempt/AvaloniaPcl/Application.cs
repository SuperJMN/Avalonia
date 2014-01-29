// -----------------------------------------------------------------------
// <copyright file="Application.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Avalonia.Resources;
using Avalonia.Threading;

namespace Avalonia
{


    public class Application : DispatcherObject
    {
        static Application()
        {
            RegisterDependencyProperties();
            GenericTheme = new ResourceDictionary();
            try
            {
                LoadComponent(GenericTheme, new Uri("/TestApp;component/Themes/Generic.xaml", UriKind.Relative));
            }
            catch (Exception)
            {
                Debug.WriteLine("Cannot Load Comoponent");
            }
            
        }

        public Application()
        {
            Application.Current = this;
            this.Resources = new ResourceDictionary();            
        }

        public static Application Current 
        { 
            get; 
            private set; 
        }

        public Window MainWindow 
        { 
            get; 
            set; 
        }

        public ResourceDictionary Resources
        {
            get;
            private set;
        }

        internal static ResourceDictionary GenericTheme
        {
            get;
            private set;
        }

        public static StreamResourceInfo GetResourceStream(Uri uriResource)
        {
            if (uriResource == null)
            {
                throw new ArgumentNullException("uriResource");
            }

            if (uriResource.OriginalString == null)
            {
                throw new ArgumentException("uriResource.OriginalString is null.");
            }

            if (uriResource.IsAbsoluteUri)
            {
                if (uriResource.Scheme == "pack")
                {
                    throw new NotSupportedException("pack: resources not yet supported.");
                }
                else
                {
                    throw new ArgumentException("uriResource is not relative and doesn't use the pack: scheme.");
                }
            }

            PackUri pack = new PackUri(uriResource);
            string assemblyName = pack.Assembly;
            var assemblyNameToLoad = new AssemblyName(assemblyName);

            
            var currentAssemblyNameRef = typeof (Application).GetTypeInfo().Assembly;

            Assembly assembly = (assemblyName != null) ? Assembly.Load(assemblyNameToLoad) : currentAssemblyNameRef;
            string resourceName = assembly.GetName().Name + ".g";
            var manager = ServiceLocator.ResourceManagerFactory.CreateResourceMananger(resourceName, assembly);

            using (IResourceSet resourceSet = manager.GetResourceSet(CultureInfo.CurrentCulture, true, true))
            {
                Stream stream = resourceSet.GetObject(pack.GetAbsolutePath(), true);

                if (stream == null)
                {
                    throw new IOException(
                        "The requested resource could not be found: " + 
                        uriResource.OriginalString);
                }

                return new StreamResourceInfo(stream, null);
            }
        }

        public static void LoadComponent(object component, Uri resourceLocator)
        {
            if (!resourceLocator.IsAbsoluteUri)
            {
                StreamResourceInfo sri = GetResourceStream(resourceLocator);
                XamlReader.Load(sri.Stream, component);
            }
            else
            {
                throw new ArgumentException("Cannot use absolute URI.");
            }
        }
        
        public object FindResource(object resourceKey)
        {
            object result = this.Resources[resourceKey];

            if (result == null)
            {
                throw new ResourceReferenceKeyNotFoundException(
                    string.Format("'{0}' resource not found", resourceKey),
                    resourceKey);
            }

            return result;
        }
        
        public void Run()
        {
            this.Run(this.MainWindow);
        }

        public void Run(Window window)
        {
            if (window != null)
            {
                window.Closed += (s, e) => this.Dispatcher.InvokeShutdown();
                window.Show();
            }

            if (this.MainWindow == null)
            {
                this.MainWindow = window;
            }

            Dispatcher.Run();
        }

        /// <summary>
        /// Ensures that all dependency properties are registered.
        /// </summary>
        private static void RegisterDependencyProperties()
        {
            var callingAssembly = typeof (Application).GetTypeInfo().Assembly;
            var types = from type in callingAssembly.DefinedTypes
                                      where typeof(DependencyObject).GetTypeInfo().IsAssignableFrom(type)
                                      select type;

            foreach (var type in types)
            {
                var firstStaticField = type.DeclaredFields.FirstOrDefault(info => info.IsStatic);

                if (firstStaticField != null)
                {
                    var o = firstStaticField.GetValue(null);
                }
            }

            // TODO PORT:
            //IEnumerable<Type> types = from type in Assembly.GetCallingAssembly().GetTypes()
            //                          where typeof(DependencyObject).IsAssignableFrom(type)
            //                          select type;

            //BindingFlags flags = BindingFlags.Public | BindingFlags.Static;

            //foreach (Type type in types)
            //{
            //    FieldInfo firstStaticField = type.GetFields(flags).FirstOrDefault();

            //    if (firstStaticField != null)
            //    {
            //        object o = firstStaticField.GetValue(null);
            //    }
            //}
        }

        public IResourceManager ResourceManager { get; set; }
        public static IXamlReader XamlReader { get; set; }
    }

    public interface IResourceSet : IDisposable
    {
        Stream GetObject(string getAbsolutePath, bool b);
    }
}
