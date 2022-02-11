﻿using MediatR;
using Piano.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.BusinessLogic.Queries.Users.GetUsers
{
    public class GetUsersQuery: IRequest<List<User>>
    {
    }
}
