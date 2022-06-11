function compra(parcela, valor)
{
    let venda = valor * parcela;
    let msg = 'Sua compra de R$ ' + venda + ' em ' + parcela + 'X de R$ ' + valor + ' foi concluida!';
    return msg;
}

let x = compra(10, 120);
console.log(x);