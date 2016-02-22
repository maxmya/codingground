operation = input ('Enter operation 1,2,3 or 4 \nWhere 1 is Addition \n2 is multblication  \n3 is divison \nAnd 4 is factorial: ')
number_one = input ('Enter first number : ') 
if operation != 4 : 
 number_two = input ('Enter second number : ') 
 
 
def factorial(n):
    num = 1
    while n >= 1:
        num = num * n
        n = n - 1
    return num
 
 
 
if operation ==1:       
        print ("A + B = " + str (number_one + number_two) ) 
elif operation ==2: 	
	    print ("A x B = " + str (number_one * number_two) ) 
elif operation == 3 : 
	 if number_two != 0:   
	    print ("A x B = " + str (number_one / number_two)) 
	 else:
	    print ("cannot devide by 0 ")   
elif  operation ==4:
  print("factorial is " +str(factorial(number_one)))
  
 
