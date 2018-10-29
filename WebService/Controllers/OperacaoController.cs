using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using WebService.Model;

namespace WebService.Controllers
{
    //[Route("api/[controller]/[action]")]
    [EnableCors(origins: "*", headers: "*", methods: "get,post")]
    public class OperacaoController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Porcentagem([FromBody]Numeros nums)
        {
            Resposta resposta = new Resposta();
            if (nums.n2 == 0) 
            {
                resposta.erro = new Erro();
                return Request.CreateResponse(HttpStatusCode.InternalServerError, resposta);
            }

            resposta.resultado = (nums.n1 * nums.n2) / 100;
            return Request.CreateResponse(HttpStatusCode.OK, resposta);
        }
    }
}
