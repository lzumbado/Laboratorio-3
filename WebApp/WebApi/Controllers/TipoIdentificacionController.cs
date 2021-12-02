using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using WBL;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoIdentificacionController : ControllerBase
    {
        private readonly ITipoIdentificacionService identificacionService;

        public TipoIdentificacionController(ITipoIdentificacionService identificacionService)
        {
            this.identificacionService = identificacionService;
        }



        [HttpGet("Lista")]
        public async Task<IEnumerable<TipoIdentificacionEntity>> GetLista()
        {
            try
            {
                return await identificacionService.GetLista();
            }
            catch (Exception ex)
            {

                return new List<TipoIdentificacionEntity>();
            }


        }
    }
}
