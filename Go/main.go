// main.go
package main

import (
	"net/http"
)

func main() {
	// Serve static files
	http.HandleFunc("/", func(w http.ResponseWriter, r *http.Request) {
		http.ServeFile(w, r, "static/blank.html")
	})

	// Define API endpoints
	http.HandleFunc("/login", func(w http.ResponseWriter, r *http.Request) {
		http.ServeFile(w, r, "static/login.html")
	})

	http.HandleFunc("/register", func(w http.ResponseWriter, r *http.Request) {
		http.ServeFile(w, r, "static/register.html")
	})

	// Start the server
	http.ListenAndServe(":3800", nil)
}
