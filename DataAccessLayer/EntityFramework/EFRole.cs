﻿using DataAccessLayer.Abstraction;
using DataAccessLayer.Managers;
using EntityLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFRole : RoleManager, IRoleManager<Role>
    {
    }
}
