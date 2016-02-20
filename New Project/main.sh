##!/bin/bash
         
      printf "Pleas enter operation\n1 addition\n2 division\n3 multplication\n4 power\n"
      read operation 




 if [[ operation -eq 1 ]]; then

      printf "Enter first number: \n"
      read numberOne 
      printf "Enter secound number: \n"
      read numberTwo 
      printf "sum is "
      echo $[numberOne+numberTwo]  

  elif [[ operation -eq 2 ]]; then
      printf "Enter first number: \n"
      read numberOne 
      printf "Enter secound number: \n"
      read numberTwo 
      if [[ numberTwo -eq 0 ]]; then
      	 printf "cannot division by 0\n"
      else 
         printf "division is "
         echo "scale=2; $numberOne/$numberTwo" | bc
      fi
   elif [[ operation -eq 3 ]]; then
      printf "Enter first number: \n"
      read numberOne 
      printf "Enter secound number: \n"
      read numberTwo 
      printf "A X B is " 
      echo "scale=6; $numberOne*$numberTwo" | bc
   elif [[ operation -eq 4 ]]; then
   	 printf "Enter number: \n"
      read numberOne 
      printf "Enter power: \n"
      read numberTwo
      power=$numberOne
      for (( i = 1  ; i < $numberTwo ; i++ )); 
      do((power= power * numberOne));
      done
      printf "$numberOne power $numberTwo is "
      echo $power
      
else
 printf "Enter valid Operation\n"       	    
fi 
