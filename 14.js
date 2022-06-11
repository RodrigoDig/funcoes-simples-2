function filme(idade, classificacao)
{
    let pode = idade >= classificacao;
    return pode;
}
let x = filme(10, 12);
console.log(x);