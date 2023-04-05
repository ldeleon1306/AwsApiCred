using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwsApiCred
{
    public class Contrato
    {
        public string contrato_tms { get; set; }
        public string cliente { get; set; }       
        public string cliente_para_validaciones { get; set; }
        private string _destinatario_nombre_corto;

        public string destinatario_nombre_corto
        {
            get { return _destinatario_nombre_corto; }
            set { _destinatario_nombre_corto = value.ToLower(); }
        }
        public string JsonResult { get; set; }
    }
}
