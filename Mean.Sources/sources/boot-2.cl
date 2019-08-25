pub trait Add<Rhs=Self>
{
    type Output = Self;

    fn add(self, rhs: Rhs) -> Self.Output;
}

pub struct Complex<T>
{
    re: T;
    im: T;
}

impl<T> Add for Complex<T>
{
    fn add(self, rhs: Complex) -> Complex
    {
        Complex {re: self.re + rhs.re, im: self.im + rhs.im}
    }
}
