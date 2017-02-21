$(document).ready(function() {

    var arrowBounce = function() {
    	$(".arrow").effect( "bounce", {times:3}, 1000 );
    };
	setInterval(arrowBounce, 1500);

});