function filme(idade1, idade2, classificacao)
{
    let assistir = idade1 >= classificacao && idade2 >= classificacao;
    return assistir;
}

let x = filme(18, 15, 18);
console.log(x);