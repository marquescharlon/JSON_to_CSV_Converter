using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppConverterConsole
{
    public static class Converter
    {
        public static void JsonToCSV()
        {

            Console.Clear();

            // Pedir que seja informado na execução do programa
            Console.WriteLine("Informar o texto JSON");
            var texto_json = Console.ReadLine();


            // 3. Como ler a informação JSON para realizar a manipulação?

            //var texto_json = @"[{""Vaga"":""Desenvolvedor.NET"",""Empresa"":""Yardim"",""Nivel"":""Junior"",""Site"":""https://www.yardim.com.br/""}]";

            // 4. Como manipular cada objeto encontrado do JSON?

            var texto_string = texto_json?.Replace("{", "").Replace("}", "").Trim();
            var linha = texto_string?.Split(",");

            // 5. Como extrair as Chaves que irão formar o cabeçalho no formato CSV?

            string[] campos = new string[texto_string.Length];
            var primeiralinha = texto_string.Split(",");

            HashSet<string> nomesVistos = new HashSet<string>();
            int p = 0;

            foreach (var item in primeiralinha)
            {
                var nomes = item.Split('"');
                string nome = nomes[1];

                if (!nomesVistos.Contains(nome))
                {
                    campos.SetValue(nome, p);
                    nomesVistos.Add(nome);
                    p++;
                }
            }

            // 6. Como construir meu CSV?

            // a. Construir primeiro o cabeçalho do CSV

            string[] textoCSV = new string[campos.Length];

            foreach (var item in campos)
            {
                if (item != null)
                {
                    textoCSV[0] += "\"" + item + "\",";
                }
            }

            // // b. Construir o restante do corpo preenchendo com as demais linhas

            string[] corpo = new string[texto_string.Length];
            var segunda_linha = texto_string.Split(",");

            int count_corpo = 0;

            foreach (var item in segunda_linha)
            {
                var nomes = item.Split('"');
                string nome = nomes[1];

                corpo.SetValue(nome, count_corpo);
                count_corpo++;
            }

            foreach (var item in corpo)
            {
                if (item != null)
                {
                    textoCSV[0 + 1] += "\"" + texto_json?.Split("\"" + item + "\"")[1].Split("\"")[1] + "\",";

                }
            }

            // c. Gerar e imprimir resultado

            var resultado = "";
            foreach (var item in textoCSV)
            {
                if (item != null)
                {
                    resultado += item + "\n";
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Esse é o texto convertido em um formato CSV:");
            Console.WriteLine("\n");
            Console.WriteLine(resultado);
            Menu.LimparTela();

        }
    }
}