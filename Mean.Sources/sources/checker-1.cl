fun Check() -> double
    where int : A
{
    x;          // path
    super::x;
    self::x;
    Self::x;
    ::x;

    1.x();      // method call

    1.x;        // field selector

    x.1;        // tuple index

    1(x);       // function call

    1[x];       // array index

    -x;         // unary -
    !x;         // unary !

    x as int;   // type cast

    x * y;
    x / y;
    x % y;
    x << y;
    x >> y;

    x & y;
    x | y;
    x ^ y;

    x == y;
    x != y;
    x < y;
    x <= y;
    x > y;
    x >= y;

    x && y;
    x || y;


    loop
    {
        return;
        return x;
        break;
        break x;
        continue;
    };

    'exit loop
    {
        break 'exit;
        break 'exit x;
        continue 'exit;
    };

    let x : !;

    let x : ();

    let x;
    let mut x = 42;
    let x : int;
    let x : int = 42;

    1
}

fun Main()
{
    Check();
}
