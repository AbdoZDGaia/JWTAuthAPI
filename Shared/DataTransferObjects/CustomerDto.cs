﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record CustomerDto
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public string? Email { get; init; }
        public string? Phone { get; init; }
    }
}
