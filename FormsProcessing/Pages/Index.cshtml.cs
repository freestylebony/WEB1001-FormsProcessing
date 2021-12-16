using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsProcessing.Pages
{
    public class IndexModel : PageModel
    {  
        
        //declare variables for the form data
        public string Number;
        public string Date;
        public int Convert;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }


        public void OnPost()
        {
            //get the form data 
             Number = Request.Form["Number"];
             Date = Request.Form["Date"];
            int number = Int32.Parse(Number);
            DateTime date = DateTime.Now;
            date = DateTime.Today.AddDays(number);


        }
    }
}
