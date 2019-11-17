window.onload = function () {
    document.getElementById("first__tag").addEventListener('click', addContentMyDish);
    document.getElementById("second__tag").addEventListener('click', addContentMyFavorite);
    
}



function addContentMyDish() {
 document.getElementById("cnt__myfavorite").classList.add('dispnone');
    document.getElementById("cnt__mydishes").classList.remove('dispnone');
   
   
    document.getElementById("first__tag").classList.add('active');
    document.getElementById("second__tag").classList.remove('active');
}

function addContentMyFavorite() {
    document.getElementById("cnt__mydishes").classList.add('dispnone');
    document.getElementById("cnt__myfavorite").classList.remove('dispnone');

 document.getElementById("second__tag").classList.add('active');
    document.getElementById("first__tag").classList.remove('active');
   
}


/* ---------- btn add photo ------------------*/

let addPhotoArea = document.getElementById('addPhotoArea');
let addPhotoBtn = document.getElementById('addPhotoBtn');



addPhotoArea.onmouseenter = function () {
    addPhotoBtn.hidden = false;
}

addPhotoArea.onmouseleave = function () {
    addPhotoBtn.hidden = true;
}

addPhotoBtn.onmouseenter = function () {
    addPhotoBtn.hidden = false;
}

addPhotoBtn.onmouseleave = function () {
    addPhotoBtn.hidden = true;
}

