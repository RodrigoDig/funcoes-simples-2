function reprovou(nota1, nota2, nota3)
{
    let a = (nota1 + nota2 + nota3) /3;
    let b = a >=5;
    return b; 
}
let x = reprovou(5, 2, 3);
console.log(x);