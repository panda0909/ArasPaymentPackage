using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class BusinessCalendar
{
    public DateTime DayDate { get; set; }

    public int DayNumber { get; set; }

    public string Id { get; set; } = null!;
}
