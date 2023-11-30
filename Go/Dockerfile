# # Stage 1: Build the Go application
# FROM golang:1.21.4 AS builder

# WORKDIR /app
# COPY . .
# RUN CGO_ENABLED=0 GOOS=linux go build -a -installsuffix cgo -o main .

# # Stage 2: Use a minimal base image
# FROM alpine:latest

# WORKDIR /app

# # Copy the binary from the builder stage to the final stage
# COPY --from=builder /app/main .

# # Expose the port the app runs on
# EXPOSE 3000

# # Command to run the executable
# CMD ["./main"]

# # Stage 1: Build the statically linked Go application

# FROM golang:1.21.4 AS builder

# WORKDIR /app
# COPY . .
# RUN CGO_ENABLED=0 GOOS=linux go build -a -installsuffix cgo -o main -ldflags="-s -w" .

# # Stage 2: Use a minimal base image
# FROM alpine:latest

# WORKDIR /app

# # Copy the binary from the builder stage to the final stage
# COPY --from=builder /app/main .

# # Expose the port the app runs on
# EXPOSE 3000

# # Command to run the executable
# CMD ["./main"]

FROM golang:1.21-alpine
WORKDIR /app
COPY . .
EXPOSE 3000
CMD [ "go", "run", "main.go" ]

