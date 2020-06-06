using System;
using System.Collections.Generic;

namespace SmartExtensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Calculates the sum of the given timeSpans.
        /// </summary>
        public static TimeSpan Sum(this IEnumerable<TimeSpan> timeSpans)
        {
            TimeSpan sumTillNowTimeSpan = TimeSpan.Zero;

            foreach (TimeSpan timeSpan in timeSpans)
            {
                sumTillNowTimeSpan += timeSpan;
            }

            return sumTillNowTimeSpan;
        }
    }
}