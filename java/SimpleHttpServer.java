import com.sun.net.httpserver.HttpServer;
import com.sun.net.httpserver.HttpHandler;
import com.sun.net.httpserver.HttpExchange;

import java.io.IOException;
import java.io.OutputStream;
import java.net.InetSocketAddress;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class SimpleHttpServer {

    public static void main(String[] args) throws IOException {
        // Create an HTTP server that listens on localhost:5000
        HttpServer server = HttpServer.create(new InetSocketAddress(5000), 0);

        // Map the /login endpoint to serve login.html
        server.createContext("/login", new PageHandler("login.html"));

        // Map the /register endpoint to serve register.html
        server.createContext("/register", new PageHandler("register.html"));

        // Start the server
        server.start();

        System.out.println("Server is running on http://localhost:5000");
    }

    // Handler for serving HTML pages
    static class PageHandler implements HttpHandler {
        private final String pageName;
    
        public PageHandler(String pageName) {
            this.pageName = pageName;
        }
    
        @Override
        public void handle(HttpExchange exchange) throws IOException {
            // Set the response content type to HTML
            exchange.getResponseHeaders().set("Content-Type", "text/html");
    
            // Send the response headers
            exchange.sendResponseHeaders(200, 0);
    
            // Read the HTML file content
            String response = readPage(pageName);
    
            // Send the HTML content as the response
            OutputStream os = exchange.getResponseBody();
            os.write(response.getBytes());
            os.close();
        }
    
        private String readPage(String pageName) throws IOException {
            // Read the content of the HTML file
            Path path = Paths.get(pageName);
            return Files.readString(path);
        }
    }
    
}


//javac SimpleHttpServer.java
//java SimpleHttpServer.java
//docker build -t dipalidocker15/java:v1
//docker run -t --name java_container dipalidocker15/java:v1


