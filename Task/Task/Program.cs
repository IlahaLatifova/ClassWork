int a = 5;
int b = 6;
int m = 7;
int n = 3;
int k = 2;
//a-qapinin uzunlugu
//b-qapinin eni
//m-skafin eni
//n-skafin uzunlugu
//k-skafin hundurluyu

bool Yemek(int a, int b,int m,int n, int k)
{
    if ((a>m && b>n) || ((b > m) && (a > n)))
        return true;
    else if((a>m && b>k) || ((b > m) && (a > k))) { return true; }
    else if ((a > n && b > k) | ((b > n) && (a > k))) { return true; }
    return false;
}