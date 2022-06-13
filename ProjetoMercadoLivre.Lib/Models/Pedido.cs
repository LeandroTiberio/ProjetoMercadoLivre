
namespace ProjetoMercadoLivre.Lib.Models
{
    public class Pedido : ModelBase
    {
        public int IdUsuario { get; set; }
        public int Id { get; set; }
        public int IdTransportadora { get; set; }
        public virtual Transportadora Transportadoras { get; set; }
        public virtual Usuario Usuario { get; set; }
        
        public DateTime DataPedido { get; set; }
        public string Status { get; set; }
        
        public virtual List<ProdutoXPedido> ProdutosXPedidos { get; set; }
    
        public Pedido(DateTime dataPedido, string status)
        {
            SetDataPedido(dataPedido);
            SetStatus(status);
        }
        public DateTime GetDataPedido()
        {
            return DataPedido;
        }
        public void SetDataPedido(DateTime dataPedido)
        {
            DataPedido = dataPedido;
        }
        public string GetStatus()
        {
            return Status;
        }
        public void SetStatus(string status)
        {
            Status = status;
        }
    }
}