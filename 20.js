function signo(mes, dia)
{
    let verificar = mes == "setembro" && dia >= 23 && dia <= 31;
    return verificar; 
}
let x = signo("setembro", 25);
console.log(x);