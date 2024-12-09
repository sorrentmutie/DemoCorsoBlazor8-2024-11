window.miaSomma = (a, b) => a + b;


window.mioFetch = () => {
    fetch('https://jsonplaceholder.typicode.com/todos/1')
        .then(response => response.json())
        .then(json => {
            console.log(json);
        });
}

window.invocaCSharp = () => {
    DotNet.invokeMethodAsync('DemoBlazorLezione2.WASM', 'MiaSommaSpeciale', 1, 2)
      .then(r => console.log(r));
}

window.sayHello = (helloHelper) => {
    helloHelper.invokeMethodAsync('SayHello')
        .then(saluto => console.log(saluto)); 
}


let myModal;
window.showModal = (id) => {
    myModal = new bootstrap.Modal(document.getElementById(id));
    myModal.show();
}

window.hideModal = () => { 
    if (myModal) {
        myModal.hide();
    }
}

