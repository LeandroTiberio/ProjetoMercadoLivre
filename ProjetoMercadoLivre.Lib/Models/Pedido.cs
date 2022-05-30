
namespace ProjetoMercadoLivre.Lib.Models
{
    public class Pedido
    {
        public int IdTransportadora { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataPedido { get; set; }
        public string Status { get; set; }
    
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