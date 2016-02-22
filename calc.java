import java.util.Scanner;
public class cal {
    public static void main(String[] args){
        Scanner in=new Scanner(System.in);
        System.out.println("Enter two integers and operation");
        System.out.println("Operations are + - * / and ^");
        System.out.println("Enter 0 as operation to end program ");
        int x,y;
        String s;
        while(true){
            x=in.nextInt();
            y=in.nextInt();
            s=in.next();
            if(s.equals("0"))System.exit(0);
            if(!s.equals("^"))
                System.out.println("Answer is "+op(x,y,s));
            else 
                System.out.println("Answer is "+pow(x,y));
        }
    }
    static double op(int x,int y,String o){
        switch (o){
            case "+":return x+y;
            case "-":return x-y;
            case "*":return x*y;
            case "/":return x/y;
        }
        return 0;
    }
    static int pow(int x,int y){
        int ans=x;
        for(int i=1;i<y;i++)
            ans*=x;
        return ans;
    }      
}
