// -----------------------------------------------------------------------
// <copyright file="BitmapDecoder.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Avalonia.Platform;
using Avalonia.Platform;
using Avalonia.Threading;

namespace Avalonia.Media.Imaging
{
    public abstract class BitmapDecoder : DispatcherObject
    {
        private IPlatformBitmapDecoder impl;
        private ReadOnlyCollection<BitmapFrame> frames;

        internal BitmapDecoder(IPlatformBitmapDecoder platformImpl)
        {
            this.impl = platformImpl;
        }

        public virtual ReadOnlyCollection<BitmapFrame> Frames 
        { 
            get
            {
                if (this.frames == null)
                {
                    var e = this.impl.Frames.Select(x => new BitmapFrame(x));
                    this.frames = new ReadOnlyCollection<BitmapFrame>(e.ToList());
                }

                return this.frames;
            }
        }

        public static BitmapDecoder Create(
            Stream bitmapStream,
            BitmapCreateOptions createOptions,
            BitmapCacheOption cacheOption)
        {
            IPlatformBitmapDecoder platformImpl = PlatformInterface.Instance.CreateBitmapDecoder(
                bitmapStream,
                cacheOption);
            BitmapDecoder result;

            switch (platformImpl.ContainerFormat)
            {
                case BitmapContainerFormat.Jpeg:
                    result = new JpegBitmapDecoder(platformImpl);
                    break;
                case BitmapContainerFormat.Png:
                    result = new PngBitmapDecoder(platformImpl);
                    break;
                default:
                    throw new NotSupportedException();
            }

            if (cacheOption == BitmapCacheOption.OnLoad)
            {
                ReadOnlyCollection<BitmapFrame> loadFrames = result.Frames;                
            }

            return result;
        }

        public static BitmapDecoder Create(
            Uri bitmapUri, 
            BitmapCreateOptions createOptions, 
            BitmapCacheOption cacheOption)
        {

            Stream stream;
            
            if (!bitmapUri.IsAbsoluteUri)
            {
                stream = Application.GetResourceStream(bitmapUri).Stream;
            }
            else if (bitmapUri.IsFile)
            {
                stream = ServiceLocator.FileService.GetFileStreamForReading(bitmapUri.AbsolutePath);              
            }
            else
            {
                throw new NotSupportedException("URI not yet supported.");
            }

            return Create(stream, createOptions, cacheOption);
        }
    }
}
