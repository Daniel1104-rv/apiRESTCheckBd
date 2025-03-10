using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;

// ----------------------
using apiRESTCheckBd.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// ----------------------

namespace apiRESTCheckBd.Controllers
{
    public class CheckBdController : ApiController
    {
        // Creación y configuración del enpoint
        [HttpPost]
        [Route("tads/checkbd")]
        public clsApiStatus checkBd()
        {
            // -------------------------------
            // Definición de objetos
            clsApiStatus objRespuesta = new clsApiStatus();
            JObject JsonResp = new JObject();
            // ----------------------------
            // Creación dwl objeto clsCheckBd
            clsCheckBd objCheckBd = new clsCheckBd();
            // Ejecución del checkBd
            objCheckBd.checkBd();
            // Configuración del objeto de salida
            objRespuesta.ban = objCheckBd.ban;
            if(objRespuesta.ban == 1)
            {
                objRespuesta.statusExec = true;
            }
            else
            {
                objRespuesta.statusExec = false;
            }

            objRespuesta.msg = objCheckBd.statusMsg;
            JsonResp.Add("msgData", objCheckBd.statusMsg);
            objRespuesta.datos = JsonResp;
            // ------------------------------------------
            //Retorno del objeto de salida 
            return objRespuesta;

        }

    }
}
