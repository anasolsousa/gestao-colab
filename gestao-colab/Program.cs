﻿using System;
using System.Text;
using System.Text.Unicode;
using System.IO;
using System.Globalization;
using System.Net;


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
            bool segSaudeColab;
        }
        // COISAS A FAZER
        // * quando abrir o programa ele vai buscar os dados 
        // * quando fechar o programa tem que emnviar os dados
        // * o plafom de alimentação todos os messes é carregado com 140 euros

        // menu para escolher a opção
        public static int menu() {

            int opcao = 0;

            Console.WriteLine("Menu com opções: ");
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
            Console.WriteLine("13. Listagem dos inscritos no Seguro de Saúde");

            Console.WriteLine("0. Sair");

            // transformar a opcao em um numero inteiro 
            opcao = Convert.ToInt32(Console.Read());

            // retorna o valor que o utizador selecionou
            return opcao;
        }

        static void Main(string[] args)
        {
            // classe colaborador - criar varios objetos chamdados "pessoa"
            Colaborador[] pessoa = new Colaborador[0];
            int op = 0;

            // ciclo para repetir as opcoes 
            do{
                op = menu();
                switch (op)
                {
                    // 1. Inserir colaborador
                    case 1:
                        Console.WriteLine("Hello world");
                    break;

                    // 2. Listagem de registos de colaboradores
                    case 2:
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