using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using Entity;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoController : ControllerBase
    {
        private readonly IContratoService contratoService;

        public ContratoController(IContratoService contratoService)
        {
            this.contratoService = contratoService;
        }

        [HttpGet]
        public async Task<IEnumerable<ContratoEntity>> Get()
        {
            try
            {
                return await contratoService.Get();
            }
            catch (Exception ex)
            {

                return new List<ContratoEntity>();
            }


        }

        [HttpGet("{id}")]
        public async Task<ContratoEntity> Get(int id)
        {
            try
            {
                return await contratoService.GetById(new ContratoEntity { IdContrato = id });
            }
            catch (Exception ex)
            {

                return new ContratoEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPost]
        public async Task<DBEntity> Create(ContratoEntity entity)
        {
            try
            {
                return await contratoService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPut]
        public async Task<DBEntity> Update(ContratoEntity entity)
        {
            try
            {
                return await contratoService.Update(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpDelete("{id}")]
        public async Task<DBEntity> Delete(int id)
        {
            try
            {
                return await contratoService.Delete(new ContratoEntity() { IdContrato = id });
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


    }
}
