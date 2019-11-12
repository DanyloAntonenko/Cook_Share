

function addContentMyDish() {
    document.getElementById("left__content").innerHTML = `
    <div class="content__mydishes">
              <div class="add-content__mydish">
                <img src="../img/plus.png" alt="" class="photo__add" />
                <button class="button__add-dish">Добавить</button>
              </div>

              <div class="content__mydish">
                <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                <h1></h1>
              </div>

              <div class="content__mydish">
                <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                <h1></h1>
              </div>

              <div class="content__mydish">
                <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                <h1></h1>
              </div>

              <div class="content__mydish">
                <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                <h1></h1>
              </div>

              <div class="content__mydish">
                <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                <h1></h1>
              </div>
            </div>`;
}

function addContentMyFavorite() {
    document.getElementById("left__content").innerHTML = `
    <div class="content__mydishes">
              

              <div class="content__mydish">
                <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                <h1></h1>
              </div>

              <div class="content__mydish">
                <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                <h1></h1>
              </div>

              <div class="content__mydish">
                <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                <h1></h1>
              </div>

              <div class="content__mydish">
                <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                <h1></h1>
              </div>

              <div class="content__mydish">
                <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                <h1></h1>
              </div>
            </div>`;
}


/* ---------- btn add photo ------------------*/

let addPhotoArea = document.getElementById('addPhotoArea');
let addPhotoBtn = document.getElementById('addPhotoBtn');


addPhotoArea.onmouseover = function () {
    addPhotoBtn.hidden = false;
}

addPhotoArea.onmouseout = function () {
    addPhotoBtn.hidden = true;
}

addPhotoBtn.onmouseover = function () {
    addPhotoBtn.hidden = false;
}

