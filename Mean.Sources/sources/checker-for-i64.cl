extern
{
    fun println();
    fun putchar_i64(num: int);
    fun consume_i64(num: int);
}

fun putstar()
{
    putchar_i64(42)
}

fun looper3(n :int)
{
    for i = 1, i <= (n * n * n), 1 { putstar(); consume_i64(i); }; println();

    for x = 1, x <= n, 1
    {
        for y = 1, y <= n, 1
        {
            for z = 1, z <= n, 1
            {
                putstar();
            }
        };
    };
    println();
}

fun looper0()
{
    for i = 0, i < 10, 1
    { 
        putstar();
    };
    println()
}

fun looper1(xmin :int, xmax :int, xstep :int)
{
    for x = xmin, x < xmax, xstep 
    { 
        putstar();
    };
    println();
}

fun looper2(xmin :int, xmax :int, xstep :int, ymin :int, ymax :int, ystep :int)
{
    for y = ymin, y < ymax, ystep
    {
        for x = xmin, x < xmax, xstep 
        { 
            putstar();
        };
        println();
    }
}

fun MAIN()
{
    #looper0();
    #looper1(1, 14, 2);
    #looper2(1, 14, 2, 1, 10, 2);
    looper3(4);
}

