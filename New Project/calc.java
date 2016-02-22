import java.util.Scanner;
public class cal {
    public static void main(String[] args){
        Scanner in=new Scanner(System.in);
        System.out.println("Enter two integers and operation");
        System.out.println("Operations are + - * / ^ and !");
        System.out.println("Enter 0 as operation to end program ");
        int x,y;
        String s;
        while(true){
            x=in.nextInt();
            y=in.nextInt();
            s=in.next();
            if(s.equals("0"))System.exit(0);
            System.out.println(op(x,y,s));
        }
    }
    static int fct(int x){
        if(x<1){
            System.out.println("input must be grater than 1");
            return -1;
        }
        if(x==1)return x;
        return x*fct(x-1);
    }
    static double op(int x,int y,String o){
        switch (o){
            case "+":return x+y;
            case "-":return x-y;
            case "*":return x*y;
            case "/":if(y==0){
                        System.out.println("can't devide by zero");
                        return -1;
                    }
                    else return x/y;
            case "!":return fct(x);
            case "^":return pow(x,y);
            default :System.out.println("operation not supported");
        }
        return -1;
    }
    static int pow(int x,int y){
        if(y<0){
            System.out.println("negative power not supported");
            return -1;
        }
        int ans=x;
        for(int i=1;i<y;i++)
            ans*=x;
        return ans;
    }      
}
