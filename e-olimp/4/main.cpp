#include <stdio.h>
#include <math.h>

int main()
{
    double x1,x2,y1,y2,r1,r2,d;
    scanf("%lf %lf %lf %lf %lf %lf",&x1,&y1,&r1,&x2,&y2,&r2);


    if (x1 == x2 && y1 == y2)
    {
        if(r1 == r2)
            printf("%d",-1);
        else
            printf("%d",0);
    }
    else
    {
        if(r1 < r2)
        {
            r1 += r2;
            r2 = r1 - r2;
            r1 -= r2;

        }
        d = sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

        if(d == r1 + r2 || d == r1 - r2)
            printf("%d",1);
        else
            if(d > r1 + r2 || d + r2 < r1)
                printf("%d",0);
            else
                printf("%d",2);
    }
    return 0;
}
