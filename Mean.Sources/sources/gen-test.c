typedef struct String_ {
    int length;
    char* bytes;
} String;

const String xxx = { 4, "xxx" };

String concat(String x, String y)
{
    return x;
}

String tester(void)
{
    String a = concat(xxx, xxx);

    return a;
}

