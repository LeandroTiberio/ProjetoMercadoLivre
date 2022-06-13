using System;
namespace ProjetoMercadoLivre.Lib.Models
{
    public class Produto : ModelBase
    {

        
        
        public int Id { get; set; }
        public virtual Vendedores Vendedor { get; set; }
        public int IdVendedor { get; set; }
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual List<ProdutoXPedido> ProdutosXPedidos { get; set; }
    
        
        
        public Produto(string nome, string descricao, double valor, DateTime dataCadastro, string email,
                        string senha)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetDataCadastro(dataCadastro);
        } 
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public DateTime GetDataCadastro()
        {
            return DataCadastro;
        }
        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }
        public void ValorProduto(double valor)
        {
            if (valor > 0.0)
                throw ("Valor tem que ser maior que zero")
            Valor = valor;
        }
        public void ValidarDataCadastroPedido (DateTime data)
        {
            
            Data != Data.Now;
            return data;
        }
        public void ValidarDataCadastroProduto (DateTime data)
        {
            Data != Data.Now;
            return data;
        }
        public void ValidarEmail (string email)
        {
            if (email.Contains("@"))
            {
                throw ("Email invalido falta caracter @")
            }
            Email = email;
        }
        public void ValidarSenha (string senha)
        {
            if (senha.Length > 8)
            {
                throw ("Senha tem que ter minimo de 8 caracter")
            }
            Senha = senha;
        }
        public bool ValidarCpf (double cpf)
        {
            if (double.TryParse())
            {
                return true;
            }
            
        }

    }
}

