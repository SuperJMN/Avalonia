// -----------------------------------------------------------------------
// <copyright file="Application.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using Avalonia.Resources;
using Avalonia.Threading;

namespace Avalonia
{
    public abstract class ApplicationBase : DispatcherObject
    {
        static ApplicationBase()
        {            
            GenericTheme = new ResourceDictionary();            
        }

        public ApplicationBase()
        {
            RegisterDependencyProperties();
            LoadComponent(GenericTheme, new Uri("/Avalonia;component/Themes/Generic.xaml", UriKind.Relative));

            Current = this;
            this.Resources = new ResourceDictionary();
        }

        public static ApplicationBase Current
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

        public static ResourceDictionary GenericTheme
        {
            get;
            set;
        }

        public abstract StreamResourceInfo GetResourceStream(Uri uriResource);

        public abstract void LoadComponent(object component, Uri resourceLocator);

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
        protected abstract void RegisterDependencyProperties();


    }
}
