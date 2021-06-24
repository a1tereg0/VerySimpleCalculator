using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerySimpleCalculatorLibrary;

namespace VerySimpleCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public double add(double value1, double value2)
        {
            return SimpleCalculator.add(value1, value2);
        }

        [HttpGet]
        public double sub(double value1, double value2)
        {
            return SimpleCalculator.add(value1, value2);
        }

        [HttpGet]
        public double mul(double value1, double value2)
        {
            return SimpleCalculator.add(value1, value2);
        }

        [HttpGet]
        public double div(double value1, double value2)
        {
            return SimpleCalculator.add(value1, value2);
        }
    }
}
