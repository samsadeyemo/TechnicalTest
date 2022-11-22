using TechnicalTest.HelperClass;
using TechnicalTest.Models.ViewModels.Request;
using TechnicalTest.Models.ViewModels.Response;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechnicalTest.Controllers
{
    [Route("[controller]")]
    public class PersonsController : Controller
    {

        private readonly ILogger _logger;

        private IWebHostEnvironment _env;
        private IConfiguration _configuration;


        public PersonsController()
        {
        
            _logger = Log.Logger;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> Index([FromQuery] int pageNumber = 1)
        {



            try
            {
                    return View();
            
            }
            catch (Exception ex)
            {
               
                ShowError("An error ocurred, please try again or contact an Admin.");
                return View();
                // return View(paginatedCategoryList);
            }

        }

        void ShowError(string ErrorMessage)
        {
            TempData["ErrorMessage"] = ErrorMessage;
            TempData["SuccessMessage"] = null;
            TempData["Message"] = null;
            // ExceptionLog.LogError(ErrorMessage, ServerDateTime);
        }
        void ShowSuccess(string SuccessMessage)
        {
            TempData["ErrorMessage"] = null;
            TempData["Message"] = null;
            TempData["SuccessMessage"] = SuccessMessage;
        }
    }
}