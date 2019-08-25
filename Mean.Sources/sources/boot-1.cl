type sbyte = i8;
type short = i16;
type int = i32;
type long = i64;

type byte = u8;
type ushort = u16;
type uint = u32;
type ulong = u64;

type double = f64;
type single = f32;

pub trait Add<Rhs=Self>
{
    type Output = Self;

    fn add(self, rhs: Rhs) -> Output;
}

impl Add for i64
{
    fn add(self, rhs: Self) -> Self
    {
        self + rhs
    }
}

fn printdensity(d :i64)
{
    if d > 8 {
        1
    } else {
        4
    }
}

