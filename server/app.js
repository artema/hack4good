// server.js

	var express = require('express');
	var app = module.exports = express();

	// configuration =================

	app.use(require('body-parser').json());
	app.use(require('body-parser').urlencoded({extended: true}));
	app.use(require('body-parser').text());

	app.engine('.html', require('ejs').renderFile);
	app.engine('.manifest', require('ejs').renderFile);
	app.set('views', __dirname + '/views');
	app.set('view engine', 'jade');
	app.set('view options', { pretty: true });

	app.enable('trust proxy');

	// routes ======================================================================

	app.use(require(__dirname + '/routes/index'));
	app.use(express.static(__dirname + '/../public/'));
