using System.Text.Json.Serialization;

namespace Uninove.Web.Models
{
    public class Endereco
    {
        // O C# espera o nome exato da propriedade para fazer o Model Binding.
        // Se no JavaScript você usou letras maiúsculas ou minúsculas,
        // use o [JsonPropertyName] para garantir que o .NET faça o mapeamento correto.

        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string Localidade { get; set; } // Cidade

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; } // Campo preenchido manualmente pelo usuário
    }
}