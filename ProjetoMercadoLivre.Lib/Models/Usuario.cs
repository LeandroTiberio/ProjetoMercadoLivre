namespace ProjetoMercadoLivre.Lib.Models
{
    public class Usuario : ModelBase
    {
        public int? Usuarios  { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, string email, string cpf, DateTime dataNascimento, string senha)
        {
            SetNome(nome);
            SetEmail(email);
            SetCpf(cpf);
            SetDataNascimento(dataNascimento);
            SetSenha(senha);
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
        public void SetEmail(string emial)
        {
            Email = Email;
        }
        public string GetCpf()
        {
            return Cpf;
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }
        public void SetDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }
        public string GetSenha()
        {
            return Senha;
        }
        public void SetSenha(string senha)
        {
            Senha = senha;
        }
    }
}

