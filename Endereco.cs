using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_OS
{
    public class Endereco
    {
        private string cep;
        private string logradouro;
        private string complemento;
        private string bairro;
        private string localidade;
        private string uf;
        private string ibge;
        private string gia;
        private string ddd;
        private string siafi;

        public string GetCep()
        {
            return this.cep;
        }

        public void SetCep(string cep)
        {
            this.cep = cep;
        }

        public string GetLogradouro()
        {
            return this.logradouro;
        }

        public void SetLogradouro(string logradouro)
        {
            this.logradouro = logradouro;
        }

        public string GetComplemento()
        {
            return this.complemento;
        }

        public void SetComplemento(string complemento)
        {
            this.complemento = complemento;
        }

        public string GetBairro()
        {
            return this.bairro;
        }

        public void SetBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string GetLocalidade()
        {
            return this.localidade;
        }

        public void SetLocalidade(string localidade)
        {
            this.localidade = localidade;
        }

        public string GetUF()
        {
            return this.uf;
        }

        public void SetUF(string uf)
        {
            this.uf = uf;
        }

        public string GetIbge()
        {
            return this.ibge;
        }

        public void SetIbge(string ibge)
        {
            this.ibge = ibge;
        }

        public string GetGia()
        {
            return this.gia;
        }

        public void SetGia(string gia)
        {
            this.gia = gia;
        }

        public string GetDDD()
        {
            return this.ddd;
        }

        public void SetDDD(string ddd)
        {
            this.ddd = ddd;
        }

        public string GetSiafi()
        {
            return this.siafi;
        }

        public void SetSiafi(string siafi)
        {
            this.siafi = siafi;
        }
    }
}
