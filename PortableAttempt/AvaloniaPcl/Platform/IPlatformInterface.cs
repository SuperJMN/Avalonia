using System;
using System.IO;
using Avalonia.Platform;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace Avalonia.Platform
{
    public interface IPlatformInterface
    {
        TimeSpan CaretBlinkTime { get; }

        /// <summary>
        /// Gets the platform-specific dispatcher implementation.
        /// </summary>
        IPlatformDispatcher Dispatcher { get; }

        /// <summary>
        /// Gets the platform-specific keyboard device.
        /// </summary>
        KeyboardDevice KeyboardDevice { get; }

        /// <summary>
        /// Gets the platform-specific mouse device.
        /// </summary>
        MouseDevice MouseDevice { get; }

        /// <summary>
        /// Creates a new platform-specific bitmap decoder for the specified container format.
        /// </summary>
        /// <param name="format">The bitmap container format.</param>
        /// <returns>An <see cref="IPlatformBitmapDecoder"/>.</returns>
        IPlatformBitmapDecoder CreateBitmapDecoder(BitmapContainerFormat format);

        /// <summary>
        /// Creates a new platform-specific bitmap decoder to decode a stream.
        /// </summary>
        /// <param name="stream">The stream containing the bitmap.</param>
        /// <param name="cacheOption">The cache option.</param>
        /// <returns>An <see cref="IPlatformBitmapDecoder"/>.</returns>
        IPlatformBitmapDecoder CreateBitmapDecoder(
            Stream stream, 
            BitmapCacheOption cacheOption);

        /// <summary>
        /// Creates a new platform-specific bitmap encoder for the specified container format.
        /// </summary>
        /// <param name="format">The bitmap container format.</param>
        /// <returns>An <see cref="IPlatformBitmapEncoder"/>.</returns>
        IPlatformBitmapEncoder CreateBitmapEncoder(BitmapContainerFormat format);

        /// <summary>
        /// Creates a new platform-specific render target bitmap.
        /// </summary>
        /// <param name="pixelWidth">The width in pixels.</param>
        /// <param name="pixelHeight">The height in pixels.</param>
        /// <param name="dpiX">The horizontal resolution.</param>
        /// <param name="dpiY">The vertical resolution.</param>
        /// <param name="pixelFormat">The pixel format.</param>
        /// <returns>An <see cref="IPlatformRenderTargetBitmap"/>.</returns>
        IPlatformRenderTargetBitmap CreateRenderTargetBitmap(
            int pixelWidth,
            int pixelHeight,
            double dpiX,
            double dpiY,
            PixelFormat pixelFormat);

        /// <summary>
        /// Create a new platform-specific <see cref="FormattedText"/>.
        /// </summary>
        /// <param name="textToFormat">The text.</param>
        /// <param name="typeface">The typeface.</param>
        /// <param name="fontSize">The font size.</param>
        /// <returns>The formatted text object.</returns>
        IPlatformFormattedText CreateFormattedText(
            string textToFormat,
            Typeface typeface,
            double fontSize);

        /// <summary>
        /// Creates a new platform-specific <see cref="PresentationSource"/>.
        /// </summary>
        /// <returns>
        /// The newly created presentation source.
        /// </returns>
        PlatformPresentationSource CreatePresentationSource();

        /// <summary>
        /// Creates a new platform-specific <see cref="PresentationSource"/> for a popup.
        /// </summary>
        /// <returns>
        /// The newly created presentation source.
        /// </returns>
        PlatformPresentationSource CreatePopupPresentationSource();

        /// <summary>
        /// Creates a new platform-specific stream geometry;
        /// </summary>
        /// <returns>
        /// An <see cref="IPlatformStreamGeometry"/>.
        /// </returns>
        IPlatformStreamGeometry CreateStreamGeometry();

        /// <summary>
        /// Starts a new timer.
        /// </summary>
        /// <param name="interval">The timer interval.</param>
        /// <param name="callback">The timer callback.</param>
        /// <returns>A timer handle.</returns>
        object StartTimer(TimeSpan interval, Action callback);

        /// <summary>
        /// Kills a running timer.
        /// </summary>
        /// <param name="handle">The timer handle.</param>
        void KillTimer(object handle);
    }
}