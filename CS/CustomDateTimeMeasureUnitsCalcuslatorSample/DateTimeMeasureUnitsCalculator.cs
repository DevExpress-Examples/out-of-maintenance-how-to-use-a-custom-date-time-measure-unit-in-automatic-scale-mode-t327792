#region #MeasureUnitsCalculatorImpl
using DevExpress.Xpf.Charts;
using System;
using System.Collections.Generic;

namespace CustomDateTimeMeasureUnitsCalcuslatorSample {
    class CustomDateTimeMeasureUnitsCalculator : IDateTimeMeasureUnitsCalculator {
        const int daysInWeek = 7;
        const int daysInMonth = 30;
        const int daysInQuarter = 4 * daysInMonth;
        const int daysInYear = 365;

        const int minCount = 5;

        public DateTimeMeasureUnit CalculateMeasureUnit(
                IEnumerable<Series> series,
                double axisLength,
                int pixelsPerUnit,
                double visualMin,
                double visualMax,
                double wholeMin,
                double wholeMax) {
            // Calculate visual range in msecs.
            double visualRange = visualMax - visualMin;
            TimeSpan ts = TimeSpan.FromMilliseconds(visualRange);
            if (ts.TotalDays >= 1.0d) {
                if (ts.TotalDays <= minCount * daysInWeek)
                    return DateTimeMeasureUnit.Day;
                if (ts.TotalDays <= minCount * daysInMonth)
                    return DateTimeMeasureUnit.Week;
                if (ts.TotalDays <= minCount * daysInQuarter)
                    return DateTimeMeasureUnit.Month;
                if (ts.TotalDays <= minCount * daysInYear)
                    return DateTimeMeasureUnit.Quarter;
                else
                    return DateTimeMeasureUnit.Year;
            }
            else if (ts.TotalHours >= 20.0d)
                return DateTimeMeasureUnit.Hour;
            else if (ts.TotalMinutes >= 20.0d)
                return DateTimeMeasureUnit.Minute;
            else if (ts.TotalSeconds >= 20.0d)
                return DateTimeMeasureUnit.Second;
            else
                return DateTimeMeasureUnit.Millisecond;
        }
    }
}
#endregion #MeasureUnitsCalculatorImpl