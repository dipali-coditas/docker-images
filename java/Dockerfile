# Use the official OpenJDK base image
FROM openjdk:11-slim

# Set the working directory
WORKDIR /app

# Copy the Java application JAR file
# COPY SimpleHttpServer.java /app/SimpleHttpServer.java
COPY . /app/
# Compile the Java application
RUN javac SimpleHttpServer.java

# Expose the port that the application is running on
EXPOSE 5000

# Command to run the Java application
CMD ["java", "SimpleHttpServer"]
