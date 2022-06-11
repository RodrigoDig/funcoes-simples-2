function mes(semestre)
{
    let sem = semestre == "janeiro" || semestre == "fevereiro" || semestre == "março" || semestre == "abril" || semestre == "maio" || semestre == "junho";
    return sem;
}

let x = mes("março");
console.log(x);