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
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '18:43 13.09.2014'
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '18:43 13.09.2014'
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '18:43 13.09.2014'
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '18:43 13.09.2014'
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '18:43 13.09.2014'
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '18:43 13.09.2014'
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '18:43 13.09.2014'
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '18:43 13.09.2014'
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '18:43 13.09.2014'
		},
		{
			name: 'Илья Чернышов',
			img: 'u8.png',
			address: 'г.Москва, ул. Профсоюзная 117',
			time: '18:43 13.09.2014'
		}
	];

	res.render('index.html', {
		stats: stats,
		feed: feed
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
		code: code
	});

});

module.exports = router;
