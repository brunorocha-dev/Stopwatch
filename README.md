<h1 align="center">Stopwatch em C#</h1>
<p align="center">Este é um simples aplicativo de cronômetro (stopwatch) em C# que permite contar o tempo em segundos ou minutos. Você pode usá-lo para medir intervalos de tempo ou para cronometrar tarefas.</p>

## 💻 Como Usar
1. Compilação e Execução:
Certifique-se de ter o .NET SDK instalado em sua máquina.
Abra o terminal e navegue até a pasta do projeto.
Execute o comando dotnet run para iniciar o aplicativo.
2. Menu:
O menu inicial permite que você escolha entre contar em segundos (S) ou minutos (M).
Insira o tempo desejado (por exemplo, 5s ou 2m).
O cronômetro será iniciado e contará até zero.
3. Formato de Entrada:
Use o formato “Xs” para segundos ou “Xm” para minutos (onde X é um número inteiro).
Por exemplo: “10s” para 10 segundos ou “3m” para 3 minutos.
4. Parar o Cronômetro:
O cronômetro será exibido na tela e diminuirá a cada segundo.
Quando atingir zero, você verá a mensagem “Stopwatch finalizado”.

## 💡Exemplo de Uso
```
S = Segundos
M = Minutos
0 = Sair!
---
Quanto tempo deseja contar? (Exemplo: 5s ou 2m)
> 30s
Preparar...
Apontar...
Vai!...
30
29
28
...
1
Stopwatch finalizado
```
## 🤝 Contribuição
Sinta-se à vontade para contribuir com melhorias, correções de bugs ou novos recursos! Basta abrir uma issue ou enviar um pull request.