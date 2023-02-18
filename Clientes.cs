// Nome projeto
namespace ControleClientes
{
    // Nome Class
    class Clientes {
        
        // Atributos
        public string nome {get; set;}
        public string endereco {get; set;}
        public float valor {get; protected set;}
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}

        // Método
        public virtual void Pagar_Imposto(float v) {
            this.valor = v;
            this.valor_imposto = this.valor * 10 /100;
            this.total = this.valor + this.valor_imposto;
        }

    }
}

