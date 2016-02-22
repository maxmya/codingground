#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    int n, m, answer;
    string error_type;
    char c;
    while(cin >> n >> c >> m && (n || m)){
        error_type = "";
        switch(c){
        case '+':
            answer = n + m;break;
        case '-':
            answer = n - m;break;
        case '*':
            answer = n * m;break;
        case '/':
            if(m)answer = n / m;
            else error_type = "Error dividing by 0\n";
            break;
        case '^':
            answer = 1;
            if(m < 0)error_type = "-ve power is not supported yet\n";
            else
                for(int i = 0; i < m; i++)answer *= 2;
            break;
        default:
            error_type = "This operation is invalid or not supported yet\n";
        }
        if(!error_type.empty())printf(&error_type[0]);
        else printf("%d\n", answer);
    }
    return 0;
}
