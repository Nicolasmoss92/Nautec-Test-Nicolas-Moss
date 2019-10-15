# Nautec-Test-Nicolas-Moss
Nautec Test Nicolas Moss

# Introdução

Este programa tem como principal função, descrever a ação de um certo cliente. 
Exemplo: entrou na loja, saiu da loja ou passou na frente da loja.

# Pré-requisito

-Instalar VisualStudio.

# Desenvolvimento

Como ponto de entrada, este programa recebe um arquivo json 'boxe.data', com a identificação de cada pessoa e suas coordenadas. 

Para cada linha do arquivo, o programa identifica a pessoa e suas coordenadas (x e y) para que seja possível determinar sua ação:
- Se a primeira e a última posição no eixo 'y' referente àquela pessoa é menor ou igual a 400, então a pessoa passou pela frente da loja.
- Se a primeira posição no eixo 'y' for menor que a última posição no eixo 'y', então a pessoa entrou na loja.
- Se a primeira posição no eixo 'y' for maior que a última posição no eixo 'y', então a pessoa saiu da loja.

Como saída, este programa gera um arquivo 'output.data', formatado em JSON, contendo o id da pessoa e qual foi sua ação principal.




