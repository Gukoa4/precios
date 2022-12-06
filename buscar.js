colecion = document.getElementsByClassName('md_view');
arrayC = Array.from(colecion, item => 
    {
        let el = item.firstChild.firstChild; 
        if(el.tagName=='DIV') return el.textContent
    
    });
arrayC = arrayC.filter((elem)=>(elem!==undefined))

console.log(arrayC);

let duplicados = [];
const tempArray = [...arrayC].sort();
//algoritmo
for (let i = 0; i <tempArray.length; i++){
    if (tempArray[i+1] === tempArray[i]){
        duplicados.push(tempArray[i]);
    }
}
if(duplicados.length>0){console.log(`Se encontraron ${duplicados.length} duplicados`,duplicados)}
else {console.log('no hay duplicados')}

/*[
    
]*/

//buscar duplicado
