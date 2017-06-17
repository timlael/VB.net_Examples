Module dateNtime
    Sub Main()
        Console.WriteLine("India Wins Freedom: ")
        Dim independenceDay As New Date(1947, 8, 15, 0, 0, 0)
        ' Use format specifiers to control the date display.
        Console.WriteLine(" Format 'd:' " & independenceDay.ToString("d"))
        Console.WriteLine(" Format 'D:' " & independenceDay.ToString("D"))
        Console.WriteLine(" Format 't:' " & independenceDay.ToString("t"))
        Console.WriteLine(" Format 'T:' " & independenceDay.ToString("T"))
        Console.WriteLine(" Format 'f:' " & independenceDay.ToString("f"))
        Console.WriteLine(" Format 'F:' " & independenceDay.ToString("F"))
        Console.WriteLine(" Format 'g:' " & independenceDay.ToString("g"))
        Console.WriteLine(" Format 'G:' " & independenceDay.ToString("G"))
        Console.WriteLine(" Format 'M:' " & independenceDay.ToString("M"))
        Console.WriteLine(" Format 'R:' " & independenceDay.ToString("R"))
        Console.WriteLine(" Format 'y:' " & independenceDay.ToString("y"))
        Console.ReadKey()
    End Sub
End Module




'Property                               Description
'Date                                   Returns or sets a String value representing the current date according to your system.
'Day                                    Gets the day of the month represented by this instance. 
'DayOfWeek                              Gets the day of the week represented by this instance. 
'DayOfYear                              Gets the day of the year represented by this instance. 
'Hour                                   Gets the hour component of the date represented by this instance. 
'Kind                                   Gets a value that indicates whether the time represented by this instance is based on local time, Coordinated Universal Time (UTC), or neither. 
'Millisecond                            Gets the milliseconds component of the date represented by this instance. 
'Minute                                 Gets the minute component of the date represented by this instance. 
'Month                                  Gets the month component of the date represented by this instance. 
'Now                                    Gets a DateTime object that is set to the current date and time on this computer, expressed as the local time. 
'Second                                 Gets the seconds component of the date represented by this instance. 
'Ticks                                  Gets the number of ticks that represent the date and time of this instance. 
'TimeOfDay                              Gets the time of day for this instance. 
'Timer                                  Returns a Double value representing the number of seconds elapsed since midnight. 
'TimeString                             Returns or sets a String value representing the current time of day according to your system. 
'Today                                  Gets the current date. 
'UtcNow                                 Gets a DateTime object that is set to the current date and time on this computer, expressed as the Coordinated Universal Time (UTC). 
'Year                                   Gets the year component of the date represented by this instance.



'Method Name                                                                                Description
'Public Function Add(value As TimeSpan) As DateTime                                         Returns a new DateTime that adds the value of the specified TimeSpan to the value of this instance.
'Public Function AddDays(value As Double) As DateTime                                       Returns a new DateTime that adds the specified number of days to the value of this instance.
'Public Function AddHours(value As Double) As DateTime                                      Returns a new DateTime that adds the specified number of hours to the value of this instance.
'Public Function AddMinutes(value As Double) As DateTime                                    Returns a new DateTime that adds the specified number of minutes to the value of this instance.
'Public Function AddMonths(months As Integer) As DateTime                                   Returns a new DateTime that adds the specified number of months to the value of this instance.
'Public Function AddSeconds(value As Double) As DateTime                                    Returns a new DateTime that adds the specified number of seconds to the value of this instance.
'Public Function AddYears(value As Integer) As DateTime                                     Returns a new DateTime that adds the specified number of years to the value of this instance.
'Public Shared Function Compare(t1 As DateTime, t2 As DateTime) As Integer                  Compares two instances of DateTime and returns an integer that indicates whether the first instance is earlier than, the same as, or later than the second instance.
'Public Function CompareTo(value As DateTime) As Integer                                    Compares the value of this instance to a specified DateTime value and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified DateTime value.
'Public Function Equals(value As DateTime) As Boolean                                       Returns a value indicating whether the value of this instance is equal to the value of the specified DateTime instance.
'Public Shared Function Equals(t1 As DateTime, t2 As DateTime) As Boolean                   Returns a value indicating whether two DateTime instances have the same date and time value.
'Public Overrides Function ToString() As String                                             Converts the value of the current DateTime object to its equivalent string representation.

