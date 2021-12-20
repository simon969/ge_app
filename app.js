
// https://docs.microsoft.com/en-us/learn/modules/build-web-api-nodejs-express/3-exercise-create-app
// npm init -y
// npm install express

// https://stackoverflow.com/questions/43150051/how-to-enable-cors-nodejs-with-express
// npm install cors --save

const cors = require('cors');
const express = require('express');
const app = express();
const port = 3000;
const mEC7Bearing = require('./ge_modules/mEC7_Bearing');

app.use(cors());

const products = [
  {
    id: 1,
    name: "Ivanhoe",
    author: "Sir Walter Scott",
  },
  {
    id: 2,
    name: "Colour Magic",
    author: "Terry Pratchett",
  },
  {
    id: 3,
    name: "The Bluest eye",
    author: "Toni Morrison",
  },
  ];
  
  app.get('/', (req, res) => res.send('Hello API!'));
  
  app.get('/products/:id', (req, res) => {
    res.json(products.find(p => p.id === +req.params.id));
  });
  
  app.get('/products', (req, res) => {

    const page = +req.query.page;
    const pageSize = +req.query.pageSize;

    if (page && pageSize) {
      const start = (page - 1) * pageSize;
      const end = start + pageSize;
      res.json(products.slice(start, end));
    }   else {
    res.json(products);
    }
  })

  app.get('/EC7_Bearing/calc_EC7_D1', (req, res) => {
    var datetime = new Date().toLocaleString();
    console.log(`${datetime} recieved request for calc_EC7_D1 (${res.query})`);
    var r = mEC7Bearing.calc_EC7_D1_data(req.query)
    res.json(r);
  })
  app.get('/EC7_Bearing/calc_EC7_D2', (req, res) => {
    var datetime = new Date().toLocaleString();
    console.log(`${datetime} recieved request for calc_EC7_D2 (${res.query})`);
    var r = mEC7Bearing.calc_EC7_D2_data(req.query)
    res.json(r);
  })
  

  app.listen(port, () => console.log(`Example app listening on port ${port}!`));