extern
{
    fn println();
    fn printlnd(num :double);
    fn putchar_f64(num :double);
    fn putchar_i64(num :int);
}

struct Complex
{
    re: double;
    im: double;
}

fn compare(x :int, y :int) -> int
{
    if x > y
        {1}
    else if x < y 
        {-1}
    else
        {0}
}

fn add(x :string, y :string) -> string
{
    "a\\b\"c"
}

fn printdensity(d :int)
{
    if d > 8 {
        putchar_i64(32)     // 32 => ASCII Space
    } else if d > 4 {
        putchar_i64(46)     // 46 => ASCII '.'
    } else if d > 2 {
        putchar_i64(43)     // 43 => ASCII '+'
    } else {
        putchar_i64(42)     // 43 => ASCII '*'
    }
}


fun mandelconverger(real :double, imag :double, iters :int, creal :double, cimag :double) -> int
{
    if (iters > 255) | (real*real + imag*imag > 4.0)
    {
        iters
    }
    else
    {
        mandelconverger( real*real - imag*imag + creal
                       , 2.0*real*imag + cimag
                       , iters+1
                       , creal
                       , cimag
                       )
    }
}

fun mandelconverge(real :double, imag :double) -> int
{
    mandelconverger(real, imag, 0, real, imag);
}

fun mandelhelp(xmin :double, xmax :double, xstep :double,   ymin :double, ymax :double, ystep :double)
{
    for y = ymin, y < ymax, ystep
    {
        for x = xmin, x < xmax, xstep 
        {
            printdensity(mandelconverge(x,y))
        };
        putchar_i64(10)
    }
}

fun mandel(realstart :double, imagstart :double, realmag :double, imagmag :double)
{
  mandelhelp(realstart, realstart+realmag*67.0, realmag, imagstart, imagstart+imagmag*37.14285, imagmag)
}

fun printstars(n :int)
{
    for i = 1, i < n, 1
    {
    putchar_i64(42)  // ASCII 42 = '*'
    }
}

fun MAIN()
{
    mandel(-2.3, -1.3, 0.05, 0.07);

    println();
    printstars(68);
    println();

    printlnd(100.0);
    //printlnd(compare(1, 2));
    //printlnd(compare(2, 1));
    //printlnd(compare(1, 1));
}