'Format                                 Description
'General Date, or G                     Displays a date and/or time. For example, 1/12/2012 07:07:30 AM. 
'Long Date,Medium Date, or D            Displays a date according to your current culture's long date format. For example, Sunday, December 16, 2012. 
'Short Date, or d                       Displays a date using your current culture's short date format. For example, 12/12/2012. 
'Long Time,Medium Time, or              Displays a time using your current culture's long time format; typically includes hours, minutes, seconds. For example, 01:07:30 AM. 
'Short Time or t                        Displays a time using your current culture's short time format. For example, 11:07 AM. 
'f                                      Displays the long date and short time according to your current culture's format. For example, Sunday, December 16, 2012 12:15 AM. 
'F                                      Displays the long date and long time according to your current culture's format. For example, Sunday, December 16, 2012 12:15:31 AM. 
'g                                      Displays the short date and short time according to your current culture's format. For example, 12/16/2012 12:15 AM. 
'M, m                                   Displays the month and the day of a date. For example, December 16. 
'R, r                                   Formats the date according to the RFC1123Pattern property.  
's                                      Formats the date and time as a sortable index. For example, 2012-12-16T12:07:31. 
'u                                      Formats the date and time as a GMT sortable index. For example, 2012-12-16 12:15:31Z. 
'U                                      Formats the date and time with the long date and long time as GMT. For example, Sunday, December 16, 2012 6:07:31 PM. 
'Y, y                                   Formats the date as the year and month. For example, December, 2012. 


'Method Name                                                                                                                                                                        Description
'Public Shared Function DateAdd(Interval As DateInterval, Number As Double, DateValue As DateTime) As DateTime                                                                      Returns a Date value containing a date and time value to which a specified time interval has been added.
'Public Shared Function DateAdd(Interval As String, Number As Double, DateValue As Object) As DateTime                                                                              Returns a Date value containing a date and time value to which a specified time interval has been added.
'Public Shared Function DateDiff(Interval As DateInterval, Date1 As DateTime, Date2 As DateTime, DayOfWeek As FirstDayOfWeek, WeekOfYear As FirstWeekOfYear) As Long                Returns a Long value specifying the number of time intervals between two Date values.
'Public Shared Function DatePart(Interval As DateInterval, DateValue As DateTime, FirstDayOfWeekValue As FirstDayOfWeek, FirstWeekOfYearValue As FirstWeekOfYear) As Integer        Returns an Integer value containing the specified component of a given Date value.
'Public Shared Function Day(DateValue As DateTime) As Integer                                                                                                                       Returns an Integer value from 1 through 31 representing the day of the month.
'Public Shared Function Hour (TimeValue As DateTime) As Integer                                                                                                                     Returns an Integer value from 0 through 23 representing the hour of the day.
'Public Shared Function Minute(TimeValue As DateTime) As Integer                                                                                                                    Returns an Integer value from 0 through 59 representing the minute of the hour.
'Public Shared Function Month(DateValue As DateTime) As Integer                                                                                                                     Returns an Integer value from 1 through 12 representing the month of the year.
'Public Shared Function MonthName(Month As Integer, Abbreviate As Boolean) As String                                                                                                Returns a String value containing the name of the specified month.
'Public Shared Function Second(TimeValue As DateTime) As Integer                                                                                                                    Returns an Integer value from 0 through 59 representing the second of the minute.
'Public Overridable Function ToString() As String                                                                                                                                   Returns a string that represents the current object.
'Public Shared Function Weekday(DateValue As DateTime, DayOfWeek As FirstDayOfWeek) As Integer                                                                                      Returns an Integer value containing a number representing the day of the week.
'Public Shared Function WeekdayName(Weekday As Integer, Abbreviate As Boolean, FirstDayOfWeekValue As FirstDayOfWeek) As String                                                     Returns a String value containing the name of the specified weekday.
'Public Shared Function Year(DateValue As DateTime) As Integer                                                                                                                      Returns an Integer value from 1 through 9999 representing the year.