<html> 
<head>
    <script type ="text/javascript"> 
    
    var r , c ; 
        
        r =  window.prompt("Enter the the first number " ) ; 
        var num1 = parseInt(r) ; 
        c =  window.prompt("Enter the the second number " ) ; 
        var num2 = parseInt(c) ; 

		//Fatorial
		function factorial(num1)
			{
    
 		   if (num1 < 0) {
  			      return -1;
 		   }
  			  
    else if (num1 == 0) {
        return 1;
    }
    var tmp = num1;
    while (num1-- > 2) {
        tmp *= num1;
    }
    return tmp;
}

var result = factorial(num1);
	document.write( "Factorial of num 1 is :" +result+"</br>");
        document.write("multiplication  = "  + (num1*num2) + "</br>");
        document.write("Sum  = "  +  (num1+num2) + "</br>");
        document.write("substraction  = "  + (num1-num2) + "</br>");
        document.write("Division  = "  + (num1/num2) + "</br>");
       
    

</script>
    
    </head>
</html>
