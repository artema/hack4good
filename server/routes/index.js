//index.js

var express = require('express');
var router = express.Router();

router.get('/', function(req, res){

	var stats = {
		my: 17,
		moscow: 163,
		world: 122675
	};

	var feed = [
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'Москва, Серебряническая набережная 29',
			time: '18:43 13.09.2014',
			position: ['55.750643','37.653133']
		},
		{
			name: 'Анатолий Фролов',
			img: 'u65.png',
			address: 'Санкт-Петербург, Черноморский пер. 4',
			time: '18:08 13.09.2014',
			position: ['59.938067','30.308358']
		},
		{
			name: 'Zo Thura',
			img: 'u73.png',
			address: 'Москва, ул. Неглинная 20',
			time: '17:03 13.09.2014',
			position: ['55.766138','37.621860']
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '16:33 13.09.2014',
			position: ['55.629801','37.518704']
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 116',
			time: '18:43 13.09.2014',
			position: ['55.629801','37.518704']
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 115',
			time: '18:43 13.09.2014',
			position: ['55.629801','37.518704']
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 114',
			time: '18:43 13.09.2014',
			position: ['55.629801','37.518704']
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 113',
			time: '18:43 13.09.2014',
			position: ['55.629801','37.518704']
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 113',
			time: '18:43 13.09.2014',
			position: ['55.629801','37.518704']
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 112',
			time: '18:43 13.09.2014',
			position: ['55.629801','37.518704']
		}
	];

	res.render('index.html', {
		stats: stats,
		feed: feed,
		pretty: true
	});
});

router.get('/code', function(req, res){
	var code = req.query.value;

	if (!code) {
		res.status(400);
	  res.end();
		return;
	}

	res.render('code.html', {
		code: code,
		pretty: true
	});

});

module.exports = router;
