
#include <iostream>
using namespace std;
int main()
{
    double a, b;
    cin >> a >> b;
    //C++은 cout 을 통한 출력은 6자리로 고정되기 때문에 강제로 자리수를 바꿔줘야함 문제가 9자리까지 요구 
    cout << fixed;
    cout.precision(9);
    cout << a / b << endl;
}


