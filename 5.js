function salario(sal, bonus, desc)
{
    let a = (bonus * 100) /10;
    let b = sal + a;
    let c = b - desc;
    return c;
}
let x = salario(1000, 10, 300);
console.log(x);