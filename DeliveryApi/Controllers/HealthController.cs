﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace delivery_api.Controllers
{
    [ApiController]
    public class HealthController : ControllerBase
    {
        // GET: api/Product
        [Route("api/health")]
        [HttpGet]
        public void Get()
        {
            return;
        }
    }
}