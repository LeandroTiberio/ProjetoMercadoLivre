namespace ProjetoMercadoLivre.Lib.Models
{
    public class Vendedores 
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }
       
        public Vendedores(string nome, string email, double cnpj, DateTime dataCadastro)
        {
            SetNome(nome);
            SetEmail(email);
            SetCnpj(cnpj);
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
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public double GetCnpj()
        {
            return Cnpj;
        }
        public void SetCnpj(double cnpj)
        {
            Cnpj = cnpj;
        } 
        public DateTime GetDataCadastro()
        {
            return DataCadastro;
        }
        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }
    }

}