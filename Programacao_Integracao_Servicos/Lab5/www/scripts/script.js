function resetContent(){
    document.getElementById("response").innerHTML = "";
    document.getElementById("forms").innerHTML = "";
}

async function openPostContent(){
    resetContent();
    var forms = document.getElementById("forms");
    var result = await fetch("post.html");
    forms.innerHTML = await result.text();
}

async function openGetContent(){
    resetContent();
    var forms = document.getElementById("forms");
    var result = await fetch("get.html");
    forms.innerHTML = await result.text();
}

async function getUser(elementId){
    var userId = document.getElementById(elementId).value;
    var resultElement = document.getElementById("response");

    try{
        const response = await fetch("/user/" + userId);
        let data = await response.json();
        data = data[0];
        console.log(data);
        if(!!data.ID){
            resultElement.innerHTML = `
                <div>Id: ${data.ID}</div>
                <div>Nome: ${data.NOME}</div>
                <div>Data de Nascimento: ${data.BIRTH_DATE.substring(0,10)}</div>
            `
        }else{
            resultElement.innerHTML = "Não encontrado"
        }
    }catch(e){
        resultElement.innerHTML = "Não encontrado"
    }
}

async function getPet(elementId){
    //TODO
    
}
