﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeekBurger.Orders.API.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {

        // PUT api/values/5
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
