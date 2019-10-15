# Nautec-Test-Nicolas-Moss
Nautec Test Nicolas Moss

# Introdu��o

Este programa tem como principal fun��o, descrever a a��o de um certo cliente. 
Exemplo: entrou na loja, saiu da loja ou passou na frente da loja.

# Pr�-requisito

-Instalar VisualStudio.

# Desenvolvimento

Como ponto de entrada, este programa recebe um arquivo json 'boxe.data', com a identifica��o de cada pessoa e suas coordenadas. 

Para cada linha do arquivo, o programa identifica a pessoa e suas coordenadas (x e y) para que seja poss�vel determinar sua a��o:
- Se a primeira e a �ltima posi��o no eixo 'y' referente �quela pessoa � menor ou igual a 400, ent�o a pessoa passou pela frente da loja.
- Se a primeira posi��o no eixo 'y' for menor que a �ltima posi��o no eixo 'y', ent�o a pessoa entrou na loja.
- Se a primeira posi��o no eixo 'y' for maior que a �ltima posi��o no eixo 'y', ent�o a pessoa saiu da loja.

Como sa�da, este programa gera um arquivo 'output.data', formatado em JSON, contendo o id da pessoa e qual foi sua a��o principal.




