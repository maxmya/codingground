package main
import "fmt"

func main(){
	fmt.Println("Enter two integers and operation")
	fmt.Println("1-addition 2-substaction 3-multiplication 4-devision 5-raise to power ")
	fmt.Println("type 0 as an operation to end program")
	var a, b, s int
	fmt.Scanf("%d %d %d", &a , &b , &s)
	for {
		switch s {
			case 1 :fmt.Println(a + b)
			case 2 :fmt.Println(a - b)
			case 3 :fmt.Println(a * b)
			case 4 :if b == 0 {
						fmt.Println("Can't devide by zero !")
					} else {
						fmt.Println(a / b)
					}
			case 5 :if b < 0 {
						fmt.Println("negative power not supported")
					} else {
						fmt.Println(pow(a , b))
					}
		}
		fmt.Scanf("%d %d %d", &a , &b , &s)
		if s == 0 {break}
	}
}
func pow(a int, b int)int {
	var c int =1
	for i := 1; i<=b; i++ {
		c*=a;
	}
	return c;
}
