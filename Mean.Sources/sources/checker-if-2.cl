extern putchar_i64(num :int);

fun print(d :int)
{
    if d > 8 {
        putchar_i64(32)     # 32 => ASCII Space
    } else if d > 4 {
        putchar_i64(46)     # 46 => ASCII '.'
    } else if d > 2 {
        putchar_i64(43)     # 43 => ASCII '+'
    } else {
        putchar_i64(42)     # 43 => ASCII '*'
    }
}

print(5);

