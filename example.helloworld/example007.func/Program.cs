int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 434;
int w2 = 4;
int e4 = 354;

int r3 = 33;
int t6 = 4555;
int g7 = 432;

int c9 = 45;
int u5 = 33;
int y9 = 22;

int max1 = Max(a1, w2, e4);
int max2 = Max(r3, t6, g7);
int max3 = Max(c9, u5, y9);
int max = Max(max1, max2, max3);



Console.WriteLine(max1);
