#include <stdio.h>

int main()
{
    char str[10];
    short size = 0, sum = 0;

    scanf("%10s",&str);
    for (int i = 0; i< 10; i++)
    {
        if (str[i])
        {
            size++;
        }
        else break;
    }
    if(size % 2 > 0)
    {
        sum++;
    }
    for (int i = 0, j = size-1; i < size/2; i++, j--)
    {
        if(str[i] == str[j])
            sum++;
    }

    printf("%d",sum);

    return 0;
}
