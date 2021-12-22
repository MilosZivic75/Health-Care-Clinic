﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.Tendering.Model
{
    public class DateRange
    {
        public DateTime Start { get; }
        public DateTime End { get; }
        public DateRange(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }
    }
}
