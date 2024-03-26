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

        // COISAS A FAZER
        // * quando abrir o programa ele vai buscar os dados - fazer com um metodo (fazer no fim de tudo)
        // * quando fechar o programa tem que emnviar os dados (fazer no fim de tudo)
        // * o plafom de alimentação todos os messes é carregado com 140 euros (feito)

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
            public double getPlafond() { return plafondAlimColab; }
            public string getSeguro() { return segSaudeColab; }

            // set entrada de dados, todos os dados guardado na variavel newVariavel vão ser "transferidos" de volta para a variavel inicializada em cima 
            public void setCodigo(int newCodigo) { codColab = newCodigo; }
            public void setNome(string newNome) { nomColab = newNome; }
            public void setVenc(double newVenc) { vencColab = newVenc; }
            public void setPlafond(double newPlafond) { plafondAlimColab = newPlafond; } 
            public void setSeguro(string newSeguro) { segSaudeColab = newSeguro; }
            
      
            // construtores
            public Colaborador()
            {
                plafondAlimColab = 140;
            }

            // quando uma pessoa é criada estes dados são preenchidos por garantia
            public Colaborador(string newNome, int newCodigo)
            {
                nomColab = newNome;
                codColab = newCodigo;
            }
        }

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

        public static int menualt()
        {

            int opcao2 = 0;

            Console.WriteLine("\nMenu com opções: \n");
            Console.WriteLine("1. Altrar o Código do colaborador");
            Console.WriteLine("2. Altrar o Nome do colaborador");
            Console.WriteLine("3. Altrar o Vencimento do colaborador");
            Console.WriteLine("4. Altrar o Plafond do Cartão de Alimentação do colaborador");
            Console.WriteLine("5. Altrar o Seguro de Saúde do colaborador");
            
            Console.WriteLine("0. Sair");

            Console.Write("\nOpção: ");
            return opcao2 = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            // classe colaborador - criar varios objetos chamdados "pessoa" = criar varios colaboradores
            Colaborador[] pessoa = new Colaborador[0];
            int op = 0;
            int i;
            int alterar;
            int opcao2= 0;
            int pesquisarCodigo = 0;

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

                        Console.Write("Insira o código do Colaborador: ");
                        pessoa[pessoa.Length - 1].setCodigo(Convert.ToInt32(Console.ReadLine())); // O array criado com o parametro codigo
                        

                        Console.Write("Insira o nome do Colaborador: ");
                        pessoa[pessoa.Length - 1].setNome(Console.ReadLine());

                        Console.Write("Insira o Vencimento do Colaborador: ");
                        pessoa[pessoa.Length - 1].setVenc(Convert.ToDouble(Console.ReadLine()));


                        // o plafondAlimColab - ja esta predefinido com 140 quando é criado uma pessoa
                        Console.Write($"Plafond atribuido ao cartão de Alimentação do Colaborador: {pessoa[pessoa.Length - 1].getPlafond()} € \n");

                        // seguro de saude
                        Console.WriteLine("\nDeseja atribuir um Seguro de Saúde ao colaborador?");

                        Console.WriteLine("1. Sim ");
                        Console.WriteLine("2. Não ");

                        Console.Write("\nOpção: ");
                        escolha = Convert.ToInt32(Console.ReadLine());

                        if (escolha == 1)
                            {
                                pessoa[pessoa.Length - 1].setSeguro("Colaborador C/ Seguro de Saude.");
                                Console.WriteLine("Seguro de Saúde atribuído com sucesso ao colaborador.");
                            }

                        else if(escolha == 2)
                            {
                                pessoa[pessoa.Length - 1].setSeguro("Colaborador S/ Seguro de Saude.");
                                Console.WriteLine("Colaborador não terá Seguro de Saúde.");
                            }

                        else Console.WriteLine("Opção inválida. Escolha uma das opções mencionadas acima!");

                        break;

                    // 2. Listagem de registos de colaboradores {}
                    case 2:
                        Console.WriteLine("\nLista dos Colaboradores: \n");

                        for (i = 0; i < pessoa.Length; i++)
                        {
                            Console.WriteLine($"\nCódigo: {pessoa[i].getCodigo()}" +
                                              $"\nNome: {pessoa[i].getNome()}" +
                                              $"\nVencimento: {pessoa[i].getVenc()} €" +
                                              $"\nPlafond: {pessoa[i].getPlafond()} €" +
                                              $"\nSeguro de Saúde: {pessoa[i].getSeguro()}\n");
                        }
                        break;

                    // 3. Consultar o registo de um colaborador
                    case 3:

                        Console.WriteLine("\nConsultar o registo de um colaborador: \n");

                        Console.WriteLine("\nInsira o código do Colaborador: ");
                        Console.Write("\nOpção: ");
                        pesquisarCodigo = Convert.ToInt32(Console.ReadLine());

                        for (i = 0; i < pessoa.Length; i++)
                        {
                            if (pesquisarCodigo == pessoa[i].getCodigo())
                            {
                                Console.WriteLine($"\nCódigo: {pessoa[i].getCodigo()}" +
                                             $"\nNome: {pessoa[i].getNome()}" +
                                             $"\nVencimento: {pessoa[i].getVenc()} €" +
                                             $"\nPlafond: {pessoa[i].getPlafond()} €" +
                                             $"\nSeguro de Saúde: {pessoa[i].getSeguro()}\n");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Colaborador não encontrado. Verifique o código e tente novamente.");
                            }         
                        }
                    break;

                    // 4. Alterar dados de colaboradores
                    case 4:

                        Console.WriteLine("\nAlterar dados de colaboradores: ");

                        do
                        {
                            opcao2 = menualt();
                            switch (opcao2)
                            {
                                case 1:

                                    bool codRepetido = false;

                                    Console.WriteLine("\nQual é o Colaborador que deseja alterar os dados?");
                                    Console.Write("Insira o código do Colaborador: ");
                                    pesquisarCodigo = Convert.ToInt32(Console.ReadLine());

                                    for (i = 0; i < pessoa.Length; i++)
                                    {
                                        // alterar codigo colaborador
                                        if (pesquisarCodigo == pessoa[i].getCodigo())
                                        {
                                            Console.WriteLine("Colaborador encontrado");

                                            Console.Write("\nInsira um novo Código de colaborador: ");
                                            int altCodigo = Convert.ToInt32(Console.ReadLine());

                                            for (int j = 0; j < pessoa.Length; j++)
                                            {
                                                if (altCodigo == pessoa[j].getCodigo())
                                                {
                                                    // se o codigo for repetido entao ele sai do ciclo
                                                    codRepetido = true;
                                                    break;
                                                } 
                                            }

                                            if (!codRepetido)
                                            {
                                                // se for diferente ele altera
                                                pessoa[i].setCodigo(altCodigo);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n O código de colaborador já está a ser usado. Por favor, escolha um código diferente.");
                                            }
                                            break;

                                        } else {
                                                Console.WriteLine("\nColaborador não encontrado. Verifique o código e tente novamente.");
                                               } 
                                    }

                                break;

                                case 2:
                                    // alterar o nome
                                    Console.WriteLine("\nQual é o Colaborador que deseja alterar o nome?");
                                    Console.Write("Código do Colaborador: ");
                                    pesquisarCodigo = Convert.ToInt32(Console.ReadLine());

                                    for (i = 0; i < pessoa.Length; i++) {

                                        if (pesquisarCodigo == pessoa[i].getCodigo())
                                        {
                                            Console.Write("\nInsira o novo nome do colaborador: ");
                                            string altNome = Console.ReadLine();

                                            pessoa[i].setNome(altNome);
                                            Console.WriteLine("\nNome alterado com sucesso!");
                                        }
                                    }
                                break;

                                case 3:
                                    // alterar o Vencimento
                                    Console.WriteLine("\nQual é o Colaborador que deseja alterar o vencimento?");
                                    Console.Write("Código do Colaborador: ");
                                    pesquisarCodigo = Convert.ToInt32(Console.ReadLine());

                                    for (i = 0; i < pessoa.Length; i++)
                                    {
                                        if (pesquisarCodigo == pessoa[i].getCodigo()){ 

                                            Console.Write("\nInsira o novo vencimento do colaborador: ");
                                            double altVenc = Convert.ToDouble(Console.ReadLine());

                                            if (altVenc > 0)
                                            {
                                                pessoa[i].setVenc(altVenc);
                                                Console.WriteLine("\nVencimento alterado com sucesso!");

                                            } else Console.WriteLine("\nVencimento invalido! O valor deve ser superior a zero.");}
                                    }
                                break;

                                case 4:
                                    // alterar o Plafond
                                    Console.WriteLine("\nQual é o Colaborador que deseja alterar o Plafond do Cartão de alimentação?");
                                    Console.Write("Código do Colaborador: ");
                                    pesquisarCodigo = Convert.ToInt32(Console.ReadLine());

                                    for (i = 0; i < pessoa.Length; i++)
                                    {
                                        if (pesquisarCodigo == pessoa[i].getCodigo())
                                        {
                                            Console.Write("\nNovo Plafond do Cartão de Alimentação: ");
                                            double altPlafond = Convert.ToDouble(Console.ReadLine());

                                            if(altPlafond > 0)
                                            {
                                                pessoa[i].setPlafond(altPlafond);
                                                Console.WriteLine("\nPlafond do Cartão de Alimentação alterado com sucesso!");

                                            } else Console.WriteLine("\nO valor do plafond deve ser maior que zero.");
                                        }
                                    }
                                 break;

                                case 5:
                                    // altarar o Seguro de Saude
                                    Console.WriteLine("\nQual é o Colaborador que deseja alterar o seguro de saúde?");
                                    Console.Write("Código do Colaborador: ");
                                    pesquisarCodigo = Convert.ToInt32(Console.ReadLine());

                                    for (i = 0; i < pessoa.Length; i++)
                                    {
                                        if (pesquisarCodigo == pessoa[i].getCodigo())
                                        {
                                            Console.Write("\nAlterar o Seguro de Saúde: ");

                                            Console.WriteLine("1. Com Seguro de Saúde ");
                                            Console.WriteLine("2. Sem Seguro de Saúde ");

                                            Console.Write("\nOpção: ");
                                            int altSeguro = Convert.ToInt32(Console.ReadLine());

                                            if (altSeguro == 1)
                                                {
                                                    pessoa[i].setSeguro("Colaborador C/ Seguro de Saúde.");
                                                    Console.WriteLine("\nSeguro de Saúde alterado com sucesso! Seguro ativado.");
                                                }
                                            else if (altSeguro == 2)
                                                {
                                                    pessoa[i].setSeguro("Colaborador S/ Seguro de Saúde.");
                                                    Console.WriteLine("\nSeguro de Saúde alterado com sucesso! Seguro desativado.");
                                                }
                                            else Console.WriteLine("Opção inválida. Escolha uma das opções mencionadas acima!");
                                        }
                                    }
                                break;
                            } 

                        } while (opcao2 != 0);

                        break;


                    // 5. Eliminar colaborador
                    case 5:

                        Console.WriteLine("\nEliminar colaborador: ");

                        Console.WriteLine("\nQual é o Colaborador que deseja remover?");
                        Console.Write("Código do Colaborador: ");
                        int removerColab = Convert.ToInt32(Console.ReadLine());

                        for(i = 0; i< pessoa.Length;i++)
                        
                            if (removerColab == pessoa[i].getCodigo())
                            {

                                for (int j = 1; j < pessoa.Length-1; j++) 
                                    pessoa[j] = pessoa[j + 1];
                                    Array.Resize(ref pessoa, pessoa.Length - 1);
                                    Console.Write("\nColaborador removido com sucesso!");
                            }
                            else
                            {
                              Console.WriteLine("\nOperação inválida. O colaborador não foi encontrado ou a ação não pôde ser concluída.");
                            }

                    break;

                    // 6. Consultar o saldo do subsídio de Alimentação de um colaborador 
                    case 6:

                        Console.WriteLine("\nConsultar o saldo do subsídio de Alimentação de um colaborador: ");

                        Console.WriteLine("\nQual é o Colaborador que deseja ver o saldo do subsídio de Alimentação?");
                        Console.Write("Código do Colaborador: ");
                        pesquisarCodigo = Convert.ToInt32(Console.ReadLine());

                        for (i = 0; i < pessoa.Length; i++){
                            
                            if(pesquisarCodigo == pessoa[i].getCodigo()) {

                                Console.WriteLine($"\nNome: {pessoa[i].getNome()}" + $"\nPlafond: {pessoa[i].getPlafond()} €");
                            }
                        }
                        break;

                    // 7. Usar o cartão para as refeições 
                    case 7:
                        Console.WriteLine("\nUsar o cartão para as refeições: ");

                        // qual é o colaborador
                        Console.WriteLine("\nQual é o Colaborador que deseja inserir o valor da refeição?");
                        Console.Write("Código do Colaborador: ");
                        pesquisarCodigo = Convert.ToInt32(Console.ReadLine());

                        for (i = 0; i < pessoa.Length; i++)
                        {

                            if (pesquisarCodigo == pessoa[i].getCodigo())
                            {
                                // menu para poder inserir mais que uma vez a refeicao
                                Console.WriteLine("\nMenu:\n");

                                Console.WriteLine("1. Inserir refeicao");
                                Console.WriteLine("0. Sair");

                                Console.Write("\nOpção: ");
                                int opEscolhida = Convert.ToInt32(Console.ReadLine());

                                if (opEscolhida == 1)
                                {
                                    // qual é o valor da refeicao { }
                                    Console.Write("\nQual é o valor da refeição: ");
                                    double valorRefeicao = Convert.ToInt32(Console.ReadLine());

                                    double plafondAtual = pessoa[i].getPlafond();

                                    plafondAtual -= valorRefeicao;

                                    pessoa[i].setPlafond(plafondAtual);
                                    Console.WriteLine($"Valor atual do Cartão de almentação: {pessoa[i].getPlafond()}");
                                } 
                                else 
                                {
                                  Console.WriteLine("Opção inválida. Escolha uma das opções mencionadas acima!");
                                }
                            }
                        }
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