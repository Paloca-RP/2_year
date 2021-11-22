﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace TP06_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("XXXXXXXXXXXXXX Slide 5 -List<T>");
            // Uma Lista é uma coleção que 
            // 1. Pode ter elementos repetidos
            // 2. Tem como ordem a ordem de adição de elementos
            // 3. É indexada, isto é, podemos aceder a cada elemento da Lista através
            // do indice da posição desse elemento
            List<String> nomes = new List<String>();
            Console.WriteLine("*** A Lista de nomes: ");
            nomes.Add("Alberto");
            nomes.Add("Bernardo");
            nomes.Add("Celeste");
            nomes.Add("Dulce");
            foreach (String s in nomes)
                Console.WriteLine(s);
            Console.WriteLine("*** O elemento na posição 2: " + nomes[2]);
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 7 - Alunos : List<Aluno>");
            // Como Alunos é uma List<Aluno> 
            // 1. Tem já todos os métodos de List<T>
            // 2. Só temos de codificar o ToString caso necessitemos dele
            Alunos alunos = new Alunos();
            Console.WriteLine("A Lista Alunos : List<Aluno>");

            alunos.Add(new Aluno() { Nome = "Armando Albino", Numero = "190210010" });
            alunos.Add(new Aluno() { Nome = "Armando Albino", Numero = "190210010" });
            alunos.Add(new Aluno() { Nome = "Beatriz Martins", Numero = "190210011" });
            alunos.Add(new Aluno() { Nome = "Carlos Brotas", Numero = "190210012" });

            Console.WriteLine("A Lista Alunos com quatro alunos");
            Console.WriteLine(alunos.ToString());
            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 8 - Turma tem uma List<Aluno>");
            Turma turma = new Turma("A", 2, "CTESP TPSI");
            turma.Add(new Aluno() { Nome = "Armando Albino", Numero = "190210010" });
            turma.Add(new Aluno() { Nome = "Armando Albino", Numero = "190210010" });
            turma.Add(new Aluno() { Nome = "Beatriz Martins", Numero = "190210011" });
            turma.Add(new Aluno() { Nome = "Carlos Brotas", Numero = "190210012" });
            turma.Add(new Aluno() { Nome = "Diana Andringa", Numero = "190210013" });
            turma.Add(new Aluno() { Nome = "Carlos Brotas", Numero = "190210012" });
            turma.Add(new Aluno() { Nome = "Diana Andringa", Numero = "190210013" });


            Console.WriteLine("Uma turma com cinco alunos");
            Console.WriteLine(turma.ToString());
            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 9 - HashSet<String>");
            // Um conjunto (Set) é uma coleção que 
            // 1. não tem elementos repetidos
            // 2. não tem ordem (não garante que os elementos "estejam" pela ordem de inserção)
            // 3. não é indexada (os elementos não são acessíveis por um indice
            HashSet<String> numerosDeAluno = new HashSet<string>();
            numerosDeAluno.Add("190210001");
            numerosDeAluno.Add("190210002");
            numerosDeAluno.Add("190210003");
            numerosDeAluno.Add("190210004");
            numerosDeAluno.Add("190210004"); // Não consigo adicionar outro 0004
            numerosDeAluno.Add("190210003"); // Não consigo adicionar outro 0003
            // A classe HashSet<String> consegue detetar strings iguais porque
            // a classe String já define os seus próprios equals e getHasCode
            Console.WriteLine("O HashSet de String depois de adicionados 04 e 03 repetidos");
            foreach(String s in numerosDeAluno)
                Console.WriteLine(s);
            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 11 - SetAlunos : HashSet<Aluno>");
            // Como SetAlunos é um HashSet<Aluno> 
            // 1. Tem já todos os métodos de HashSet<T>
            // 2. herda os Equals e GetHashCode de Object
            //    para os quais dois objetos "Aluno" são iguais se 
            //    referenciarem o mesmo endereço de memória ...
            // 3. Por isso teremos de redefinir os Equal e GetHshcode
            //    da classe Aluno por forma a que dois alunos sejam iguais
            //    de acordo com os nossos critérios: dois alunos serão 
            //    iguais se tiverem o mesmo numero de aluno (ver classe Aluno)
           SetAlunos conjuntoDeAlunos = new SetAlunos();
            conjuntoDeAlunos.Add(turma[0]); // estamos a usar o indexer de Turma  ;-)
            conjuntoDeAlunos.Add(turma[1]);
            conjuntoDeAlunos.Add(turma[2]);
            conjuntoDeAlunos.Add(turma.GetAt(3));
            conjuntoDeAlunos.Add(turma.GetAt(4));
            conjuntoDeAlunos.Add(new Aluno() { Nome = "Carlos Brotas", Numero = "190210012" });
            conjuntoDeAlunos.Add(new Aluno() { Nome = "Diana Andringa", Numero = "190210013" });
            // A classe SetAlunos NÃO consegue detetar ALUNOS iguais se não redefenirmos
            // os equals e getHasCode de Aluno ;-)
            Console.WriteLine("SetAlunos depois de adicionados Alunos repetidos");
            Console.WriteLine("Sem redefinir o Equals e GetHashCode de Aluno (estão comentados)");
            Console.WriteLine("permitiu a adição de dois carlos e duas dianas ...");
            foreach (Aluno a in conjuntoDeAlunos)
                Console.WriteLine(a);
            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 8 - Iterar um HashSet com um Enumerator");
            HashSet<String>.Enumerator it = numerosDeAluno.GetEnumerator(); // criar o enumerator
            string val = "";
            for (int i = 0; i <= numerosDeAluno.Count; i++)
            {
                val = it.Current;
                Console.WriteLine(val);
                it.MoveNext();
            }

            // coloca Current imediatamente antes do primeiro elemento
            it = numerosDeAluno.GetEnumerator(); 
            // Assim sendo temos de avançar o iterador para o elemento seguinte
            it.MoveNext();
            do
            {
                // it.Current retorna o valor atualmente apontado pelo Enumerator
                val = it.Current;
                Console.WriteLine(val);
                // it.MoveNext tenta mover para o seguinte
                // se existir um seguinte move e retorna true
                // caso contrário retorna false
            } while (it.MoveNext() && !val.Equals("190210007"));
            Console.WriteLine(val);

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 15 - Dictionary<TKey, TValue>");
            // Um Dictionary é uma coleção de pares chave/valor <key, value> 
            // 1. não tem chaves repetidas (não há duas chaves iguais)
            // 2. Pode ter valores repetidos (com chaves diferentes ;-)
            // 3. Também conhecido por tabela indexada

            Sala turmaNaSala = new Sala();
            turmaNaSala.Add(Lugares.F1LA, alunos[0]);
            turmaNaSala.Add(Lugares.F1LB, alunos[1]);
            turmaNaSala.Add(Lugares.F1LC, alunos[2]);
            alunos.Add(new Aluno() { Numero = "190210013", Nome = "Daniel Fagundes" });
            alunos.Add(new Aluno() { Numero = "190210014", Nome = "Eulália Ferreira" });
            alunos.Add(new Aluno() { Numero = "190210015", Nome = "Fagundes da Silva" });
            turmaNaSala.Add(Lugares.F1LD, alunos[3]);
            turmaNaSala.Add(Lugares.F2LA, alunos[4]);
            Console.WriteLine("A Turma na sala:");
            Console.WriteLine(turmaNaSala.ToString());
            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 21 - LinQ");
            // A. Simplifica e uniformiza a forma de obter informação 
            // a partir de um QUALQUER conjunto de dados. 
            // B. O conjunto de dados pode ser qualquer coleção : um array, 
            // uma lista ou uma base de dados. 
            // A sintaxe mais simples de uma instrução LINQ é:
            // from iterador in coleção select elementoSeleccionado

            // A Utilização do LinQ faz-se me dois passos
            // 1. definimos a query
            IEnumerable<Aluno> tudoNaLista = from aluno in alunos select aluno;
            // 2. executamos a query
            var colecao = tudoNaLista;
            // ou 2.
            foreach (Aluno a in tudoNaLista)
                Console.WriteLine(a);
            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 22 - LinQ query");
            //Dada uma coleção:
            int[] nums = new int[] { 1, 2, 4, 7, 12, 14, 15, 16, 18, 21 };

            var res = from i
                      in nums
                      where i >= 5 &&
                            i <= 15
                      select i;

            foreach (int x in res)
                Console.WriteLine("> " + x);

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 23 - LinQ Execução Diferida");
            // A query LINQ é executada no momento em que é invocada 
            // e assim o resultado traz sempre os valores atualizados. 

            // vamos adicionar dois novos alunos à nossa coleção de alunos
            alunos.Add(new Aluno() { Numero = "190210015", Nome = "Gabriel Fagundes" });
            alunos.Add(new Aluno() { Numero = "190210016", Nome = "Hedmundo Pedro" });

            // quando agora executarmos a query definida acima
            // no slide 22
            // ela retorna já os dois alunos entretanto adicionados
            foreach (Aluno a in tudoNaLista)
                Console.WriteLine(a);

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 24 - LinQ Execução Imediata");
            // Por vezes interessa-nos ficar com uma "fotografia"
            // da coleção num dado momento (para futura comparação por exemplo)
            // Nesse casos podemos guardar o resultado da query numa coleção:
            // expressão LINQ com execução imediata
            List<String> joses =
                 (from a
                 in alunos
                 where a.Nome.Contains("Fagundes")
                 select a.Nome).ToList();

            Console.WriteLine("\n\nALUNOS com 'Fagundes' no nome (3):");
            foreach (String n in joses)
                Console.WriteLine("> " + n);

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 19 e 20  - Operadores");
            Console.WriteLine("Experimente usar os operadores");
            Console.WriteLine("orderby , ascending e descending");
            Console.WriteLine(" ToList<>() converte o resultado numa lista de elementos");
            Console.WriteLine(" ToArray<>() converte o resultado num array de elementos");
            Console.WriteLine(" Reverse<>() inverte a ordem dos elementos, etc.");
            Console.WriteLine(" Distinct<>(), Union<>(),Intersect<>()");
            Console.WriteLine(" ou outros que agregam os resultados");
            Console.WriteLine(" Count<>(), Sum<>(), Min<>(), Max<>(), etc. ");

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 21  - Projecção de dados com tipos anónimos");
            // É possível obter como resultado de uma query LINQ 
            // um conjunto de dados de um tipo anónimo.
            // Tal pode ser  útil quando se pretende 
            // analisar um subconjunto da informação existente nos dados.
            // No exemplo foi criado um tipo anónimo com os campos Nome e NumeroDeAlunos 
            // que contém apenas a informação do nome e do total de alunos existente na disciplina.
            var fagundes = from d in alunos
                       where d.Nome.Contains("Fagundes")
                       select
                       new { Nome = d.Nome, NumeroDeAlunos = alunos.Count() };
            foreach (var a in fagundes)
                Console.WriteLine("> " + a);

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 22  - Linq C/ Métodos de Extensão");
            // É possível não utilizar a sintaxe integrada do LINQ definida para a linguagem C#. 
            // Neste caso aplicam-se directamente os métodos de extensão sobre as fontes de dados. 
            // Muitos dos métodos de extensão têm como argumento referências 
            // de métodos que são habitualmente chamados para cada elemento do conjunto de dados.
            // Nos exemplos mostra-se a sintaxe LINQ usando os métodos de extensão. 
            // Usam-se expressões lambda para passar os métodos como argumentos
            var res4 = alunos.Where
                       (a => a.Nome.Contains("Fagundes")).Select
                       (a => a.Nome);
            Console.WriteLine("alunos.Where (a => a.Nome.Contains(\"Fagundes\")).Select (a => a.Nome);");
            foreach (var a in res4.ToList()) Console.WriteLine(a.ToString());
            Console.WriteLine();

            Console.WriteLine("alunos.OrderBy (a => a.Nome).Select(a => a);");
            var res5 = alunos.OrderByDescending
                       (a => a.Nome).Select(a => a);
            foreach (var a in res5.ToList()) Console.WriteLine(a.ToString());
            Console.WriteLine();

            Console.WriteLine(" alunos.Where (a => a.Numero.Contains(\"11\")).Select (a => a.Nome);");
            var res6 = alunos.Where (a => a.Numero.Contains("11")).Select (a => a.Nome);
            foreach (var a in res6.ToList()) Console.WriteLine(a.ToString());
            Console.WriteLine();

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();
        }
    }
}
