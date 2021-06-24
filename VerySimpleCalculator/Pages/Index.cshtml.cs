using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerySimpleCalculatorLibrary;

namespace VerySimpleCalculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public double Result { get; set; }
        public Boolean ResultIsSet { get; protected set; } = false;

        public void OnGet()
        {

        }

        public void OnPost(double value1, double value2, string operation)
        {
            switch (operation)
            {
                case "add":
                    Result = SimpleCalculator.add(value1, value2);
                    ResultIsSet = true;
                    break;
                case "sub":
                    Result = SimpleCalculator.sub(value1, value2);
                    ResultIsSet = true;
                    break;
                case "mul":
                    Result = SimpleCalculator.mul(value1, value2);
                    ResultIsSet = true;
                    break;
                case "div":
                    Result = SimpleCalculator.div(value1, value2);
                    ResultIsSet = true;
                    break;
                default:
                    break;
            }
        }

    }
}
