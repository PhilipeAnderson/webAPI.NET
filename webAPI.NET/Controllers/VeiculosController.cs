using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPI.NET.Models;

namespace webAPI.NET.Controllers
{
    public class VeiculosController : ApiController
    {
        public static List<Veiculos> listaVeiculos = new List<Veiculos>();

        [HttpGet]
        [Route("api/veiculos/popular")]
        public string Popular()
        {
            listaVeiculos.Add(new Veiculos(1, "FORD FIESTA", "1.0 MPI PERSONNALITÉ SEDAN 4P", 2005, 2005, "PRETO", 2, false, 25000, true));
            listaVeiculos.Add(new Veiculos(2, "KIA CERATO", "1.6 EX3 SEDAN 16V 4P A", 2014, 2015, "PRATA", 3, true, 35000, true));
            listaVeiculos.Add(new Veiculos(6, "HYUNDAI HB20", "1.0 CONFORT 12V FLEX 4P", 2017, 2017, "AZUL", 3, true, 43000, true));
            listaVeiculos.Add(new Veiculos(12, "CHEVROLET PRISMA", "1.4 MMPI LT 8V FLEX 4P", 2013, 2012, "PRATA", 3, true, 31000, true));
            listaVeiculos.Add(new Veiculos(27, "VOLKSWAGEN POLO", "1.0 200 TSI HIGHLINE", 2018, 2018, "AZUL", 3, true, 66045, true));

            //var resultado = JObject.Parse("{resultado: \"populado\" }");
            //return (JObject)"resultado";
            return "populado";
        }


        // GET api/veiculos
        public List<Veiculos> Get()
        {
            return listaVeiculos;
        }

        // GET api/veiculos/5
        public Veiculos Get(int id)
        {
            return listaVeiculos.Find(x => x.Id.Equals(id));
        }

        // POST api/veiculos
        public void Post([FromBody] Veiculos veiculo)
        {
            listaVeiculos.Add(new Veiculos(veiculo.Id, veiculo.Marca, veiculo.Modelo, veiculo.Ano, veiculo.Fabricacao, veiculo.Cor, veiculo.Combustivel, veiculo.Automatico, veiculo.Valor, veiculo.Ativo));
        }

        // PUT api/veiculos/5
        public void Put(int id, [FromBody] Veiculos veiculo)
        {
            var identificador = listaVeiculos.Single(x => x.Id.Equals(id));

            identificador.Marca = veiculo.Marca;
            identificador.Modelo = veiculo.Modelo;
            identificador.Ano = veiculo.Ano;
            identificador.Fabricacao = veiculo.Fabricacao;
            identificador.Cor = veiculo.Cor;
            identificador.Combustivel = veiculo.Combustivel;
            identificador.Valor = veiculo.Valor;
            identificador.Ativo = veiculo.Ativo;
        }

        
        // DELETE api/veiculos/5
        public void Delete(int id)
        {
            var identificador = listaVeiculos.FindIndex(x => x.Id.Equals(id));
            listaVeiculos.RemoveAt(identificador);
        }
    }
}
