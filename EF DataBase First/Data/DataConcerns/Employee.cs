﻿using System;
using System.Collections.Generic;

namespace Data.DataConcerns;

public partial class Employee
{
    public string Id { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateTime JoinDate { get; set; }

    public string? Location { get; set; }

    public string? JobTitle { get; set; }

    public string? Department { get; set; }

    public string? Manager { get; set; }

    public string? Project { get; set; }
}