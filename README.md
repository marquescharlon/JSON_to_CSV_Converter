# json_to_csv_converter
Repositório destinado à avaliação solicitada pela Yardim (https://www.yardim.com.br/)

## Parâmetros

Texto JSON: ```[{"Vaga":"Desenvolvedor.NET","Empresa":"Yardim","Nivel":"Junior","Site":"https://www.yardim.com.br/"}]```

```
[
	{
	  "Vaga": "Desenvolvedor .NET",
	  "Empresa": "Yardim",
	  "Nivel": "Junior",
	  "Site": "https://www.yardim.com.br/"
	}
]
```

![image](https://user-images.githubusercontent.com/22162514/225399976-632a1b7a-509d-42f3-8c51-d4d09ac5a1d1.png)

![image](https://user-images.githubusercontent.com/22162514/225400180-bdc6db60-5d52-4c4c-af65-4df3b949c3f7.png)

![image](https://user-images.githubusercontent.com/22162514/225400577-ae235723-0d9e-4005-ac2e-434e3d6d4e39.png)

![image](https://user-images.githubusercontent.com/22162514/225401096-765d38e4-ca00-4115-b40f-053e2af75a14.png)


## User Stories
- [x] O usuário pode colar um JSON em uma caixa de texto
- [x] O usuário pode clicar no botão 'Converter' para validar o JSON e convertê-lo em CSV
- [x] O usuário pode ver o CSV convertido em outra caixa de texto
- [x] O usuário pode ver uma mensagem de aviso se a caixa de texto JSON estiver vazia ou se não contiver um JSON válido
- [x] O usuário pode clicar no botão 'Limpar' para limpar o conteúdo das caixas de texto JSON e CSV.

## Bônus 
- [x] Pense em algumas validações (como o usuário pode quebrar seu sistema)
- [ ] Exibir o resultado em uma tabela
