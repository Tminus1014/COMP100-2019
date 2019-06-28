let x = 100, y = 50, radius = 5, height, width;
let dx = 3.5, dy = 2.7;
let ctx;
window.onload = function() {
	//to verify that this file was loaded
	//alert("This is only the begining!");
	console.log( "This also works!" );

	let canvas = document.getElementById( "myCanvas" );
	width = canvas.width;                //store the width for later use
	height = canvas.height;              //store the height for later use
	ctx = canvas.getContext( "2d" );
	
	gameLoop();               
}


function gameLoop(){

	x += dx;
	y += dy;
	if(y > height || y < 0)
	{
	   dy *= -1;
	}
	if(x > width || x < 0)
	{
	   dx *= -1;
	}
	ctx.clearRect(0, 0, width, height);
	drawBall();
	requestAnimationFrame(gameLoop);

}

function drawBall(){
	
	ctx.beginPath();               //always start with a beginPath
	ctx.arc( x, y, radius, 0, Math.PI * 2 );   //define the rectangular region
	ctx.fillStyle = "#993322";     //sets the pen color
	ctx.fill();                    //fill the region with the requested color
	ctx.closePath();

}