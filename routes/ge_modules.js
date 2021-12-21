var express = require('express');
var router = express.Router();

const mEC7Bearing = require('../ge_modules/mEC7_Bearing');

router.get('/EC7_Bearing/calc_EC7_D1', (req, res) => {
  var datetime = new Date().toLocaleString();
  var s = JSON.stringify(req.query)
  var ip = req.header('x-forwarded-for') || req.socket.remoteAddress;
  console.log(`datetime: '${datetime}', func: 'calc_EC7_D1 (${s})', ip:'${ip}'`);
  var r = mEC7Bearing.calc_EC7_D1_data(req.query)
  res.json(r);
})
router.get('/EC7_Bearing/calc_EC7_D2', (req, res) => {
  var datetime = new Date().toLocaleString();
  var s = JSON.stringify(req.query)
  var ip = req.header('x-forwarded-for') || req.socket.remoteAddress;
  console.log(`datetime: '${datetime}', func: 'calc_EC7_D2 (${s})', ip:'${ip}'`);
  var r = mEC7Bearing.calc_EC7_D2_data(req.query)
  res.json(r);
})
module.exports = router;
