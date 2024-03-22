using System;
using System.Text;
using System.Text.Unicode;
using System.IO;
using System.Globalization;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.Design;


namespace gestaoColab
{

    class Program {

        // Ana Sousa anasosousa@gmail.com
        // Bianca Silva 

        // Programa para Gestão de dados de Colaboradores
        class Colaborador
        {
            int codColab;
            string nomColab = "";
            double vencColab;
            double plafondAlimColab;
            bool segSaudeColab = true;

            // get saida de dados, ou seja, getVariavel = vai conter os valores das variavies inicializadas em cima
            public int getCodigo() { return codColab; }
            public string getNome() { return nomColab; }
            public double getVenc() { return vencColab; }
            public double getPlafond() { return plafondAlimColab; }
            public bool getSeguro() { return segSaudeColab; }

            // set entrada de dados, todos os dados guardado na variavel newVariavel vão ser "transferidos" de volta para a variavel inicializada em cima 
            public void setCodigo(int newCodigo) { codColab = newCodigo; }
            public void setNome(string newNome) { nomColab = newNome; }
            public void setVenc(double newVenc) { vencColab = newVenc; }
            public void setPlafond(double newPlafond) { plafondAlimColab = newPlafond; }
            public void setSeguro(bool newSeguro) { segSaudeColab = newSeguro; }


            // construtores

            // construtor padrão - para garantir que todos objetos sejam criados com valores padrão.
            public Colaborador() 
            { 

            }
            // quando uma pessoa é criada estes dados são preenchidos por garantia
            public Colaborador(string newNome, int newCodigo)
            {
                nomColab = newNome;
                codColab = newCodigo;
            }
            // cada vez que é criado uma pessoa o plafom é de 140 euros
            public Colaborador(double newPlafond)
            {
                plafondAlimColab = 140;
            }

            // metodo para seguro de saude
            public bool seguroSaude(int seguroSaude)
            {
                bool sucesso = false;

                if (seguroSaude > 0)
                {
                    sucesso = true;
                }
           
                return sucesso;
            }

        }




        // COISAS A FAZER
        // * quando abrir o programa ele vai buscar os dados - fazer com um metodo
        // * quando fechar o programa tem que emnviar os dados
        // * o plafom de alimentação todos os messes é carregado com 140 euros

        // menu para escolher a opção
        public static int menu() {

            int opcao = 0;

            Console.WriteLine("\nMenu com opções: \n");
            Console.WriteLine("1. Inserir colaborador");
            Console.WriteLine("2. Listagem de registos de colaboradores");
            Console.WriteLine("3. Consultar o registo de um colaborador");
            Console.WriteLine("4. Alterar dados de colaboradores");
            Console.WriteLine("5. Eliminar colaborador");
            Console.WriteLine("6. Consultar o saldo do subsídio de Alimentação de um colaborador");
            Console.WriteLine("7. Usar o cartão para as refeições");
            Console.WriteLine("8. Carregar o plafond do subsídio de alimentão de um colaborador");
            Console.WriteLine("9. Carregar o plafond do subsídio de alimentão de todos os colaboradores");
            Console.WriteLine("10. Calcular a média dos vencimentos dos colaboradores");
            Console.WriteLine("11. O nome d@ colaborador@ com o melhor vencimento");
            Console.WriteLine("12. O nome d@ colaborador@ com o menor vencimento");
            Console.WriteLine("13. Listagem dos inscritos no Seguro de Saúde\n");

            Console.WriteLine("0. Sair");

            Console.Write("Opção: ");
            // retorna o valor que o utizador selecionou e  transformar a opcao em um numero inteiro 
            return opcao = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            // classe colaborador - criar varios objetos chamdados "pessoa" = criar varios colaboradores
            Colaborador[] pessoa = new Colaborador[0];
            int op = 0;
            int i;

            // ciclo para repetir as opcoes 
            do{
                op = menu();
                switch (op)
                {
                    // 1. Inserir colaborador
                    case 1:
                        Array.Resize(ref pessoa, pessoa.Length + 1); // redimenciona o array - mostra a possição 1 
                        pessoa[pessoa.Length - 1] = new Colaborador(); // array começa na posição 0 

                        Console.WriteLine("\nInserir novo Colaborador: \n");

                        Console.Write("Insira o numero do Colaborador: ");
                        pessoa[pessoa.Length - 1].setCodigo(Convert.ToInt32(Console.ReadLine())); // O array criado com o parametro codigo

                        Console.Write("Insira o nome do Colaborador: ");
                        pessoa[pessoa.Length - 1].setNome(Console.ReadLine());

                        Console.Write("Insira o Vencimento do Colaborador: ");
                        pessoa[pessoa.Length -1].setVenc(Convert.ToDouble(Console.ReadLine()));

                        // o plafondAlimColab - ja esta predefinido com 140 quando é criado uma pessoa

                        Console.WriteLine("O Colaborador tem direito a Seguro de Saúde?");

                        Console.WriteLine("0. Não vai ter seguro");
                        Console.WriteLine("1. Sim, vai ter seguro");
                        

                        Console.Write("Opção: ");

                        int seguroSaude = Convert.ToInt32(Console.ReadLine());
                        if (seguroSaude > 0 && seguroSaude < 3)
                            if (pessoa[pessoa.Length - 1].seguroSaude(seguroSaude) == true)
                                Console.WriteLine("tem seguro");
                            else Console.WriteLine("nao tem seguro");
                        else Console.WriteLine("Escolha uma das opçoes a cima");
                        break;
                        
                    // 2. Listagem de registos de colaboradores
                    case 2:
                        Console.WriteLine("\nLista dos Colaboradores: \n");

                        for (i = 0; i < pessoa.Length; i++)
                        {
                            // corrigir o plafon e o true
                            Console.WriteLine($"Código:{pessoa[i].getCodigo()} " + $"Nome:{pessoa[i].getNome()} " + $"Vencimento: {pessoa[i].getVenc()} " + $"Plafond cartao de alimentação:{pessoa[i].getPlafond()} " + $"Seguro de Saude:{pessoa[i].getSeguro()} ");
                        }
                    break;

                    // 3. Consultar o registo de um colaborador
                    case 3:
                    break;

                    // 4. Alterar dados de colaboradores
                    case 4:
                    break;

                    // 5. Eliminar colaborador
                    case 5:
                    break;

                    // 6. Consultar o saldo do subsídio de Alimentação de um colaborador
                    case 6:
                    break;

                    // 7. Usar o cartão para as refeições
                    case 7:
                    break;

                    // 8. Carregar o plafond do subsídio de alimentão de um colaborador
                    case 8:
                    break;

                    // 9. Carregar o plafond do subsídio de alimentão de todos os colaboradores"
                    case 9:
                    break;

                    //10. Calcular a média dos vencimentos dos colaboradores
                    case 10:
                    break;

                    // 11. O nome d@ colaborador@ com o melhor vencimento
                    case 11:
                    break;

                    // 12. O nome d@ colaborador@ com o menor vencimento
                    case 12:
                    break;

                    // 13.Listagem dos inscritos no Seguro de Saúde
                    case 13:
                    break;
                }

            } while (op != 0);
        }
    }
}