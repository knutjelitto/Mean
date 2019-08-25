mod core
{
    mod num
    {
    
    }

    mod ops
    {
        pub trait Add<Rhs=Self>
        {
            type Output = Self;

            fn add(self, rhs: Rhs) -> Self.Output;
        }
    }

    mod fmt
    {
        pub trait Debug<T>
        {
            fn debug(self) -> string;
        }

        impl fmt.Debug for long
        {
            fn debug(value: long) -> string
            {
        
            }
        }
    }
}

pub struct Complex<T>
{
    pub re: T;
    pub im: T;
}


use core.ops.{Add, Sub, Mul, Div, Rem, Neg};

impl Complex
{
    pub fn new(re: double, im: double) -> Complex
    {
        Complex { re: re, im: im }
    }

    pub fn i() -> Complex
    {
        Self.new(0, 1)
    }
}

impl Add<Complex> for Complex
{
    type Output = Complex;

    fn add(self, other: Complex) -> Complex
    {
        Complex.new(self.re + other.re, self.im + other.im)
    }
}

fn Main()
{
}

