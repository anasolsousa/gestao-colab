using System;
using System.Text;
using System.Text.Unicode;
using System.IO;
using System.Globalization;


namespace gestaoColab
{

    class Program
    {

        // Ana Sousa anasosousa@gmail.com
        // Bianca Silva 

        // Programa para Gestão de dados de Colaboradores
        class Colaborador
        {
            int codColab;
            string nomColab = "";
            double vencColab;
            double plafondAlimColab;
            string segSaudeColab = "";

          
            // get saida de dados, ou seja, getVariavel = vai conter os valores das variavies inicializadas em cima
            public int getCodigo() { return codColab; }
            public string getNome() { return nomColab; }
            public double getVenc() { return vencColab; }
            public double getPlafond() { return plafondmensal(); }
            public string getSeguro() { return segSaudeColab; }

            // set entrada de dados, todos os dados guardado na variavel newVariavel vão ser "transferidos" de volta para a variavel inicializada em cima 
            public void setCodigo(int newCodigo) { codColab = newCodigo; }
            public void setNome(string newNome) { nomColab = newNome; }
            public void setVenc(double newVenc) { vencColab = newVenc; }
            public void setSeguro(string newSeguro) { segSaudeColab = newSeguro; }
            
            
            // metodo para acrescentar automaticamente o valor do plafond mensal
            public double plafondmensal()
            {
                plafondAlimColab = 140;
                return plafondAlimColab;
            }

            // construtores
            public Colaborador()
            {
            }

            // quando uma pessoa é criada estes dados são preenchidos por garantia
            public Colaborador(string newNome, int newCodigo)
            {
                nomColab = newNome;
                codColab = newCodigo;
            }
        }

        // COISAS A FAZER
        // * quando abrir o programa ele vai buscar os dados - fazer com um metodo
        // * quando fechar o programa tem que emnviar os dados
        // * o plafom de alimentação todos os messes é carregado com 140 euros

        // menu para escolher a opção
        public static int menu()
        {

            int opcao1 = 0;

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

            Console.Write("\nOpção: ");
            // retorna o valor que o utizador selecionou e  transformar a opcao em um numero inteiro 
            return opcao1 = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            // classe colaborador - criar varios objetos chamdados "pessoa" = criar varios colaboradores
            Colaborador[] pessoa = new Colaborador[0];
            int op = 0;
            int i;

            // ciclo para repetir as opcoes 
            do
            {
                op = menu();
                int escolha;

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
                        pessoa[pessoa.Length - 1].setVenc(Convert.ToDouble(Console.ReadLine()));


                        // o plafondAlimColab - ja esta predefinido com 140 quando é criado uma pessoa
                        Console.Write($"Plafond atribuido ao cartão de Alimentação do Colaborador: {pessoa[pessoa.Length - 1].getPlafond()} € \n");

                        // seguro de saude
                        Console.WriteLine("\nVai ser atribuido um Seguro de Saúde ao colaborador?");

                        Console.WriteLine("1. Sim ");
                        Console.WriteLine("2. Não ");

                        Console.Write("\nOpção: ");
                        escolha = Convert.ToInt32(Console.ReadLine());

                        if (escolha > 0 && escolha < 3)
                        {
                            if (escolha == 1)
                            {
                                pessoa[pessoa.Length - 1].setSeguro("Colaborador C/ Seguro de Saude.");
                                Console.WriteLine("Colaborador C/ Seguro de Saude.");
                            }
                            else
                            {
                                pessoa[pessoa.Length - 1].setSeguro("Colaborador S/ Seguro de Saude.");
                                Console.WriteLine("Colaborador S/ Seguro de Saude.");
                            }
                        } else Console.WriteLine("Escolha uma das opções mencionadas a cima! ");
                        break;
                        
                    // 2. Listagem de registos de colaboradores {}
                    case 2:
                        Console.WriteLine("\nLista dos Colaboradores: \n");

                        for (i = 0; i < pessoa.Length; i++)
                        {
                            Console.WriteLine($"\nCodigo: {pessoa[i].getCodigo()}" +
                                              $"\nNome: {pessoa[i].getNome()}" +
                                              $"\nVencimento: {pessoa[i].getVenc()} €" +
                                              $"\nPlafond: {pessoa[i].getPlafond()} €" +
                                              $"\nSeguro: {pessoa[i].getSeguro()}\n");
                        }
                        break;

                    // 3. Consultar o registo de um colaborador
                    case 3:

                        Console.WriteLine("Consultar o registo de um colaborador");

                        Console.WriteLine("Insira o codigo do Colaborador: ");
                        int pesquisa = Convert.ToInt32(Console.Read());

                        for (i = 0; i < pessoa.Length; i++)
                        {
                            if (pesquisa == pessoa[i].getCodigo())
                            {
                                Console.WriteLine($"\nCodigo: {pessoa[i].getCodigo()}" +
                                             $"\nNome: {pessoa[i].getNome()}" +
                                             $"\nVencimento: {pessoa[i].getVenc()} €" +
                                             $"\nPlafond: {pessoa[i].getPlafond()} €" +
                                             $"\nSeguro: {pessoa[i].getSeguro()}\n");
                            }
                        }
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