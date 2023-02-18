// Biblioteca System => Permite entrada de dados
using System;
namespace ControleClientes
{

    class Program
    {
        // Estrutura do prgrama - método principal (Main)
        static void Main(string[] args)
        {

            // Declaração de variáveis
            float val_pag;

            Console.WriteLine("Informar nome:");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informar o endereço:");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Jurídica (j)");
            string var_tipo = Console.ReadLine();


            if (var_tipo == "f")
            {
                // Pessoa física

                // INSTANCIAMENTO
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;

                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();

                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine();

                Console.WriteLine("Informar valor de compra:");
                val_pag = float.Parse(Console.ReadLine()); // Pega o valor digitado e converte para float

                pf.Pagar_Imposto(val_pag); // Calcula valor de imposto conforme val_pag

                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("NOME ..........: " + pf.nome);
                Console.WriteLine("ENDEREÇO ......: " + pf.endereco);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG ............: " + pf.rg);

                // .ToString("C") => Transforma em string e convertendo em moeda (formato de moeda)
                Console.WriteLine("VALOR DA COMPRA: " + pf.valor.ToString("C"));
                Console.WriteLine("IMPOSTO .......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("TOTAL A PAGAR .: " + pf.total.ToString("C"));
            }


            if (var_tipo == "j")
            {
                // Pessoa Jurídica

                // INSTANCIAMENTO
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;

                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();

                Console.WriteLine("Informar IE:");
                pj.ie = Console.ReadLine();

                Console.WriteLine("Informar valor de compra:");
                val_pag = float.Parse(Console.ReadLine()); 

                pj.Pagar_Imposto(val_pag); 

                Console.WriteLine("-------- Pessoa Jurídica --------");
                Console.WriteLine("NOME ..........:" + pj.nome);
                Console.WriteLine("ENDEREÇO ......: " + pj.endereco);
                Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                Console.WriteLine("IE ............: " + pj.ie);

                Console.WriteLine("VALOR DA COMPRA: " + pj.valor.ToString("C"));
                Console.WriteLine("IMPOSTO .......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("TOTAL A PAGAR .: " + pj.total.ToString("C"));

            }
            
        }
    }

}