namespace AppConverterConsole
{
    public static class ValidateText
    {
        public static bool IsValidJson(string json_text)
        {
            int tamanho = 0;
            bool sequencia = false;

            foreach (char c in json_text)
            {
                switch (c)
                {
                    case '{':
                    case '[':
                        if (!sequencia)
                        {
                            tamanho++;
                        }
                        break;
                    case '}':
                    case ']':
                        if (!sequencia)
                        {
                            tamanho--;
                        }
                        break;
                    case '"':
                        sequencia = !sequencia;
                        break;
                }
            }
            return tamanho == 0 && !sequencia;
        }

        public static void CheckCondition(string json_text)
        {
            if (json_text.StartsWith("[{") || json_text.StartsWith("{"))
            {
                if (json_text == "")
                {
                    Mensagem("O campo está vazio. Preencha-o novamente!");
                }
                else if (!IsValidJson(json_text))
                {
                    Mensagem("JSON no formato inválido. Preencha-o novamente!");
                }
            }
            else
            {
                Console.Write("\n");
                Mensagem("JSON no formato inválido. Preencha-o novamente!");
            }
        }

        public static void Mensagem(string text)
        {
            Console.WriteLine(text);
            Thread.Sleep(4000);
            Converter.JsonToCSV();
        }
    }
}