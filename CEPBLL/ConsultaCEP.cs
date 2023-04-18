using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace CEPBLL
{
    public class ConsultaCEP
    {
        private readonly HttpClient _httpClient;
        public ConsultaCEP()
        {
            _httpClient = new HttpClient();
        }
        public CEP Consultar(string CepConsulta)
        {
            //CEP cepRetorno = new CEP();
            //cepRetorno.bairro = "Boqueirão";
            //cepRetorno.logradouro = "Rua Oswaldo Cruz";
            //cepRetorno.complemento = "lado par";
            //cepRetorno.ddd = "13";
            //cepRetorno.localidade = "Santos";
            //cepRetorno.cep = "11045-907";
            //cepRetorno.uf = "SP";

            return _httpClient.GetFromJsonAsync<CEP>($"https://viacep.com.br/ws/{CepConsulta}/json/").Result;
         
        }
    }
}
