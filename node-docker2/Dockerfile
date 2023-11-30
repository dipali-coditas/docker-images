FROM node:21-alpine
WORKDIR /app
COPY package*.json ./app/
RUN npm config set strict-ssl false
RUN npm install
COPY . .
EXPOSE 3200
CMD [ "npm", "start" ,"index.js"]

