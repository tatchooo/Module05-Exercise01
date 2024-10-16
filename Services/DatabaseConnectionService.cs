﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05_Exercise01.Services
{
    private readonly string _connectionString;
    public class DatabaseConnectionService
    {
        _connectionString = "Server=localhost; Database=companydb; User ID=testuser; password=testuser";
    }

    public string GetConnectionString()
    {
        return
            _connectionString;
    }
}
