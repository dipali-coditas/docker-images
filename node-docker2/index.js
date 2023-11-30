const express = require('express');
const path = require('path');
const mysql = require('mysql2');

const app = express();
const port = parseInt(process.env.PORT) || 3200;

// Configure your Cloud SQL database connection details
const dbConfig = {
  host: '34.93.42.63',
  user: 'root',
  password: 'root',
  database: 'nodeproject'
};

// Create a connection pool
const pool = mysql.createPool(dbConfig);

// Serve index.html as the default route
app.get('/', (req, res) => {
  res.sendFile(path.join(__dirname, 'public', 'index.html'));
});

app.get('/root', (req, res) => {
  res.send('* Hello, User! Would you like to see past entries on your web? Please visit Entries Section *  ' + port);
});

// Route to fetch entries from the Cloud SQL database
app.get('/entries', (req, res) => {
  // Use the connection pool to execute a query
  pool.query('SELECT * FROM emp', (error, results) => {
    if (error) {
      console.error(error);
      res.status(500).json({ error: 'Internal Server Error' });
    } else {
      // Send the results as JSON
      res.json(results);
    }
  });
});

app.use(express.static(path.join(__dirname, 'public')));

app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});
