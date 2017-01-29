﻿using System;
using RGB.NET.Devices.Corsair.Native;

namespace RGB.NET.Devices.Corsair
{
    /// <summary>
    /// Represents a generic information for a <see cref="CorsairHeadsetRGBDevice"/>.
    /// </summary>
    public class CorsairHeadsetRGBDeviceInfo : CorsairRGBDeviceInfo
    {
        #region Constructors

        /// <summary>
        /// Internal constructor of managed <see cref="CorsairHeadsetRGBDeviceInfo"/>.
        /// </summary>
        /// <param name="deviceIndex">The index of the <see cref="CorsairHeadsetRGBDevice"/>.</param>
        /// <param name="nativeInfo">The native <see cref="_CorsairDeviceInfo" />-struct</param>
        internal CorsairHeadsetRGBDeviceInfo(int deviceIndex, _CorsairDeviceInfo nativeInfo)
            : base(deviceIndex, Core.RGBDeviceType.Headset, nativeInfo)
        {
            Image = new Uri($"pack://application:,,,/RGB.NET.Devices.Corsair;component/Images/Headsets/{Model.Replace(" ", string.Empty).ToUpper()}.png", UriKind.Absolute);
        }

        #endregion
    }
}