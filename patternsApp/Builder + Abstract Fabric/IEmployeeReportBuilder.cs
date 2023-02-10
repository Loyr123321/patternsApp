﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsApp
{
    public interface IEmployeeReportBuilder
    {
        void BuildHeader();

        void BuildBody();

        void BuildFooter();
        EmployeeReport GetReport();

    }
}
