﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bang.Module.Users.Storage.Objects;

namespace Bang.Module.Users.Service
{
    public interface IUserService
    {
        void Create(User user);
    }
}
