using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuggestiveService.Interfaces;
using SuggestiveService.Models;
using SuggestiveService.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuggestiveService.Controllers
{
    /// <summary>
    /// Controller for getting the prompts for fields related to life
    /// </summary>
    ///
    //[Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PolicyNumberController : ControllerBase
    {
        private readonly IPolicyNumberRepository _policyRepository;
        //public CourseController()
        //{

        //}
        public PolicyNumberController(IPolicyNumberRepository policyNumberRepository)
        {
            _policyRepository = policyNumberRepository;
        }

        [Route("getpolicy")]
        [HttpPost]
        public  string getpolicy(string productName,string schema)
        {
            var updated = _policyRepository.GetUpdatePolicyNumber(productName, schema);
            return updated;
        }
      
    }
}
