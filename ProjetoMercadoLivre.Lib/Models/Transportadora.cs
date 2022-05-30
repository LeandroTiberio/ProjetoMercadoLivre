namespace ProjetoMercadoLivre.Lib.Models
{
    public class Transportadora
    {
        public string Nome { get; set; }
        public double Telefone { get; set; }
        public string Email { get; set; }

        public Transportadora(string nome, double telefone, string email)
        {
            SetNome(nome);
            SetTelefone(telefone);
            SetEmail(email);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public double GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone(double telefone)
        {
            Telefone = telefone;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}