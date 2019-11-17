window.onload = function () {
    document.getElementById("first__tag").addEventListener('click', addContentMyDish);
    document.getElementById("second__tag").addEventListener('click', addContentMyFavorite);
}

function addContentMyDish() {
    document.getElementById("left__content").innerHTML = `
   <div class="content__mydishes">
                    <a  asp-area="" asp-controller="Account" asp-action="AddDish"  class="link__dish__add">
                        <div class="add-content__mydish">
                            <img src="../img/plus.png" alt="" class="photo__add" />
                          
                        </div>
                    </a>
                    <a  asp-area="" asp-controller="Account" asp-action="Dish"  class="link__dish">
                        <div class="content__mydish">

                            <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                            <h1></h1>
                        </div>
                    </a>

                    <a href='@Url.Action("Dish","Account", Model, null)' class="link__dish">
                        <div class="content__mydish">
                            <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                            <h1></h1>
                        </div>
                    </a>

                    <a href='@Url.Action("Dish","Account", Model, null)' class="link__dish">
                        <div class="content__mydish">
                            <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                            <h1></h1>
                        </div>
                    </a>

                    <a href='@Url.Action("Dish","Account", Model, null)' class="link__dish">
                        <div class="content__mydish">
                            <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                            <h1></h1>
                        </div>
                    </a>

                    <a href='@Url.Action("Dish","Account", Model, null)' class="link__dish">
                        <div class="content__mydish">
                            <img src="../img/photo-food-1.png" alt="" class="photo__dish" />
                            <h1></h1>
                        </div>
                    </a>
</div> `;
    document.getElementById("first__tag").classList.add('active');
    document.getElementById("second__tag").classList.remove('active');
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
    document.getElementById("first__tag").classList.remove('active');
    document.getElementById("second__tag").classList.add('active');
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

