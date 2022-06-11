function venda ( pqn, mdo, gg, cupom )
{
    let calcular = pqn * 13.50 + mdo * 15 + gg * 17.50;
    let total = calcular * cupom / 100; 

    let final = calcular - total;
    return final;
}

let x = venda(2, 2, 1, 10);
console.log();(x);