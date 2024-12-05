'use strict';
const switcher = document.querySelector('.btn'); //function use CSS selectors

switcher.addEventListener('click', function(){
    document.body.classList.toggle('light-theme');
    document.body.classList.toggle('dark-theme')
    // toggle method modifies the <body> element's class attribute.

    const className = document.body.className;
    if(className == "light-theme") {
        this.textContent = "Dark";
    } else {
        this.textContent = "Light";
    }

    console.log('current class name: ' + className);

})