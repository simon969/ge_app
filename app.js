
// https://docs.microsoft.com/en-us/learn/modules/build-web-api-nodejs-express/3-exercise-create-app
// npm init -y
// npm install express

// https://stackoverflow.com/questions/43150051/how-to-enable-cors-nodejs-with-express
// npm install cors --save

const cors = require('cors');
const express = require('express');
const app = express();


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
    var s = JSON.stringify(req.query)
    var ip = req.header('x-forwarded-for') || req.socket.remoteAddress;
    console.log(`datetime: '${datetime}', func: 'calc_EC7_D1 (${s})', ip:'${ip}'`);
    var r = mEC7Bearing.calc_EC7_D1_data(req.query)
    res.json(r);
  })
  app.get('/EC7_Bearing/calc_EC7_D2', (req, res) => {
    var datetime = new Date().toLocaleString();
    var s = JSON.stringify(req.query)
    var ip = req.header('x-forwarded-for') || req.socket.remoteAddress;
    console.log(`datetime: '${datetime}', func: 'calc_EC7_D2 (${s})', ip:'${ip}'`);
    var r = mEC7Bearing.calc_EC7_D2_data(req.query)
    res.json(r);
  })

  const port = process.env.PORT || 3000
// const http_port = 80;
 
 // app.listen(port, () => console.log(`Example app listening on port ${port}!`));
 
 // Start http and https servers

  //var https = require('https')
  //const https_port = 433;
  // load certificates
  // const options = {
  //   key: fs.readFileSync('key.pem'),
  //   cert: fs.readFileSync('cert.pem')
  // };
  // https.createServer(options, app).listen(443)
  // https.createServer(app).listen(https_port, () => console.log(`ge-app https listening on port ${https_port}`))
  
  console.log(process.env.PORT)
  
  var http = require('http')
  // app.listen(http_port, () => console.log(`Example app listening on port ${http_port}!`));
  http.createServer(app).listen(port, () => console.log(`ge-app listening on port ${port}`))
 
  
  