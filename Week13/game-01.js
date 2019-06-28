let x = 100, y = 100, width, height, radius = 10;
let ctx;
let dx = 3.5, dy = 2.7;

window.onload = function() {
	//to verify that this file was loaded
	//alert("This is only the begining!");
	console.log( "This also works!" );

	//first find the canvas element in the browser
	let canvas = document.getElementById( "myCanvas" );
	width = canvas.width;                //store the width for later use
	height = canvas.height;              //store the height for later use
	ctx = canvas.getContext( "2d" );     //get the context

	gameLoop();
}

function gameLoop() {
	x += dx; 
	y += dy;

	ctx.clearRect(0, 0, width, height);
	drawBall();

	requestAnimationFrame(gameLoop);
}

function drawBall() {
	ctx.beginPath();  
	ctx.arc( x, y, radius, 0, Math.PI * 2 );   
	ctx.fillStyle = "#993322";     
	ctx.fill();                    
	ctx.closePath();

}