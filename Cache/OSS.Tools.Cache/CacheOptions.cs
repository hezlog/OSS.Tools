﻿using System;

namespace OSS.Tools.Cache
{
     public class CacheTimeOptions
    {
        private TimeSpan? _absoluteExpirationRelativeNow;
        private TimeSpan? _slidingExpiration;

        /// <summary>
        ///   模块名称
        /// </summary>
        public string ModuleName { get; set; } = "default";

        /// <summary>
        /// 固定过期时长，设置后到时过期
        /// </summary>
        public TimeSpan? AbsoluteExpirationRelativeToNow
        {
            get => _absoluteExpirationRelativeNow;
            set
            {
                var a = value;

                if (a.HasValue&&a.Value<=TimeSpan.Zero)
                    throw new ArgumentOutOfRangeException(nameof(AbsoluteExpirationRelativeToNow), value, "The relative expiration value must be positive.");
             
                _absoluteExpirationRelativeNow = value;
            }
        }

        /// <summary>
        /// 滚动过期时长，访问后自动延长
        /// </summary>
        public TimeSpan? SlidingExpiration
        {
            get => _slidingExpiration;
            set
            {
                var a = value;

                if (a.HasValue && a.Value <= TimeSpan.Zero)
                    throw new ArgumentOutOfRangeException(nameof(SlidingExpiration), (object) value, "The relative expiration value must be positive.");

                _slidingExpiration = value;
            }
        }
    }
}
