extern println();
extern putchar_i64(num :int);

fun putstar()
{
    putchar_i64(42)
}

fun looper0()
{
    for i = 0.0, i < 10.0, 1.0
    { 
        putstar();
    };
    println()
}

fun looper1(xmin :double, xmax :double, xstep :double)
{
    for x = xmin, x < xmax, xstep 
    { 
        putstar();
    };
    println()
}

fun looper2(xmin :double, xmax :double, xstep :double, ymin :double, ymax :double, ystep :double)
{
    for y = ymin, y < ymax, ystep
    {
        for x = xmin, x < xmax, xstep 
        { 
            putstar();
        };
        println()
    }
}

looper0();
looper1(1.0, 14.0, 2.0);
looper2(1.0, 14.0, 2.0, 1.0, 10.0, 2.0);

