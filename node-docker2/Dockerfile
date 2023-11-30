FROM node:21-alpine

# Set the working directory in the container
WORKDIR /app

# Copy package.json and package-lock.json before other files
# Utilize Docker cache to save re-installing dependencies if unchanged
COPY package*.json ./app/

# Install dependencies
RUN npm config set strict-ssl false
RUN npm install

# Copy application code
COPY . .

# Expose port 8080 for the Node.js app 
EXPOSE 3200

# Set environment variable for port so it matches index.js
ENV PORT=3200

# Command to run the Node.js app when container starts  
CMD [ "npm", "start" ,"index.js"]

