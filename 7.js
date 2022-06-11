function parque (tempereatura)
{
    let sair = tempereatura >=23 && tempereatura <=30;
    return sair;
}

let x = parque(20);
console.log(x);