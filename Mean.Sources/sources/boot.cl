mod std;

impl std.ops.Add for int
{
    type Output = int;

    fn add(self, other: int) -> Output { self + other }
}

fn printdensity(d: int)
{
    if d > 8 {
        1
    } else {
        4
    }
}

