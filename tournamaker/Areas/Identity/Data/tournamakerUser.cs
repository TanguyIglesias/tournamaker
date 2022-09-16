﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace tournamaker.Areas.Identity.Data;

// Add profile data for application users by adding properties to the tournamakerUser class
public class tournamakerUser : IdentityUser
{
    [PersonalData]
    public string? Name { get; set; }
    [PersonalData]
    public DateTime DOB { get; set; }
}

