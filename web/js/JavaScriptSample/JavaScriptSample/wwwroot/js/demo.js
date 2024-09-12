const text = document.querySelector(".text");
console.log(text);


const input = document.createElement('input');
console.log(input);

const containers = document.querySelectorAll('.container');
containers[1].append(input);

const p = document.createElement('p');
p.innerHTML = "Helolooooo js ";
containers[0].append(p);

const users = ['John Doe', 'Sevgi Güçlü', 'Berkay Fota', 'Arzu Güçlü'];
const ul = document.querySelector('.users');

users.forEach(function (user) {
    const li = document.createElement('li');
    li.classList.add('user-item');
    li.innerHTML = user;
    ul.append(li);
});

const container = document.querySelector('.container');
container.classList.remove('wrapper');
container.style = 'background-color:green';
