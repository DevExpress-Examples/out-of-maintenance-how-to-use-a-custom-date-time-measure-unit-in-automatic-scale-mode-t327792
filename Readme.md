<!-- default file list -->
*Files to look at*:

* [DateTimeMeasureUnitsCalculator.cs](./CS/CustomDateTimeMeasureUnitsCalcuslatorSample/DateTimeMeasureUnitsCalculator.cs) (VB: [DateTimeMeasureUnitsCalculator.vb](./VB/CustomDateTimeMeasureUnitsCalcuslatorSample/DateTimeMeasureUnitsCalculator.vb))
* **[MainWindow.xaml](./CS/CustomDateTimeMeasureUnitsCalcuslatorSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomDateTimeMeasureUnitsCalcuslatorSample/MainWindow.xaml))**
<!-- default file list end -->
# How to: use a custom date-time measure unit in automatic scale mode


This example demonstrates how to specify a custom date-time measure unit in <strong>Automatic</strong> scale mode.


<h3>Description</h3>

To do this, assign an object of a class implementing the&nbsp;<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsIDateTimeMeasureUnitsCalculatortopic">IDateTimeMeasureUnitsCalculator</a>&nbsp;interface to the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAutomaticDateTimeScaleOptions_AutomaticMeasureUnitsCalculatortopic">AutomaticMeasureUnitsCalculator</a>&nbsp;property of an <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsAutomaticDateTimeScaleOptionstopic">AutomaticDateTimeScaleOptions</a>&nbsp;object assigned to the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAxisX2D_DateTimeScaleOptionstopic">AxisX2D.DateTimeScaleOptions</a>.

<br/>


