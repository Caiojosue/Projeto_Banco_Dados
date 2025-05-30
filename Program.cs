﻿using projeto_claudinei;

internal class Program
    {

        static PessoasDbContext db = new PessoasDbContext();
        static void ExibirPessoas(int idadeMinima)
        {
            Console.WriteLine("Pessoas: ");
            IEnumerable<Pessoa> pessoasOrdenadasPorIdade = db.Pessoas
                .OrderByDescending(p => p.Idade)
                .Where(p => p.Idade >= idadeMinima);

            foreach (Pessoa pessoa in pessoasOrdenadasPorIdade)
            {
                Console.WriteLine($"{pessoa.Nome} - " +
                    $"{pessoa.Idade} anos - " +
                    $"Email: {pessoa.Email} - " +
                    $"Endereço: {pessoa.Endereco} " +
                    $"Emprego: {pessoa.Emprego}");
            }
        }

        static void CriarPessoa()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o email: ");
            string email = Console.ReadLine();
 
            Console.Write("Digite o endereço: ");
            string endereco = Console.ReadLine();

            Console.Write("Digite o emprego: ");
            new Emprego = 

            Pessoa novaPessoa = new Pessoa(nome, idade, email, endereco, emprego);

            db.Pessoas.Add(novaPessoa);
            db.SaveChanges();
        }
        static void Main(string[] args)
        {
            CriarPessoa();
            ExibirPessoas(0);
        }
    }