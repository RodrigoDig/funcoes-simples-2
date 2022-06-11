function venda (mdo, pqn, gg)
{
    let calcular = mdo * 15 + pqn * 13.50 + gg * 17.50;
    return calcular; 
}

let x = venda(2, 2, 1);
console.log(x);