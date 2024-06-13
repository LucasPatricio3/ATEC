# Usar a imagem base do Node.js
FROM node:14-slim

# Definição da folder de trabalho dentro do container
WORKDIR /app

# Copie os arquivos do diretório atual para o diretório de trabalho no contêiner
# Copiar os ficheiros da pasta atual para a pasta de trabalho do container 
COPY . .

# Instalar as dependências do Node.js
RUN npm install

# Expor a porta 3000 para acesso ao ao webserver express
EXPOSE 3000

# Definição do comando padrão a ser executado quando o container for iniciado
CMD ["node", "app.js"]
