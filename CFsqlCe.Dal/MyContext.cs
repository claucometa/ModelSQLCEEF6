﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CFSqlCe.Dal
{
    public static class MyContext
    {
        public static DvdContext db = new DvdContext();
    }
}
