function filme(id1, id2, cls1, cls2)
{
    let pode = id1 >= cls1 && id2 >= cls2 && id2 >= cls1 && id2 >= cls2;
    return pode;
}

let x = filme(14, 14, 12, 12);
console.log(x);