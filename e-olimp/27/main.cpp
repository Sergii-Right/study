#include <bitset>
#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{

    std::bitset<32>x;
    int l = 0;
    while (l < 59){
//    scanf("%ld",&x);
        x = l;
    unsigned short size = 0, count_one = 0, count_zero = 0, ur = 0, check = 0,
            one_left = 0, one_right = 0, iter_left = 0, iter_right = 0;
    std::cout << x << std::endl;
    for (int i = x.size() - 1; i >= 0;i--)
    {
        if(x[i] == 0)
            size++;
        else
        {
            size = (x.size() > size) ? x.size() - size : size - x.size();
            break;
        }
    }
//    std::cout << x << std::endl;
    for (int i = 0, j = size - 1; i <= size - 1; i++, j--)
    {
        if(iter_left == 0)
        {
            if (x[i] == 1)
                one_left++;
            else
            {
                iter_left = 1;
            }
        }
        if(iter_right == 0)
        {
            if (x[j] == 1)
                one_right++;
            else
            {
                iter_right = 1;
            }
        }
    }
    one_left += one_right;
    for (int i = size - 1; i >= 0 ; i--)
    {
        if (one_left--)
        {
            x[i] = 1;
        }
        else
            x[i] = 0;

    }
//    for (int i = 0; i <= size - 1; ++i)
//    {
//        if(x[i] == 1)
//            count_one++;
//        else {
//            if(count_one>=1&&i<=size-3&&x[i+1] == 1 && x[i+2] == 0 )
//                check++;
//            count_zero++;
//        }
//    }
//    if (check > 0)
//    {
//        if (count_zero != check){
//            ur = 1;
//            for (int i = 1; i < count_zero; i++)
//            {
//                ur = ur * 2;
//            }
//        }
//    }

//    for (int i = size - 1; i >= 0; i--)
//    {
//        if (count_one > 0)
//        {
//            x[i] = 1;
//            count_one--;
//        }
//        else
//            x[i] = 0;
//    }
    std::cout << x << std::endl;
    printf("i = %d; my = %ld; my_test = %ld; test = ",l,x.to_ulong(),x.to_ulong() - ur);


//        cin>>K;
    int K=0, N=0, i=0, j=0, i_max=0, a[31][31], fl=0;
    K = l;
        while(K>0)
        {
            a[0][N++]=K%2;
            K/=2;
        }
        for(i=1; i<N; i++)
        {
            for(j=0; j<N; j++)
                a[i][j]=a[0][(j+i)%N];
            fl=0;
            for(j=N-1; j>=0 && fl==0; j--)
            {
                if(a[i_max][j]>a[i][j])
                    fl=1;
                if(a[i_max][j]<a[i][j])
                    fl=2;
            }
            if(fl==2) i_max=i;
        }
        j=1;
        for(i=0; i<N; i++)
        {
            K+=a[i_max][i]*j;
            j*=2;
        }
        cout << K << endl;
        l++;
    }

    return 0;
}
