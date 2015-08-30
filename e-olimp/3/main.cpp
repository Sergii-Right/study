#include <stdio.h>
#include <math.h>

int main()
{
    int n,i,di,l,k,m,v,h;
    int s,s1,s2,s3;
    scanf("%d",&n);
    i = (int)(pow(n,1 / 3.) + 0.5);
    if ((i * i) > (int)(n / 2. + 0.5))
        --i;

    if (n == 0)
        s = 0;
    else if (i > 1)
    {
        di = i * i;
        l = n / di;
        k = n % di;
        s3 = 0;
        s1 = 4 + 8 * (i + i - 1) + 5 * (i - 1) * (i - 1);
        s2 = (8 + 5 * (i + i - 2) + 3 * (i - 1) * (i - 1)) * (l - 1);
        if(k > 0)
        {
            s3 = 8;
            --k;
        }
        m = 0; h = 1;
        while(k > 0)
        {
            v = (h - 1) / 2;
            if(m != 0 && m % 2 == 0)
            {
                while(v > 0 && k > 0)
                {
                    s3 += 3;
                    --v;
                    --k;
                }
                m = 1;
                continue;
            }
            else {
                s3 += 5;
                ++m;
                --k;
                ++h;
            }
        }
        s = s1 + s2 + s3;
    }
    else if(n != 0)
    {
        s = 12;
        --n;
        m = 0;
        while(n > 0)
        {
            if (m != 0 && m % 2 == 0)
            {
                s += 5;
                m = 0;
            }
            else {
                s += 8;
            }
            ++m;
            --n;
        }
    }
    printf("%d",s);
    return 0;
}
