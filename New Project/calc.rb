# Hello World Program in Ruby
while true do 
	puts "1-add 2-substrac 3-multiply 4-devide 5-num1 power num2 6-quit"
	op = gets.to_i
	if op == 6
   		break
	end
	puts "Enter num1"
	num1 = gets.to_f
	puts "Enter num2"
	num2 = gets.to_f
	case op
	when 1
   		puts "#{num1} + #{num2} = #{num1 + num2}" 
	when 2 
        	puts "#{num1} - #{num2} = #{num1 - num2}"
    	when 3 
    		puts "#{num1} * #{num2} = #{num1 * num2}" 
	when 4
	    if num2 != 0
        	puts "#{num1} / #{num2} = #{num1 / num2}" 
        else
            	puts "cannot devide by 0 !"
        end
	when 5
    		puts "#{num1} ^ #{num2} = #{num1 ** num2}" 
	end

end

