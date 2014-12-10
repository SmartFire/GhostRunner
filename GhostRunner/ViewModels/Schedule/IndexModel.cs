﻿using GhostRunner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GhostRunner.ViewModels.Schedule
{
    public class IndexModel : ViewModel
    {
        public IndexModel()
        {
            ScheduleItems = new List<IScheduleItem>();
        }

        public Project Project { get; set; }

        public IList<IScheduleItem> ScheduleItems { get; set; }

        public Boolean HasMonthlyItems()
        {
            return ScheduleItems.Where(si => si.ScheduleType == ScheduleType.Monthly).Count() > 0;
        }

        public Boolean HasWeeklyItems()
        {
            return ScheduleItems.Where(si => si.ScheduleType == ScheduleType.Weekly).Count() > 0;
        }

        public Boolean HasDailyItems()
        {
            return ScheduleItems.Where(si => si.ScheduleType == ScheduleType.Monthly).Count() > 0;
        }
    }
}