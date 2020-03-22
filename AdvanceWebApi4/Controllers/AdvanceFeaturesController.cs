using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceWebApi4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvanceFeaturesController : ControllerBase
    {
        //code here to Perform Dependency injection and register the services using Add scoped and Add transient options.

        //Show how does Etag works while reading and update records and implement caching using Entity tags. 

        // code here to Implement versioning using URL.


    }
}