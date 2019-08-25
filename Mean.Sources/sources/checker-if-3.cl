extern
{
    fun printlni(num :int);
}

fun compare(x :int, y :int) : int
{
    if x > y
        {1}
    else if x < y 
        {-1}
    else
        {0}
}

fun MAIN()
{
    printlni(compare(1, 2));
    printlni(compare(2, 1));
    printlni(compare(1, 1));
}

