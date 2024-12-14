using System.ComponentModel.DataAnnotations;

namespace Teste_Estágio.Models
{
    public class SuppliersModel
    {
        [Key]
        public required int Id { get; set; } // Propriedade com chave primária
        public required string Name { get; set; } // Propriedades mapeáveis
        public required string Description { get; set; }
        public required string CNPJ { get; set; }
        public required int CEP { get; set; }
        public required string Address { get; set; }
        public required string RegistrationDay { get; set; }        
        public required string QrCode { get; set; }

        public String toString()
        {
            String [] dados = QrCode.Split('%');
            String QrCodeFormatado;

            QrCodeFormatado = dados[0];
            for(int i = 1; i < dados.Length; i++)
            {
                QrCodeFormatado = QrCodeFormatado + dados[i];
            }
            return QrCodeFormatado;
        }

        
    }
        
    
}
