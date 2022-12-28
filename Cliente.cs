using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_OS
{
    public class Cliente
    {
        private string nome;
        private string email;
        private string cpfCnpj;
        private string rgInscricaoEst;
        private string tel1;
        private string tel2;
        private string cep;
        private string uf;
        private string cidade;
        private string bairro;
        private string ruaLogradouro;
        private string complemento;
        private string numero;
        private string codigo;
        private string tipoPessoa;

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetCpfCnpj()
        {
            return this.cpfCnpj;
        }

        public void SetCpfCnpj(string cpfcnpj)
        {
            this.cpfCnpj = cpfcnpj;
        }

        public string GetRgInscricaoEst()
        {
            return this.rgInscricaoEst;
        }

        public void SetRgInscricaoEst(string rgInscricaoEst)
        {
            this.rgInscricaoEst = rgInscricaoEst;
        }

        public string GetTel1()
        {
            return this.tel1;
        }

        public void SetTel1(string tel1)
        {
            this.tel1 = tel1;
        }

        public string GetTel2()
        {
            return this.tel2;
        }

        public void SetTel2(string tel2)
        {
            this.tel2 = tel2;
        }

        public string GetCep()
        {
            return this.cep;
        }

        public void SetCep(string cep)
        {
            this.cep = cep;
        }

        public string GetUF()
        {
            return this.uf;
        }

        public void SetUF(string uf)
        {
            this.uf = uf;
        }

        public string GetCidade()
        {
            return this.cidade;
        }

        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string GetBairro()
        {
            return this.bairro;
        }

        public void SetBairro(string bairro)
        {
            this.bairro = bairro;   
        }

        public string GetRuaLogradouro()
        {
            return this.ruaLogradouro;
        }

        public void SetRuaLogradouro(string ruaLogradouro)
        {
            this.ruaLogradouro = ruaLogradouro;
        }

        public string GetComplemento()
        {
            return this.complemento;
        }

        public void SetComplemento(string complemento)
        {
            this.complemento = complemento;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public void SetNumero(string numero)
        {
            this.numero = numero;
        }

        public string GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string GetTipoPessoa()
        {
            return this.tipoPessoa;
        }

        public void SetTipoPessoa(string tipoPessoa)
        {
            this.tipoPessoa = tipoPessoa;
        }

    }
}
