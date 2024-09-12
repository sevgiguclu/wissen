//form nesnesi
const form = document.querySelector('form');

//input text nesnesi
const input = document.querySelector('#txtTaskName');

//button addNewTask nesnesi
const btnAddNewTask = document.querySelector('#btnAddNewTask');

//ul nesnesi
const taskList = document.querySelector('#task-list');

//delete all button
const btnDeleteAll = document.querySelector('#btnDeleteAll');

//tüm elemenları sil
btnDeleteAll.addEventListener('click', deleteAllItems);

//listeden eleman silme
taskList.addEventListener('click', deleteItem);

//yeni task ekleme
form.addEventListener("submit", addNewItem);

function deleteAllItems(e) {
    confirm("tüm elemenları silmek istediğinize emin misiniz ?")
    {
        while (taskList.firstChild) {
            taskList.removeChild(taskList.firstChild);
        }
    }
}
function deleteItem(e) {
    if (e.target.className === 'fas fa-times') {
        if (confirm("Task listeden çıkarılsın mı?")) {
            e.target.parentElement.parentElement.remove();
        }
    }
}
function addNewItem(e) {
    if (input.value == '') {
        alert("Bir içerik giriniz..");
    }
    else {
        const li = document.createElement("li");
        li.className = "list-group-item list-group-item-secondary";
        li.appendChild(document.createTextNode(input.value));

        const a = document.createElement("a");//a elemnti yaratıldı
        a.classList = "delete-item float-right";
        a.setAttribute('href', '#');
        a.innerHTML = '<i class="fas fa-times"></i>';//çarpı ikonu eklendi
        li.appendChild(a);

        taskList.appendChild(li);
        alert(taskList.childElementCount);
        e.preventDefault();
    }
}


