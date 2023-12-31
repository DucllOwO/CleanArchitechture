﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Server.Authentication
{
    public record AuthenticationResult(
      Guid Id,
      string FirstName,
      string LastName,
      string Email,
      string Token);
}