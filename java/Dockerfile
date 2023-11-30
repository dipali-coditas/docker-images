FROM openjdk:11-slim
WORKDIR /app
COPY . /app/
RUN javac SimpleHttpServer.java
EXPOSE 5000
CMD ["java", "SimpleHttpServer"]
